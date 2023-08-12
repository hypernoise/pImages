namespace pImages
{
    partial class mainForm
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
            openFileDialog = new OpenFileDialog();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            testTextBox = new TextBox();
            ImageControlPanel = new UserControlPanel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(802, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, testToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(103, 22);
            testToolStripMenuItem.Text = "Test";
            // 
            // testTextBox
            // 
            testTextBox.Dock = DockStyle.Bottom;
            testTextBox.Location = new Point(0, 635);
            testTextBox.Name = "testTextBox";
            testTextBox.Size = new Size(802, 23);
            testTextBox.TabIndex = 2;
            testTextBox.TextChanged += testTextBox_TextChanged;
            // 
            // ImageControlPanel
            // 
            ImageControlPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ImageControlPanel.BackColor = SystemColors.ActiveCaptionText;
            ImageControlPanel.Dock = DockStyle.Fill;
            ImageControlPanel.Location = new Point(0, 24);
            ImageControlPanel.Name = "ImageControlPanel";
            ImageControlPanel.Size = new Size(802, 611);
            ImageControlPanel.TabIndex = 5;
            ImageControlPanel.MouseDown += ImageControlPanel_MouseDown;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(802, 658);
            Controls.Add(ImageControlPanel);
            Controls.Add(testTextBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "pImages";
            Load += mainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private TextBox testTextBox;
        private ToolStripMenuItem testToolStripMenuItem;
        private UserControlPanel ImageControlPanel;
    }
}