namespace TJCPowerPointCSharp
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.sermonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sermonHymnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibleVerseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherSlidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sermonToolStripMenuItem,
            this.sermonHymnsToolStripMenuItem,
            this.bibleVerseToolStripMenuItem,
            this.otherSlidesToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(5);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(809, 24);
            this.MainMenu.Stretch = false;
            this.MainMenu.TabIndex = 0;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sermonToolStripMenuItem
            // 
            this.sermonToolStripMenuItem.Checked = true;
            this.sermonToolStripMenuItem.CheckOnClick = true;
            this.sermonToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sermonToolStripMenuItem.Name = "sermonToolStripMenuItem";
            this.sermonToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.sermonToolStripMenuItem.Text = "Hymnal Worship";
            this.sermonToolStripMenuItem.Click += new System.EventHandler(this.sermonToolStripMenuItem_Click);
            // 
            // sermonHymnsToolStripMenuItem
            // 
            this.sermonHymnsToolStripMenuItem.CheckOnClick = true;
            this.sermonHymnsToolStripMenuItem.Name = "sermonHymnsToolStripMenuItem";
            this.sermonHymnsToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.sermonHymnsToolStripMenuItem.Text = "Sermon Hymns";
            // 
            // bibleVerseToolStripMenuItem
            // 
            this.bibleVerseToolStripMenuItem.CheckOnClick = true;
            this.bibleVerseToolStripMenuItem.Name = "bibleVerseToolStripMenuItem";
            this.bibleVerseToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.bibleVerseToolStripMenuItem.Text = "Bible Verse";
            // 
            // otherSlidesToolStripMenuItem
            // 
            this.otherSlidesToolStripMenuItem.CheckOnClick = true;
            this.otherSlidesToolStripMenuItem.Name = "otherSlidesToolStripMenuItem";
            this.otherSlidesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.otherSlidesToolStripMenuItem.Text = "Other slides";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.ControlBox = false;
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainProgram";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem sermonToolStripMenuItem;
        private ToolStripMenuItem sermonHymnsToolStripMenuItem;
        private ToolStripMenuItem bibleVerseToolStripMenuItem;
        private ToolStripMenuItem otherSlidesToolStripMenuItem;
    }
}