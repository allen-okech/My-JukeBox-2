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
            this.btn_Next_Genre = new System.Windows.Forms.Button();
            this.btn_Delete_Genre = new System.Windows.Forms.Button();
            this.btn_Add_Genre = new System.Windows.Forms.Button();
            this.btn_Previous_Genre = new System.Windows.Forms.Button();
            this.lst_Present_Genre = new System.Windows.Forms.ListBox();
            this.txt_Genre_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete_From_Genre = new System.Windows.Forms.Button();
            this.btn_Move_To_Genre = new System.Windows.Forms.Button();
            this.btn_Copy_To_Genre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Clear_Imported_Tracks = new System.Windows.Forms.Button();
            this.btn_Import_Tracks = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btn_Delete_From_Genre);
            this.panel1.Controls.Add(this.btn_Move_To_Genre);
            this.panel1.Controls.Add(this.btn_Copy_To_Genre);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 392);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Next_Genre);
            this.groupBox2.Controls.Add(this.btn_Delete_Genre);
            this.groupBox2.Controls.Add(this.btn_Add_Genre);
            this.groupBox2.Controls.Add(this.btn_Previous_Genre);
            this.groupBox2.Controls.Add(this.lst_Present_Genre);
            this.groupBox2.Controls.Add(this.txt_Genre_Title);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(389, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 364);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genre";
            // 
            // btn_Next_Genre
            // 
            this.btn_Next_Genre.Enabled = false;
            this.btn_Next_Genre.Location = new System.Drawing.Point(162, 288);
            this.btn_Next_Genre.Name = "btn_Next_Genre";
            this.btn_Next_Genre.Size = new System.Drawing.Size(75, 55);
            this.btn_Next_Genre.TabIndex = 7;
            this.btn_Next_Genre.Text = "Next >>";
            this.btn_Next_Genre.UseVisualStyleBackColor = true;
            // 
            // btn_Delete_Genre
            // 
            this.btn_Delete_Genre.Enabled = false;
            this.btn_Delete_Genre.Location = new System.Drawing.Point(90, 320);
            this.btn_Delete_Genre.Name = "btn_Delete_Genre";
            this.btn_Delete_Genre.Size = new System.Drawing.Size(58, 23);
            this.btn_Delete_Genre.TabIndex = 6;
            this.btn_Delete_Genre.Text = "Delete";
            this.btn_Delete_Genre.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Genre
            // 
            this.btn_Add_Genre.Location = new System.Drawing.Point(90, 288);
            this.btn_Add_Genre.Name = "btn_Add_Genre";
            this.btn_Add_Genre.Size = new System.Drawing.Size(58, 23);
            this.btn_Add_Genre.TabIndex = 8;
            this.btn_Add_Genre.Text = "Add";
            this.btn_Add_Genre.UseVisualStyleBackColor = true;
            // 
            // btn_Previous_Genre
            // 
            this.btn_Previous_Genre.Enabled = false;
            this.btn_Previous_Genre.Location = new System.Drawing.Point(6, 288);
            this.btn_Previous_Genre.Name = "btn_Previous_Genre";
            this.btn_Previous_Genre.Size = new System.Drawing.Size(75, 55);
            this.btn_Previous_Genre.TabIndex = 5;
            this.btn_Previous_Genre.Text = "<< Previous";
            this.btn_Previous_Genre.UseVisualStyleBackColor = true;
            // 
            // lst_Present_Genre
            // 
            this.lst_Present_Genre.FormattingEnabled = true;
            this.lst_Present_Genre.Location = new System.Drawing.Point(23, 65);
            this.lst_Present_Genre.Name = "lst_Present_Genre";
            this.lst_Present_Genre.Size = new System.Drawing.Size(192, 186);
            this.lst_Present_Genre.TabIndex = 2;
            // 
            // txt_Genre_Title
            // 
            this.txt_Genre_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Genre_Title.Enabled = false;
            this.txt_Genre_Title.Location = new System.Drawing.Point(23, 39);
            this.txt_Genre_Title.Name = "txt_Genre_Title";
            this.txt_Genre_Title.Size = new System.Drawing.Size(193, 20);
            this.txt_Genre_Title.TabIndex = 1;
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
            // btn_Delete_From_Genre
            // 
            this.btn_Delete_From_Genre.Location = new System.Drawing.Point(274, 230);
            this.btn_Delete_From_Genre.Name = "btn_Delete_From_Genre";
            this.btn_Delete_From_Genre.Size = new System.Drawing.Size(109, 72);
            this.btn_Delete_From_Genre.TabIndex = 3;
            this.btn_Delete_From_Genre.Text = "Delete Track From Genre";
            this.btn_Delete_From_Genre.UseVisualStyleBackColor = true;
            // 
            // btn_Move_To_Genre
            // 
            this.btn_Move_To_Genre.Location = new System.Drawing.Point(274, 128);
            this.btn_Move_To_Genre.Name = "btn_Move_To_Genre";
            this.btn_Move_To_Genre.Size = new System.Drawing.Size(109, 23);
            this.btn_Move_To_Genre.TabIndex = 2;
            this.btn_Move_To_Genre.Text = "Move Track >>";
            this.btn_Move_To_Genre.UseVisualStyleBackColor = true;
            // 
            // btn_Copy_To_Genre
            // 
            this.btn_Copy_To_Genre.Location = new System.Drawing.Point(274, 93);
            this.btn_Copy_To_Genre.Name = "btn_Copy_To_Genre";
            this.btn_Copy_To_Genre.Size = new System.Drawing.Size(109, 23);
            this.btn_Copy_To_Genre.TabIndex = 1;
            this.btn_Copy_To_Genre.Text = "Copy Track >>";
            this.btn_Copy_To_Genre.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Clear_Imported_Tracks);
            this.groupBox1.Controls.Add(this.btn_Import_Tracks);
            this.groupBox1.Controls.Add(this.lst_Imported);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Tracks";
            // 
            // btn_Clear_Imported_Tracks
            // 
            this.btn_Clear_Imported_Tracks.Location = new System.Drawing.Point(9, 326);
            this.btn_Clear_Imported_Tracks.Name = "btn_Clear_Imported_Tracks";
            this.btn_Clear_Imported_Tracks.Size = new System.Drawing.Size(237, 34);
            this.btn_Clear_Imported_Tracks.TabIndex = 2;
            this.btn_Clear_Imported_Tracks.Text = "Clear Imported Tracks";
            this.btn_Clear_Imported_Tracks.UseVisualStyleBackColor = true;
            // 
            // btn_Import_Tracks
            // 
            this.btn_Import_Tracks.Location = new System.Drawing.Point(9, 290);
            this.btn_Import_Tracks.Name = "btn_Import_Tracks";
            this.btn_Import_Tracks.Size = new System.Drawing.Size(237, 30);
            this.btn_Import_Tracks.TabIndex = 1;
            this.btn_Import_Tracks.Text = "Import Tracks From Directory";
            this.btn_Import_Tracks.UseVisualStyleBackColor = true;
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
            this.btn_Ok.Location = new System.Drawing.Point(474, 407);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(570, 407);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
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
            this.Text = "Setup";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_Next_Genre;
        internal System.Windows.Forms.Button btn_Delete_Genre;
        internal System.Windows.Forms.Button btn_Add_Genre;
        public System.Windows.Forms.Button btn_Previous_Genre;
        private System.Windows.Forms.ListBox lst_Present_Genre;
        private System.Windows.Forms.TextBox txt_Genre_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete_From_Genre;
        private System.Windows.Forms.Button btn_Move_To_Genre;
        private System.Windows.Forms.Button btn_Copy_To_Genre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Clear_Imported_Tracks;
        private System.Windows.Forms.Button btn_Import_Tracks;
        private System.Windows.Forms.ListBox lst_Imported;
        internal System.Windows.Forms.Button btn_Ok;
        internal System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}