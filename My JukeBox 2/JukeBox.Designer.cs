namespace My_JukeBox_2
{
    partial class JukeBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JukeBox));
            this.txt_Genre_Title = new System.Windows.Forms.TextBox();
            this.lst_Genre = new System.Windows.Forms.ListBox();
            this.hScrollBar_Genre = new System.Windows.Forms.HScrollBar();
            this.txt_Playing = new System.Windows.Forms.TextBox();
            this.lst_Playlist = new System.Windows.Forms.ListBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Genre_Title
            // 
            this.txt_Genre_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Genre_Title.Location = new System.Drawing.Point(144, 124);
            this.txt_Genre_Title.Name = "txt_Genre_Title";
            this.txt_Genre_Title.Size = new System.Drawing.Size(228, 20);
            this.txt_Genre_Title.TabIndex = 1;
            // 
            // lst_Genre
            // 
            this.lst_Genre.FormattingEnabled = true;
            this.lst_Genre.Location = new System.Drawing.Point(144, 144);
            this.lst_Genre.Name = "lst_Genre";
            this.lst_Genre.Size = new System.Drawing.Size(228, 95);
            this.lst_Genre.TabIndex = 2;
            // 
            // hScrollBar_Genre
            // 
            this.hScrollBar_Genre.LargeChange = 1;
            this.hScrollBar_Genre.Location = new System.Drawing.Point(144, 239);
            this.hScrollBar_Genre.Minimum = 1;
            this.hScrollBar_Genre.Name = "hScrollBar_Genre";
            this.hScrollBar_Genre.Size = new System.Drawing.Size(228, 26);
            this.hScrollBar_Genre.TabIndex = 3;
            this.hScrollBar_Genre.Value = 1;
            // 
            // txt_Playing
            // 
            this.txt_Playing.BackColor = System.Drawing.Color.Lime;
            this.txt_Playing.Location = new System.Drawing.Point(120, 276);
            this.txt_Playing.Name = "txt_Playing";
            this.txt_Playing.ReadOnly = true;
            this.txt_Playing.Size = new System.Drawing.Size(266, 20);
            this.txt_Playing.TabIndex = 6;
            // 
            // lst_Playlist
            // 
            this.lst_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lst_Playlist.FormattingEnabled = true;
            this.lst_Playlist.Location = new System.Drawing.Point(144, 326);
            this.lst_Playlist.Name = "lst_Playlist";
            this.lst_Playlist.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_Playlist.Size = new System.Drawing.Size(218, 134);
            this.lst_Playlist.TabIndex = 7;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(18, 13);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(217, 56);
            this.MediaPlayer.TabIndex = 5;
            this.MediaPlayer.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(499, 24);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "menuStrip1";
            // 
            // JukeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 641);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.lst_Playlist);
            this.Controls.Add(this.txt_Playing);
            this.Controls.Add(this.hScrollBar_Genre);
            this.Controls.Add(this.lst_Genre);
            this.Controls.Add(this.txt_Genre_Title);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Name = "JukeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My JukeBox ";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Genre_Title;
        private System.Windows.Forms.ListBox lst_Genre;
        public System.Windows.Forms.HScrollBar hScrollBar_Genre;
        private System.Windows.Forms.TextBox txt_Playing;
        private System.Windows.Forms.ListBox lst_Playlist;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip MainMenu;
    }
}

