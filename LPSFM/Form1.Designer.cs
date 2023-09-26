﻿namespace LPSFM
{
    partial class Form1
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
            savesListBoxContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 394);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 3;
            label4.Text = "Backup Folder Path";
            // 
            // backupPathTextBox
            // 
            backupPathTextBox.Location = new Point(142, 391);
            backupPathTextBox.Name = "backupPathTextBox";
            backupPathTextBox.Size = new Size(238, 23);
            backupPathTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 365);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 7;
            label2.Text = "Save Folder Path";
            // 
            // savePathTextBox
            // 
            savePathTextBox.Location = new Point(142, 362);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.Size = new Size(238, 23);
            savePathTextBox.TabIndex = 6;
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(45, 420);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(335, 38);
            logTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 420);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "Log";
            // 
            // quickSaveButton
            // 
            quickSaveButton.Location = new Point(12, 12);
            quickSaveButton.Name = "quickSaveButton";
            quickSaveButton.Size = new Size(94, 23);
            quickSaveButton.TabIndex = 10;
            quickSaveButton.Text = "Quick Save";
            quickSaveButton.UseVisualStyleBackColor = true;
            quickSaveButton.Click += quickSaveButton_Click;
            // 
            // manualSaveButton
            // 
            manualSaveButton.Location = new Point(12, 41);
            manualSaveButton.Name = "manualSaveButton";
            manualSaveButton.Size = new Size(94, 23);
            manualSaveButton.TabIndex = 11;
            manualSaveButton.Text = "Manual Save";
            manualSaveButton.UseVisualStyleBackColor = true;
            manualSaveButton.Click += manualSaveButton_Click;
            // 
            // saveNameTextBox
            // 
            saveNameTextBox.Location = new Point(161, 41);
            saveNameTextBox.Name = "saveNameTextBox";
            saveNameTextBox.Size = new Size(219, 23);
            saveNameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 45);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "name:";
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
            savesListBox.FormattingEnabled = true;
            savesListBox.ItemHeight = 15;
            savesListBox.Location = new Point(12, 70);
            savesListBox.Name = "savesListBox";
            savesListBox.Size = new Size(368, 289);
            savesListBox.TabIndex = 15;
            // 
            // savesListBoxContextMenu
            // 
            savesListBoxContextMenu.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, deleteToolStripMenuItem });
            savesListBoxContextMenu.Name = "contextMenuStrip1";
            savesListBoxContextMenu.Size = new Size(181, 70);
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 470);
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
            Name = "Form1";
            Text = "LPSFM";
            savesListBoxContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox backupPathTextBox;
        private Label label1;
        private TextBox savePathOldTextBox;
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
    }
}