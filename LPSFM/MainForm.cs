using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using LPSFM.Properties;
using Microsoft.Win32;
using WK.Libraries.HotkeyListenerNS;

namespace LPSFM;

public partial class MainForm : Form
{
    private readonly Settings _settings = Settings.Default;

    private readonly HotkeyListener _hkl = new();
    private Hotkey _quickSaveHotKey = null!;

    private const string DatetimeFormat = "yyyyMMddHHmm";
    private const int DateIndex = 0;
    private const int NameIndex = 1;

    private bool _internet = true;
    private bool _explorer = true;

    public MainForm()
    {
        InitializeComponent();

        ConfigureBackupPath();
        ConfigureSavePath();
        ConfigureHotkey();
        ListSaves();
        ConfigureFunctionButtons();

        Log("LPSFM v" + Application.ProductVersion);
    }

    public void Log(string message)
    {
        logTextBox.Text = $@"{DateTime.Now:mm:ss}: {message}" + Environment.NewLine + logTextBox.Text;
    }

    #region inital setup

    public void ConfigureSavePath()
    {
        if (string.IsNullOrEmpty(_settings.SavePath))
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                path = Path.Combine(path, "Packages");
                path = Directory.GetDirectories(path).FirstOrDefault(x => x.Contains("Neowiz"));
                path = Path.Combine(path!, "SystemAppData", "wgs");
                path = Directory.GetDirectories(path).OrderByDescending(x => x.Length).First();
                _settings.SavePath = path;

                Log("Save path not set, using " + path);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Could not find save path. Please set it manually.");
            }
        }

        _settings.Save();

        savePathTextBox.Text = _settings.SavePath;
    }

    public void ConfigureBackupPath()
    {
        if (string.IsNullOrEmpty(_settings.BackupPath))
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = Path.Combine(path, "LPSFM Backup");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            _settings.BackupPath = path;

            Log("Backup path not set, using " + path);
        }

        _settings.Save();

        backupPathTextBox.Text = _settings.BackupPath;
    }

    public void ConfigureHotkey()
    {
        quickSaveHotKeyTextBox.Text = _settings.QuickSaveHotKey;
        _quickSaveHotKey = new Hotkey(_settings.QuickSaveHotKey);
        _hkl.Add(_quickSaveHotKey);
        _hkl.HotkeyPressed += Hkl_HotkeyPressed;
    }

    public void ConfigureFunctionButtons()
    {
        internetButton.Text = _internet ? @"Disable Internet" : @"Enable Internet";
        explorerButton.Text = _explorer ? @"Disable Explorer" : @"Enable Explorer";
    }

    #endregion

    #region save

    public void Save(string name)
    {
        var path = backupPathTextBox.Text;

        Directory.GetDirectories(path)
            .Where(x =>
            {
                var dirName = new DirectoryInfo(x).Name;
                return dirName.Split('_')[NameIndex].Equals(name);
            })
            .ToList()
            .ForEach(x => Directory.Delete(x, true));

        var dir = $"{DateTime.Now.ToString(DatetimeFormat)}_{name}";

        path = Path.Combine(path, dir);
        Helpers.CopyFilesRecursively(savePathTextBox.Text, path);

        ListSaves();

        Log("Saved " + name + ".");
    }

    private void QuickSaveButton_Click(object sender, EventArgs e)
    {
        Save("Quick Save");
    }

    private void ManualSaveButton_Click(object sender, EventArgs e)
    {
        var name = saveNameTextBox.Text;

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show(@"Please enter a name for the save.");
            return;
        }

        if (Path.GetInvalidFileNameChars().Any(c => name.Contains(c)))
        {
            MessageBox.Show(@"Please enter a valid name for a windows directory.");
            return;
        }

        name = name.Replace("_", " ");
        Save(name);
    }

    #endregion

    #region list box

    public void ListSaves()
    {
        savesListBox.Items.Clear();

        var path = backupPathTextBox.Text;

        if (!Directory.Exists(path))
            return;

        var saves = Directory.GetDirectories(path)
            .Select(x => new DirectoryInfo(x).Name)
            .Select(x => x.Split('_'))
            .Select(x =>
            {
                try
                {
                    return new
                    {
                        Date = DateTime.ParseExact(x[DateIndex], DatetimeFormat, CultureInfo.InvariantCulture),
                        Name = x[NameIndex]
                    };
                }
                catch (Exception)
                {
                    return null;
                }
            })
            .Where(x => x is not null)
            .OrderByDescending(x => x!.Date)
            .Select(x => x!.Name)
            .ToList();

        saves.ForEach(x => savesListBox.Items.Add(x));
    }


    private void SavesListBox_MouseDown(object sender, MouseEventArgs e)
    {
        savesListBox.SelectedIndex = savesListBox.IndexFromPoint(e.Location);
    }

    #endregion

    #region strip menu

    public bool TryGetSelectedItemName(out string? name)
    {
        name = savesListBox.SelectedItem?.ToString();

        if (name is null)
        {
            MessageBox.Show(@"Please select a save item.");
            return false;
        }

        return true;
    }

    public bool TryGetSavePath(string saveName, out string? dirPath)
    {
        dirPath = Directory.GetDirectories(backupPathTextBox.Text)
            .FirstOrDefault(x =>
            {
                var dirName = new DirectoryInfo(x).Name;
                return dirName.Split('_')[NameIndex].Equals(saveName);
            });

        if (dirPath is null)
        {
            Log("Could not find save item.");
            return false;
        };

        return true;
    }

    private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!TryGetSelectedItemName(out var saveName))
            return;

        if (!TryGetSavePath(saveName!, out var dirPath))
            return;

        if (!saveName!.Equals("Backup"))
            Save("Backup");

        Helpers.CopyFilesRecursively(dirPath!, savePathTextBox.Text);

        Log("Loaded " + saveName + ".");
    }

    public void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!TryGetSelectedItemName(out var saveName))
            return;

        if (!TryGetSavePath(saveName!, out var dirPath))
            return;

        var confirmResult = MessageBox.Show($@"Are you sure you want to delete '{saveName}' save files?", @"Confirm Delete", MessageBoxButtons.YesNo);

        if (confirmResult != DialogResult.Yes)
            return;

        Directory.Delete(dirPath!, true);

        ListSaves();

        Log("Deleted " + saveName + ".");
    }

    #endregion

    #region hotkey

    private void QuickSaveHotKeyTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            _hkl.Remove(_quickSaveHotKey);
            _quickSaveHotKey = new Hotkey(quickSaveHotKeyTextBox.Text);
            _hkl.Add(_quickSaveHotKey);
            _settings.QuickSaveHotKey = quickSaveHotKeyTextBox.Text;
            _settings.Save();
            Log("Hotkey set to " + quickSaveHotKeyTextBox.Text);
        }
        catch (Exception)
        {
            Log("Invalid hotkey.");
        }
    }

    private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
    {
        if (e.Hotkey == _quickSaveHotKey)
        {
            quickSaveButton.PerformClick();
        }
    }

    #endregion

    #region browse buttons

    private void BrowseSaveFolderButton_Click(object sender, EventArgs e)
    {
        folderBrowserDialog.SelectedPath = savePathTextBox.Text;
        var result = folderBrowserDialog.ShowDialog();

        if (result == DialogResult.OK)
        {
            savePathTextBox.Text = folderBrowserDialog.SelectedPath;
            _settings.SavePath = folderBrowserDialog.SelectedPath;
            _settings.Save();
        }
    }

    private void BrowseBackupFolderButton_Click(object sender, EventArgs e)
    {
        folderBrowserDialog.SelectedPath = backupPathTextBox.Text;
        var result = folderBrowserDialog.ShowDialog();

        if (result == DialogResult.OK)
        {
            backupPathTextBox.Text = folderBrowserDialog.SelectedPath;
            _settings.BackupPath = folderBrowserDialog.SelectedPath;
            _settings.Save();
            ListSaves();
        }
    }

    #endregion

    #region functions

    private void InternetButton_Click(object sender, EventArgs e)
    {
        if (_internet)
        {
            System.Diagnostics.Process.Start("ipconfig", "/release");
            _internet = false;
            Log("Internet disabled.");
        }
        else
        {
            System.Diagnostics.Process.Start("ipconfig", "/renew");
            _internet = true;
            Log("Internet enabled.");
        }
        ConfigureFunctionButtons();
    }

    private void ExplorerButton_Click(object sender, EventArgs e)
    {
        if (_explorer)
        {
            var ourKey = Registry.LocalMachine;
            ourKey = ourKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            ourKey.SetValue("AutoRestartShell", 0);
            var processes = Process.GetProcessesByName("explorer");
            foreach (var process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }
            ourKey.SetValue("AutoRestartShell", 1);

            _explorer = false;
            Log("Explorer closed.");
        }
        else
        {
            System.Diagnostics.Process.Start("explorer.exe");
            _explorer = true;
            Log("Explorer opened.");
        }
        ConfigureFunctionButtons();
    }

    #endregion
}