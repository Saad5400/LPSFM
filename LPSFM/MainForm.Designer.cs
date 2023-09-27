namespace LPSFM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label4 = new Label();
            backupPathTextBox = new TextBox();
            label2 = new Label();
            savePathTextBox = new TextBox();
            logTextBox = new TextBox();
            label3 = new Label();
            quickSaveButton = new Button();
            manualSaveButton = new Button();
            saveNameTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            savesListBox = new ListBox();
            savesListBoxContextMenu = new ContextMenuStrip(components);
            loadToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            quickSaveHotKeyTextBox = new TextBox();
            browseSaveFolderButton = new Button();
            browseBackupFolderButton = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            internetButton = new Button();
            explorerButton = new Button();
            overwriteToolStripMenuItem = new ToolStripMenuItem();
            savesListBoxContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(14, 479);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "Backup Folder Path";
            // 
            // backupPathTextBox
            // 
            backupPathTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backupPathTextBox.Location = new Point(14, 503);
            backupPathTextBox.Margin = new Padding(3, 4, 3, 4);
            backupPathTextBox.Name = "backupPathTextBox";
            backupPathTextBox.ReadOnly = true;
            backupPathTextBox.Size = new Size(297, 27);
            backupPathTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(14, 420);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 7;
            label2.Text = "Save Folder Path";
            // 
            // savePathTextBox
            // 
            savePathTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savePathTextBox.Location = new Point(14, 444);
            savePathTextBox.Margin = new Padding(3, 4, 3, 4);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.ReadOnly = true;
            savePathTextBox.Size = new Size(297, 27);
            savePathTextBox.TabIndex = 6;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.Location = new Point(51, 541);
            logTextBox.Margin = new Padding(3, 4, 3, 4);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(331, 67);
            logTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(14, 537);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 9;
            label3.Text = "Log";
            // 
            // quickSaveButton
            // 
            quickSaveButton.Location = new Point(14, 16);
            quickSaveButton.Margin = new Padding(3, 4, 3, 4);
            quickSaveButton.Name = "quickSaveButton";
            quickSaveButton.Size = new Size(107, 33);
            quickSaveButton.TabIndex = 10;
            quickSaveButton.Text = "Quick Save";
            quickSaveButton.UseVisualStyleBackColor = true;
            quickSaveButton.Click += QuickSaveButton_Click;
            // 
            // manualSaveButton
            // 
            manualSaveButton.Location = new Point(14, 55);
            manualSaveButton.Margin = new Padding(3, 4, 3, 4);
            manualSaveButton.Name = "manualSaveButton";
            manualSaveButton.Size = new Size(107, 31);
            manualSaveButton.TabIndex = 11;
            manualSaveButton.Text = "Manual Save";
            manualSaveButton.UseVisualStyleBackColor = true;
            manualSaveButton.Click += ManualSaveButton_Click;
            // 
            // saveNameTextBox
            // 
            saveNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveNameTextBox.Location = new Point(184, 55);
            saveNameTextBox.Margin = new Padding(3, 4, 3, 4);
            saveNameTextBox.Name = "saveNameTextBox";
            saveNameTextBox.Size = new Size(198, 27);
            saveNameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 60);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 13;
            label5.Text = "name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 21);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 14;
            label6.Text = "hotkey";
            // 
            // savesListBox
            // 
            savesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savesListBox.ContextMenuStrip = savesListBoxContextMenu;
            savesListBox.FormattingEnabled = true;
            savesListBox.ItemHeight = 20;
            savesListBox.Location = new Point(14, 93);
            savesListBox.Margin = new Padding(3, 4, 3, 4);
            savesListBox.Name = "savesListBox";
            savesListBox.Size = new Size(369, 284);
            savesListBox.TabIndex = 15;
            savesListBox.MouseDown += SavesListBox_MouseDown;
            // 
            // savesListBoxContextMenu
            // 
            savesListBoxContextMenu.ImageScalingSize = new Size(20, 20);
            savesListBoxContextMenu.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, overwriteToolStripMenuItem, deleteToolStripMenuItem });
            savesListBoxContextMenu.Name = "contextMenuStrip1";
            savesListBoxContextMenu.Size = new Size(211, 104);
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(210, 24);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(210, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // quickSaveHotKeyTextBox
            // 
            quickSaveHotKeyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quickSaveHotKeyTextBox.Location = new Point(184, 16);
            quickSaveHotKeyTextBox.Margin = new Padding(3, 4, 3, 4);
            quickSaveHotKeyTextBox.Name = "quickSaveHotKeyTextBox";
            quickSaveHotKeyTextBox.Size = new Size(198, 27);
            quickSaveHotKeyTextBox.TabIndex = 16;
            quickSaveHotKeyTextBox.TextChanged += QuickSaveHotKeyTextBox_TextChanged;
            // 
            // browseSaveFolderButton
            // 
            browseSaveFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            browseSaveFolderButton.Location = new Point(318, 444);
            browseSaveFolderButton.Margin = new Padding(3, 4, 3, 4);
            browseSaveFolderButton.Name = "browseSaveFolderButton";
            browseSaveFolderButton.Size = new Size(65, 31);
            browseSaveFolderButton.TabIndex = 17;
            browseSaveFolderButton.Text = "browse";
            browseSaveFolderButton.UseVisualStyleBackColor = true;
            browseSaveFolderButton.Click += BrowseSaveFolderButton_Click;
            // 
            // browseBackupFolderButton
            // 
            browseBackupFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            browseBackupFolderButton.Location = new Point(318, 503);
            browseBackupFolderButton.Margin = new Padding(3, 4, 3, 4);
            browseBackupFolderButton.Name = "browseBackupFolderButton";
            browseBackupFolderButton.Size = new Size(65, 31);
            browseBackupFolderButton.TabIndex = 18;
            browseBackupFolderButton.Text = "browse";
            browseBackupFolderButton.UseVisualStyleBackColor = true;
            browseBackupFolderButton.Click += BrowseBackupFolderButton_Click;
            // 
            // internetButton
            // 
            internetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            internetButton.Location = new Point(14, 385);
            internetButton.Margin = new Padding(3, 4, 3, 4);
            internetButton.Name = "internetButton";
            internetButton.Size = new Size(187, 31);
            internetButton.TabIndex = 19;
            internetButton.Text = "Disable Internet";
            internetButton.UseVisualStyleBackColor = true;
            internetButton.Click += InternetButton_Click;
            // 
            // explorerButton
            // 
            explorerButton.Location = new Point(208, 385);
            explorerButton.Margin = new Padding(3, 4, 3, 4);
            explorerButton.Name = "explorerButton";
            explorerButton.Size = new Size(175, 31);
            explorerButton.TabIndex = 20;
            explorerButton.Text = "Disable Explorer";
            explorerButton.UseVisualStyleBackColor = true;
            explorerButton.Click += ExplorerButton_Click;
            // 
            // overwriteToolStripMenuItem
            // 
            overwriteToolStripMenuItem.Name = "overwriteToolStripMenuItem";
            overwriteToolStripMenuItem.Size = new Size(210, 24);
            overwriteToolStripMenuItem.Text = "Overwrite";
            overwriteToolStripMenuItem.Click += OverwriteToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 628);
            Controls.Add(explorerButton);
            Controls.Add(internetButton);
            Controls.Add(browseBackupFolderButton);
            Controls.Add(browseSaveFolderButton);
            Controls.Add(quickSaveHotKeyTextBox);
            Controls.Add(savesListBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(saveNameTextBox);
            Controls.Add(manualSaveButton);
            Controls.Add(quickSaveButton);
            Controls.Add(label3);
            Controls.Add(logTextBox);
            Controls.Add(label2);
            Controls.Add(savePathTextBox);
            Controls.Add(label4);
            Controls.Add(backupPathTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "LPSFM";
            savesListBoxContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox backupPathTextBox;
        private Label label2;
        private TextBox savePathTextBox;
        private TextBox logTextBox;
        private Label label3;
        private Button quickSaveButton;
        private Button manualSaveButton;
        private TextBox saveNameTextBox;
        private Label label5;
        private Label label6;
        private ListBox savesListBox;
        private ContextMenuStrip savesListBoxContextMenu;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox quickSaveHotKeyTextBox;
        private Button browseSaveFolderButton;
        private Button browseBackupFolderButton;
        private FolderBrowserDialog folderBrowserDialog;
        private Button internetButton;
        private Button explorerButton;
        private ToolStripMenuItem overwriteToolStripMenuItem;
    }
}