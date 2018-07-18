using MyDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_JukeBox_2
{
    public partial class SetupForm : Form
    {
        private bool RSave = false;

        private ListBox[] Setup_Media_Library;

        public string StrApplicationMediaPath = Directory.GetCurrentDirectory();

        private int Int_SetupNumberofGenre;

        private int Int_ShowGenreNumber = 1;

        private string Str_CopyTracksTo = string.Concat(Directory.GetCurrentDirectory(), "\\Tracks\\");

        private string Setup_StrApplicationMediaPath = Directory.GetCurrentDirectory();

        private string Str_CopyTracksFrom = "";

        public SetupForm()
        {
            InitializeComponent();
        }

        private void btn_AddGenre_Click(object sender, EventArgs e)
        {
            string i;
            RSave = true;
            for (i = My_Dialogs.InputBox("Please enter the 'Genre Title'."); i == ""; i = My_Dialogs.InputBox("Please enter the 'Genre Title'."))
            {
                MessageBox.Show("You must give the 'Genre' a title!");
            }
            if (i != "")
            {
                Int_SetupNumberofGenre++;
                Int_ShowGenreNumber = Int_SetupNumberofGenre;
                if (Setup_Media_Library != null)
                {
                    Array.Resize<ListBox>(ref Setup_Media_Library, Int_SetupNumberofGenre + 1);
                }
                Setup_Media_Library[Int_SetupNumberofGenre - 1] = new ListBox();
                Setup_Media_Library[Int_SetupNumberofGenre - 1].Items.Add(i);
                AddToGList(Int_ShowGenreNumber);
                btn_NextGenre.Enabled = false;
                btn_PreviousGenre.Enabled = true;
                btn_DeleteGenre.Enabled = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (RSave)
            {
                if (MessageBox.Show(string.Concat("You have made changes to the configuration.", Environment.NewLine, Environment.NewLine, "                   Do you wish to save them?"), "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    btn_Ok_Click(sender, e);
                }
            }
            Close();
        }

        private void btn_ClearImportedTracks_Click(object sender, EventArgs e)
        {
            lst_Imported.Items.Clear();
            Str_CopyTracksTo = "";
        }


        private void btn_CopyToGenre_Click(object sender, EventArgs e)
        {
            RSave = true;
            if (lst_Imported.SelectedIndex == -1)
            {
                MessageBox.Show("You must Select an item to Copy.");
            }
            else
            {
                lst_Present_Genre.Items.Add(lst_Imported.Items[lst_Imported.SelectedIndex]);
                Setup_Media_Library[Int_ShowGenreNumber].Items.Add(lst_Imported.Items[lst_Imported.SelectedIndex]);
                if (!File.Exists(string.Concat(Str_CopyTracksTo, lst_Imported.Items[lst_Imported.SelectedIndex])))

                {
                    //   File.Copy(string.Concat(Str_CopyTracksFrom, lst_Imported.Items[lst_Imported.SelectedIndex]), string.Concat(Str_CopyTracksTo, lst_Imported.Items[lst_Imported.SelectedIndex]));
                    File.Copy(string.Concat(Str_CopyTracksFrom, lst_Imported.Items[lst_Imported.SelectedIndex]), string.Concat(Str_CopyTracksTo, lst_Imported.Items[lst_Imported.SelectedIndex]));
                }
            }
        }

        // Moves selected tracks to specific genres//
        private void btn_MoveToGenre_Click(object sender, EventArgs e)
        {
            // Prompts you to select a track before moving forward// 
            RSave = true;
            if (lst_Imported.SelectedIndex == -1)
            {
                MessageBox.Show("You must Select an item to Move.");
            }
            else
            {
                lst_Present_Genre.Items.Add(lst_Imported.Items[lst_Imported.SelectedIndex]);
                Setup_Media_Library[Int_ShowGenreNumber].Items.Add(lst_Imported.Items[lst_Imported.SelectedIndex]);
                if (!File.Exists(string.Concat(Str_CopyTracksTo, lst_Imported.Items[lst_Imported.SelectedIndex])))
                {
                    //  File.Copy(string.Concat(Str_CopyTracksFrom, lst_Imported.Items[lst_Imported.SelectedIndex]), string.Concat(Str_CopyTracksTo, lst_Imported.Items[lst_Imported.SelectedIndex]));
                    File.Copy(string.Concat(Str_CopyTracksFrom, lst_Imported.Items[lst_Imported.SelectedIndex]), string.Concat(Str_CopyTracksTo, lst_Imported.Items[lst_Imported.SelectedIndex]));
                }
                lst_Imported.Items.RemoveAt(lst_Imported.SelectedIndex);
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (RSave)
            {
                if (!Save_Media_List())
                {
                    MessageBox.Show("Could not Save the new configuration!");
                }
            }
            Close();
        }

        private void AddToGList(int DiscGenre)
        {
            lst_Present_Genre.Items.Clear();
            txt_GenreTitle.Text = Setup_Media_Library[DiscGenre - 1].Items[0].ToString();
            for (int i = 1; i < Setup_Media_Library[DiscGenre - 1].Items.Count; i++)
            {
                lst_Present_Genre.Items.Add(Setup_Media_Library[DiscGenre - 1].Items[i].ToString());
            }
        }

        private void btn_DeleteFromGenre_Click(object sender, EventArgs e)
        {
            RSave = true;
            int selectedIndex = lst_Present_Genre.SelectedIndex;
            if (lst_Present_Genre.SelectedIndex == -1)
            {
                MessageBox.Show("You must Select an item to Delete.");
            }
            else
            {
                if (!IsUsed(lst_Present_Genre.Items[selectedIndex].ToString()))
                {
                    File.Delete(string.Concat(Str_CopyTracksTo, lst_Present_Genre.Items[selectedIndex]));
                }
                lst_Present_Genre.Items.RemoveAt(selectedIndex);
                Setup_Media_Library[Int_ShowGenreNumber].Items.RemoveAt(selectedIndex);
            }
        }
        // DONT FORGET//
        private void btn_DeleteGenre_Click(object sender, EventArgs e)
        {
            int i;
            RSave = true;
            if (MessageBox.Show(string.Concat("Deleting the Genre will remove all of it's tracks from your jukebox.", Environment.NewLine, Environment.NewLine "Do you wish to continue?"), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Int_ShowGenreNumber >= Int_SetupNumberofGenre)
                {
                    Setup_Media_Library[Int_ShowGenreNumber - 1].Items.RemoveAt(0);
                    for (i = 1; i < Setup_Media_Library[Int_ShowGenreNumber - 1].Items.Count - 1; i++)
                    {
                        File.Delete(string.Concat(Str_CopyTracksTo, Setup_Media_Library[Int_ShowGenreNumber - 1].Items[i]));
                    }
                    Setup_Media_Library[Int_ShowGenreNumber - 1].Dispose();
                }
            }
            }
        }

        private void btn_ImportTracks_Click(object sender, EventArgs e)
        {
            RSave = true;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string str in
                    from s in Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.AllDirectories)
                    where (s.EndsWith(".mp3") || s.EndsWith(".wma") || s.EndsWith(".wav") || s.EndsWith(".MP3") || s.EndsWith(".WMA") ? true : s.EndsWith(".WAV"))
                    select s)
                {
                    lst_Imported.Items.Add(str);
                }
                if (lst_Imported.Items.Count <= -1)
                {
                    btn_ImportTracks.Enabled = true;
                }
                else
                {
                    btn_ImportTracks.Enabled = false;
                }
            }
        }

        private void btn_NextGenre_Click(object sender, EventArgs e)
        {
            if (Int_ShowGenreNumber < Int_SetupNumberofGenre)
            {
                btn_PreviousGenre.Enabled = true;
                Int_ShowGenreNumber++;
                AddToGList(Int_ShowGenreNumber);
                if (Int_ShowGenreNumber == Int_SetupNumberofGenre)
                {
                    btn_NextGenre.Enabled = false;
                    if (Int_SetupNumberofGenre > 1)
                    {
                        btn_PreviousGenre.Enabled = true;
                    }
                }
            }
        }

        private void btn_PreviousGenre_Click(object sender, EventArgs e)
        {
            if (Int_ShowGenreNumber > 0)
            {
                btn_NextGenre.Enabled = true;
                Int_ShowGenreNumber--;
                AddToGList(Int_ShowGenreNumber);
                if (Int_ShowGenreNumber == 1)
                {
                    btn_PreviousGenre.Enabled = false;
                    if (Int_SetupNumberofGenre > 0)
                    {
                        btn_NextGenre.Enabled = true;
                    }
                }
            }
        }

        private bool IsUsed(string Track)
        {
            bool trigger;
            int count = 1;
            while (true)
            {
                if (count <= Int_SetupNumberofGenre)
                {
                    int digit1 = 1;
                    while (digit1 <= Setup_Media_Library[count].Items.Count - 1)
                    {
                        if (!(Track == Setup_Media_Library[count].Items[digit1].ToString()))
                        {
                            digit1++;
                        }
                        else
                        {
                            trigger = true;
                            return trigger;
                        }
                    }
                    count++;
                }
                else
                {
                    trigger = false;
                    break;
                }
            }
            return trigger;
        }

        // Initiates default value //
        private void InitiateDValue()
        {
            Int_SetupNumberofGenre = 1;
            if (Int_SetupNumberofGenre > 1)
            {
                Setup_Media_Library = new ListBox[Int_SetupNumberofGenre];
            }
            Setup_Media_Library[1] = new ListBox();
            Setup_Media_Library[1].Items.Add("Genrel");
        }

        // Loads the track files into the Media text files // 
        private bool Load_Media_Lists()
        {
            bool trigger;
            if (!File.Exists(string.Concat(Setup_StrApplicationMediaPath, "\\Media\\Media.txt")))
            {
                trigger = false;
            }
            else
            {
                try
                { // Reads the media textbox containing track information //
                    StreamReader TextFileReader = new StreamReader(string.Concat(Setup_StrApplicationMediaPath, "\\Media\\Media.txt"));
                    try
                    {
                        Int_SetupNumberofGenre = Convert.ToInt32(TextFileReader.ReadLine());
                        Setup_Media_Library = new ListBox[Int_SetupNumberofGenre];
                        for (int i = 0; i < Int_SetupNumberofGenre; i++)
                        {
                            Setup_Media_Library[i] = new ListBox();
                            int num = Convert.ToInt32(TextFileReader.ReadLine());
                            Setup_Media_Library[i].Items.Add(TextFileReader.ReadLine());
                            for (int j = 0; j < num; j++)
                            {
                                string str = TextFileReader.ReadLine();
                                Setup_Media_Library[i].Items.Add(str);
                            }
                        }
                        TextFileReader.Close();
                    }
                    finally
                    {
                        if (TextFileReader != null)
                        {
                            ((IDisposable)TextFileReader).Dispose();
                        }
                    }
                    trigger = true;
                }
                catch (Exception exception)
                {
                    trigger = false;
                }
            }
            return trigger;
        }

        // Saves the track information within media textbox
        private bool Save_Media_List()
        {
            bool trigger;
            StreamWriter TextFileWriter = new StreamWriter(string.Concat(Setup_StrApplicationMediaPath, "\\Media\\Media.txt"));
            try
            {
                TextFileWriter.WriteLine(Int_SetupNumberofGenre);
                for (int i = 0; i < Int_SetupNumberofGenre; i++)
                {
                    TextFileWriter.WriteLine(Setup_Media_Library[i].Items.Count - 1);
                    for (int j = 0; j < Setup_Media_Library[i].Items.Count; j++)
                    {
                        TextFileWriter.WriteLine(Setup_Media_Library[i].Items[j]);
                    }
                }
                TextFileWriter.Close();
                trigger = true;
            }
            finally
            {
                if (TextFileWriter != null)
                {
                    ((IDisposable)TextFileWriter).Dispose();
                }
            }
            return trigger;
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            if (Load_Media_Lists())
            {
                AddToGList(Int_ShowGenreNumber);
                if (Int_SetupNumberofGenre > 0)
                { // Enables buttons when there is more than one genre //
                    btn_NextGenre.Enabled = true;
                    btn_DeleteGenre.Enabled = true;
                }
            }
            else
            {
                InitiateDValue();
                AddToGList(Int_ShowGenreNumber);
            }
        }
    }
}