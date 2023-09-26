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
            savesListBoxContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 359);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 3;
            label4.Text = "Backup Folder Path";
            // 
            // backupPathTextBox
            // 
            backupPathTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backupPathTextBox.Location = new Point(12, 377);
            backupPathTextBox.Name = "backupPathTextBox";
            backupPathTextBox.ReadOnly = true;
            backupPathTextBox.Size = new Size(260, 23);
            backupPathTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 7;
            label2.Text = "Save Folder Path";
            // 
            // savePathTextBox
            // 
            savePathTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savePathTextBox.Location = new Point(12, 333);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.ReadOnly = true;
            savePathTextBox.Size = new Size(260, 23);
            savePathTextBox.TabIndex = 6;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.Location = new Point(45, 406);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(290, 51);
            logTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 403);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "Log";
            // 
            // quickSaveButton
            // 
            quickSaveButton.Location = new Point(12, 12);
            quickSaveButton.Name = "quickSaveButton";
            quickSaveButton.Size = new Size(94, 25);
            quickSaveButton.TabIndex = 10;
            quickSaveButton.Text = "Quick Save";
            quickSaveButton.UseVisualStyleBackColor = true;
            quickSaveButton.Click += QuickSaveButton_Click;
            // 
            // manualSaveButton
            // 
            manualSaveButton.Location = new Point(12, 41);
            manualSaveButton.Name = "manualSaveButton";
            manualSaveButton.Size = new Size(94, 23);
            manualSaveButton.TabIndex = 11;
            manualSaveButton.Text = "Manual Save";
            manualSaveButton.UseVisualStyleBackColor = true;
            manualSaveButton.Click += ManualSaveButton_Click;
            // 
            // saveNameTextBox
            // 
            saveNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveNameTextBox.Location = new Point(161, 41);
            saveNameTextBox.Name = "saveNameTextBox";
            saveNameTextBox.Size = new Size(174, 23);
            saveNameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 45);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 13;
            label5.Text = "name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 16);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "hotkey";
            // 
            // savesListBox
            // 
            savesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savesListBox.ContextMenuStrip = savesListBoxContextMenu;
            savesListBox.FormattingEnabled = true;
            savesListBox.ItemHeight = 15;
            savesListBox.Location = new Point(12, 70);
            savesListBox.Name = "savesListBox";
            savesListBox.Size = new Size(323, 214);
            savesListBox.TabIndex = 15;
            savesListBox.MouseDown += SavesListBox_MouseDown;
            // 
            // savesListBoxContextMenu
            // 
            savesListBoxContextMenu.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, deleteToolStripMenuItem });
            savesListBoxContextMenu.Name = "contextMenuStrip1";
            savesListBoxContextMenu.Size = new Size(108, 48);
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(107, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // quickSaveHotKeyTextBox
            // 
            quickSaveHotKeyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quickSaveHotKeyTextBox.Location = new Point(161, 12);
            quickSaveHotKeyTextBox.Name = "quickSaveHotKeyTextBox";
            quickSaveHotKeyTextBox.Size = new Size(174, 23);
            quickSaveHotKeyTextBox.TabIndex = 16;
            quickSaveHotKeyTextBox.TextChanged += QuickSaveHotKeyTextBox_TextChanged;
            // 
            // browseSaveFolderButton
            // 
            browseSaveFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            browseSaveFolderButton.Location = new Point(278, 333);
            browseSaveFolderButton.Name = "browseSaveFolderButton";
            browseSaveFolderButton.Size = new Size(57, 23);
            browseSaveFolderButton.TabIndex = 17;
            browseSaveFolderButton.Text = "browse";
            browseSaveFolderButton.UseVisualStyleBackColor = true;
            browseSaveFolderButton.Click += BrowseSaveFolderButton_Click;
            // 
            // browseBackupFolderButton
            // 
            browseBackupFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            browseBackupFolderButton.Location = new Point(278, 377);
            browseBackupFolderButton.Name = "browseBackupFolderButton";
            browseBackupFolderButton.Size = new Size(57, 23);
            browseBackupFolderButton.TabIndex = 18;
            browseBackupFolderButton.Text = "browse";
            browseBackupFolderButton.UseVisualStyleBackColor = true;
            browseBackupFolderButton.Click += BrowseBackupFolderButton_Click;
            // 
            // internetButton
            // 
            internetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            internetButton.Location = new Point(12, 289);
            internetButton.Name = "internetButton";
            internetButton.Size = new Size(323, 23);
            internetButton.TabIndex = 19;
            internetButton.Text = "Disable Internet";
            internetButton.UseVisualStyleBackColor = true;
            internetButton.Click += InternetButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 471);
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
    }
}