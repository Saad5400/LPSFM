using System.Globalization;
using LPSFM.Properties;
using WK.Libraries.HotkeyListenerNS;

namespace LPSFM;

public partial class Form1 : Form
{
    private readonly Settings _settings = Settings.Default;

    private readonly HotkeyListener _hkl = new();
    private Hotkey _quickSaveHotKey;

    private const string DatetimeFormat = "yyyyMMddHHmm";
    private const int DateIndex = 0;
    private const int NameIndex = 1;

    public Form1()
    {
        InitializeComponent();

        Log("LPSFM v" + Application.ProductVersion);

        if (string.IsNullOrEmpty(_settings.SavePath))
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = Path.Combine(path, "Packages");
            path = Directory.GetDirectories(path).FirstOrDefault(x => x.Contains("Neowiz"));
            path = Path.Combine(path, "SystemAppData", "wgs");
            path = Directory.GetDirectories(path).OrderByDescending(x => x.Length).First();
            _settings.SavePath = path;

            Log("Save path not set, using " + path);
        }

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

        savePathTextBox.Text = _settings.SavePath;
        backupPathTextBox.Text = _settings.BackupPath;
        quickSaveHotKeyTextBox.Text = _settings.QuickSaveHotKey;

        savesListBox.ContextMenuStrip = savesListBoxContextMenu;

        ListSaves();

        _quickSaveHotKey = new Hotkey(_settings.QuickSaveHotKey);
        _hkl.Add(_quickSaveHotKey);
        _hkl.HotkeyPressed += Hkl_HotkeyPressed;
    }

    public void Log(string message)
    {
        logTextBox.Text = DateTime.Now.ToString("mm:ss") + @": " + message + Environment.NewLine + logTextBox.Text;
    }

    private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
    {
        if (e.Hotkey == _quickSaveHotKey)
        {
            quickSaveButton.PerformClick();
        }
    }

    public void ListSaves()
    {
        savesListBox.Items.Clear();

        var path = _settings.BackupPath;

        var saves = Directory.GetDirectories(path)
            .Select(x => new DirectoryInfo(x).Name)
            .Select(x => x.Split('_'))
            .Select(x => new
            {
                Date = DateTime.ParseExact(x[DateIndex], DatetimeFormat, CultureInfo.InvariantCulture),
                Name = x[NameIndex]
            })
            .OrderByDescending(x => x.Date)
            .Select(x => x.Name)
            .ToList();

        saves.ForEach(x => savesListBox.Items.Add(x));
    }

    public void Save(string name)
    {
        var path = _settings.BackupPath;

        Directory.GetDirectories(path)
            .Where(x =>
            {
                var dirName = new DirectoryInfo(x).Name;
                return dirName.Split('_')[NameIndex].Equals(name);
            })
            .ToList()
            .ForEach(x => Directory.Delete(x, true));

        var dir = $"{DateTime.Now.ToString(DatetimeFormat)}_{name}";
        Directory.CreateDirectory(dir);
        path = Path.Combine(path, dir);
        Helpers.CopyFilesRecursively(_settings.SavePath, path);

        ListSaves();

        Log("Saved " + name + ".");
    }

    private void quickSaveButton_Click(object sender, EventArgs e)
    {
        var name = "Quick Save";
        Save(name);
    }

    private void manualSaveButton_Click(object sender, EventArgs e)
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

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (savesListBox.SelectedItem == null)
        {
            MessageBox.Show(@"Please select a save to load.");
            return;
        }

        var confirmResult = MessageBox.Show(@"Are you sure you want to load this save? This will overwrite your current save.", @"Confirm Load", MessageBoxButtons.YesNo);

        if (confirmResult != DialogResult.Yes) return;

        var name = savesListBox.SelectedItem.ToString();

        var dir = Directory.GetDirectories(_settings.BackupPath)
            .FirstOrDefault(x =>
            {
                var dirName = new DirectoryInfo(x).Name;
                return dirName.Split('_')[NameIndex].Equals(name);
            });

        Helpers.CopyFilesRecursively(dir, _settings.SavePath);

        Log("Loaded " + name + ".");
    }

    public void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (savesListBox.SelectedItem == null)
        {
            MessageBox.Show(@"Please select a save to delete.");
            return;
        }

        var confirmResult = MessageBox.Show(@"Are you sure you want to delete this save?", @"Confirm Delete", MessageBoxButtons.YesNo);

        if (confirmResult != DialogResult.Yes) return;

        var name = savesListBox.SelectedItem.ToString();

        var dir = Directory.GetDirectories(_settings.BackupPath)
            .FirstOrDefault(x =>
            {
                var dirName = new DirectoryInfo(x).Name;
                return dirName.Split('_')[NameIndex].Equals(name);
            });

        Directory.Delete(dir, true);

        ListSaves();

        Log("Deleted " + name + ".");
    }

    private void quickSaveHotKeyTextBox_TextChanged(object sender, EventArgs e)
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

    private void savePathTextBox_TextChanged(object sender, EventArgs e)
    {
        _settings.SavePath = savePathTextBox.Text;
        _settings.Save();
    }

    private void backupPathTextBox_TextChanged(object sender, EventArgs e)
    {
        _settings.BackupPath = backupPathTextBox.Text;
        _settings.Save();
    }
}