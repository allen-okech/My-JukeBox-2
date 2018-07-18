namespace My_JukeBox_2
{
    partial class SetupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_NextGenre = new System.Windows.Forms.Button();
            this.btn_DeleteGenre = new System.Windows.Forms.Button();
            this.btn_AddGenre = new System.Windows.Forms.Button();
            this.btn_PreviousGenre = new System.Windows.Forms.Button();
            this.lst_Present_Genre = new System.Windows.Forms.ListBox();
            this.txt_GenreTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteFromGenre = new System.Windows.Forms.Button();
            this.btn_MoveToGenre = new System.Windows.Forms.Button();
            this.btn_CopyToGenre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClearImportedTracks = new System.Windows.Forms.Button();
            this.btn_ImportTracks = new System.Windows.Forms.Button();
            this.lst_Imported = new System.Windows.Forms.ListBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_DeleteFromGenre);
            this.panel1.Controls.Add(this.btn_MoveToGenre);
            this.panel1.Controls.Add(this.btn_CopyToGenre);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 392);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_NextGenre);
            this.groupBox2.Controls.Add(this.btn_DeleteGenre);
            this.groupBox2.Controls.Add(this.btn_AddGenre);
            this.groupBox2.Controls.Add(this.btn_PreviousGenre);
            this.groupBox2.Controls.Add(this.lst_Present_Genre);
            this.groupBox2.Controls.Add(this.txt_GenreTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(399, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 364);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genre";
            // 
            // btn_NextGenre
            // 
            this.btn_NextGenre.Enabled = false;
            this.btn_NextGenre.Location = new System.Drawing.Point(162, 288);
            this.btn_NextGenre.Name = "btn_NextGenre";
            this.btn_NextGenre.Size = new System.Drawing.Size(75, 55);
            this.btn_NextGenre.TabIndex = 7;
            this.btn_NextGenre.Text = "Next >>";
            this.btn_NextGenre.UseVisualStyleBackColor = true;
            this.btn_NextGenre.Click += new System.EventHandler(this.btn_NextGenre_Click);
            // 
            // btn_DeleteGenre
            // 
            this.btn_DeleteGenre.Enabled = false;
            this.btn_DeleteGenre.Location = new System.Drawing.Point(90, 320);
            this.btn_DeleteGenre.Name = "btn_DeleteGenre";
            this.btn_DeleteGenre.Size = new System.Drawing.Size(58, 23);
            this.btn_DeleteGenre.TabIndex = 6;
            this.btn_DeleteGenre.Text = "Delete";
            this.btn_DeleteGenre.UseVisualStyleBackColor = true;
            this.btn_DeleteGenre.Click += new System.EventHandler(this.btn_DeleteGenre_Click);
            // 
            // btn_AddGenre
            // 
            this.btn_AddGenre.Location = new System.Drawing.Point(90, 288);
            this.btn_AddGenre.Name = "btn_AddGenre";
            this.btn_AddGenre.Size = new System.Drawing.Size(58, 23);
            this.btn_AddGenre.TabIndex = 8;
            this.btn_AddGenre.Text = "Add";
            this.btn_AddGenre.UseVisualStyleBackColor = true;
            this.btn_AddGenre.Click += new System.EventHandler(this.btn_AddGenre_Click);
            // 
            // btn_PreviousGenre
            // 
            this.btn_PreviousGenre.Enabled = false;
            this.btn_PreviousGenre.Location = new System.Drawing.Point(6, 288);
            this.btn_PreviousGenre.Name = "btn_PreviousGenre";
            this.btn_PreviousGenre.Size = new System.Drawing.Size(75, 55);
            this.btn_PreviousGenre.TabIndex = 5;
            this.btn_PreviousGenre.Text = "<< Previous";
            this.btn_PreviousGenre.UseVisualStyleBackColor = true;
            this.btn_PreviousGenre.Click += new System.EventHandler(this.btn_PreviousGenre_Click);
            // 
            // lst_Present_Genre
            // 
            this.lst_Present_Genre.FormattingEnabled = true;
            this.lst_Present_Genre.Location = new System.Drawing.Point(23, 65);
            this.lst_Present_Genre.Name = "lst_Present_Genre";
            this.lst_Present_Genre.Size = new System.Drawing.Size(192, 186);
            this.lst_Present_Genre.TabIndex = 2;
            // 
            // txt_GenreTitle
            // 
            this.txt_GenreTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GenreTitle.Enabled = false;
            this.txt_GenreTitle.Location = new System.Drawing.Point(23, 39);
            this.txt_GenreTitle.Name = "txt_GenreTitle";
            this.txt_GenreTitle.Size = new System.Drawing.Size(193, 20);
            this.txt_GenreTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre Title";
            // 
            // btn_DeleteFromGenre
            // 
            this.btn_DeleteFromGenre.Location = new System.Drawing.Point(274, 230);
            this.btn_DeleteFromGenre.Name = "btn_DeleteFromGenre";
            this.btn_DeleteFromGenre.Size = new System.Drawing.Size(109, 72);
            this.btn_DeleteFromGenre.TabIndex = 3;
            this.btn_DeleteFromGenre.Text = "Delete Track From Genre";
            this.btn_DeleteFromGenre.UseVisualStyleBackColor = true;
            this.btn_DeleteFromGenre.Click += new System.EventHandler(this.btn_DeleteFromGenre_Click);
            // 
            // btn_MoveToGenre
            // 
            this.btn_MoveToGenre.Location = new System.Drawing.Point(274, 128);
            this.btn_MoveToGenre.Name = "btn_MoveToGenre";
            this.btn_MoveToGenre.Size = new System.Drawing.Size(109, 23);
            this.btn_MoveToGenre.TabIndex = 2;
            this.btn_MoveToGenre.Text = "Move Track >>";
            this.btn_MoveToGenre.UseVisualStyleBackColor = true;
            this.btn_MoveToGenre.Click += new System.EventHandler(this.btn_MoveToGenre_Click);
            // 
            // btn_CopyToGenre
            // 
            this.btn_CopyToGenre.Location = new System.Drawing.Point(274, 93);
            this.btn_CopyToGenre.Name = "btn_CopyToGenre";
            this.btn_CopyToGenre.Size = new System.Drawing.Size(109, 23);
            this.btn_CopyToGenre.TabIndex = 1;
            this.btn_CopyToGenre.Text = "Copy Track >>";
            this.btn_CopyToGenre.UseVisualStyleBackColor = true;
            this.btn_CopyToGenre.Click += new System.EventHandler(this.btn_CopyToGenre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClearImportedTracks);
            this.groupBox1.Controls.Add(this.btn_ImportTracks);
            this.groupBox1.Controls.Add(this.lst_Imported);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Tracks";
            // 
            // btn_ClearImportedTracks
            // 
            this.btn_ClearImportedTracks.Location = new System.Drawing.Point(9, 326);
            this.btn_ClearImportedTracks.Name = "btn_ClearImportedTracks";
            this.btn_ClearImportedTracks.Size = new System.Drawing.Size(237, 34);
            this.btn_ClearImportedTracks.TabIndex = 2;
            this.btn_ClearImportedTracks.Text = "Clear Imported Tracks";
            this.btn_ClearImportedTracks.UseVisualStyleBackColor = true;
            this.btn_ClearImportedTracks.Click += new System.EventHandler(this.btn_ClearImportedTracks_Click);
            // 
            // btn_ImportTracks
            // 
            this.btn_ImportTracks.Location = new System.Drawing.Point(9, 290);
            this.btn_ImportTracks.Name = "btn_ImportTracks";
            this.btn_ImportTracks.Size = new System.Drawing.Size(237, 30);
            this.btn_ImportTracks.TabIndex = 1;
            this.btn_ImportTracks.Text = "Import Tracks From Directory";
            this.btn_ImportTracks.UseVisualStyleBackColor = true;
            this.btn_ImportTracks.Click += new System.EventHandler(this.btn_ImportTracks_Click);
            // 
            // lst_Imported
            // 
            this.lst_Imported.FormattingEnabled = true;
            this.lst_Imported.HorizontalScrollbar = true;
            this.lst_Imported.Location = new System.Drawing.Point(11, 16);
            this.lst_Imported.Name = "lst_Imported";
            this.lst_Imported.Size = new System.Drawing.Size(237, 264);
            this.lst_Imported.TabIndex = 0;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(492, 408);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(580, 407);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 442);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.panel1);
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Form";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_NextGenre;
        internal System.Windows.Forms.Button btn_DeleteGenre;
        internal System.Windows.Forms.Button btn_AddGenre;
        public System.Windows.Forms.Button btn_PreviousGenre;
        private System.Windows.Forms.ListBox lst_Present_Genre;
        private System.Windows.Forms.TextBox txt_GenreTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteFromGenre;
        private System.Windows.Forms.Button btn_MoveToGenre;
        private System.Windows.Forms.Button btn_CopyToGenre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClearImportedTracks;
        private System.Windows.Forms.Button btn_ImportTracks;
        private System.Windows.Forms.ListBox lst_Imported;
        internal System.Windows.Forms.Button btn_Ok;
        internal System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}