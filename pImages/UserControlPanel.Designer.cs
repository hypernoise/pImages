namespace pImages
{
    partial class UserControlPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            ImagePanel = new Panel();
            ImageBox = new PictureBox();
            ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ImagePanel
            // 
            ImagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImagePanel.AutoScroll = true;
            ImagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ImagePanel.BackColor = SystemColors.Window;
            ImagePanel.Controls.Add(ImageBox);
            ImagePanel.Location = new Point(3, 3);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(794, 594);
            ImagePanel.TabIndex = 0;
            // 
            // ImageBox
            // 
            ImageBox.Location = new Point(0, 0);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(794, 594);
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            ImageBox.Click += ImageBox_Click;
            // 
            // UserControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(ImagePanel);
            Name = "UserControlPanel";
            Size = new Size(800, 600);
            ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel ImagePanel;
        public PictureBox ImageBox;

        /*
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= 0x840000;  // Turn on WS_BORDER + WS_THICKFRAME
                return cp;
            }
        }
        */
    }
}
