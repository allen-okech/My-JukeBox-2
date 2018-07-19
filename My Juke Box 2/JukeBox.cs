using AxWMPLib;
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
using WMPLib;

namespace My_JukeBox_2
{
    public partial class JukeBox : Form
    {
        public string StrApplicationMediaPath = Directory.GetCurrentDirectory();

        public int Int_NumberofGenre;

        private ListBox[] Media_Library;

        private bool IsPlaying = false;

        public HScrollBar hScrollbar_Genre;

        public JukeBox()
        {
            InitializeComponent();
        }

        // Show About dialog
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }

        private void hScrollBar_Genre_ValueChanged(object sender, EventArgs e)
        {
            txt_Genre_Title.Text = Media_Library[hScrollBar_Genre.Value - 1].Items[0].ToString();
            AddToGList(hScrollBar_Genre.Value - 1);
        }

        private bool Initialise()
        {
            hScrollBar_Genre.Minimum = 1;
            hScrollBar_Genre.SmallChange = 1;
            hScrollBar_Genre.Maximum = Int_NumberofGenre;
            hScrollBar_Genre.Value = hScrollBar_Genre.Minimum;
            AddToGList(hScrollBar_Genre.Value - 1);
            return true;
        }

        // Checks if the file is possible to play
        private bool PossibleToPlay()
        {
            bool trigger;
            trigger = (lst_Playlist.Items.Count <= 0 ? false : true);
            return trigger;
        }

        // Messages when files fail to load
        private void JukeBox_Shown(object sender, EventArgs e)
        {
            if (!Load_Media_Lists())
            {
                MessageBox.Show("Unable to load the 'Media Content'.");
                InitiateDValue();
            }
            if (!Initialise())
            {
                MessageBox.Show("Unable to display the 'Media Content'.");
                Close();
            }
        }

        // Loads music file and plays it
        private void FileLoadAndPlay()
        {
            if ((!PossibleToPlay() ? false : !IsPlaying))
            {
                txt_Playing.Text = lst_Playlist.Items[0].ToString();
                lst_Playlist.Items.Remove(lst_Playlist.Items[0]);
                MediaPlayer.URL = string.Concat(StrApplicationMediaPath, "\\Tracks\\", txt_Playing.Text);
                IsPlaying = true;
                MediaPlayer.Ctlcontrols.play();
            }
        }
        
        // Initializes default values 
        private void InitiateDValue()
        {
            Int_NumberofGenre = 1;
            if (Int_NumberofGenre > 1)
            {
                Media_Library = new ListBox[Int_NumberofGenre];
            }
            Media_Library[1] = new ListBox();
            Media_Library[1].Items.Add("Genrel");
        }

        private bool Load_Media_Lists()
        {
            bool trigger;
            if (!File.Exists(string.Concat(StrApplicationMediaPath, "\\Media\\Media.txt")))
            {
                trigger = false;
            }
            else
            {
                try
                {
                    StreamReader TextFileReader = new StreamReader(string.Concat(StrApplicationMediaPath, "\\Media\\Media.txt"));
                    try
                    {
                        Int_NumberofGenre = Convert.ToInt32(TextFileReader.ReadLine());
                        Media_Library = new ListBox[Int_NumberofGenre];
                        for (int i = 0; i < Int_NumberofGenre; i++)
                        {
                            Media_Library[i] = new ListBox();
                            int num = Convert.ToInt32(TextFileReader.ReadLine());
                            Media_Library[i].Items.Add(TextFileReader.ReadLine());
                            for (int j = 0; j < num; j++)
                            {
                                string str = TextFileReader.ReadLine();
                                Media_Library[i].Items.Add(str);
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

        // When double clicked it will add to playlist
        private void lst_Genre_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Genre.Items.Count > -1)
            {// If condition check if music is playing, if returms false it loads file and plays music
                lst_Playlist.Items.Add(lst_Genre.Items[lst_Genre.SelectedIndex]);
                if (!IsPlaying)
                {
                    FileLoadAndPlay();
                }
            }

        }
        
        // Changes state of the media player
        private void MediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent call)
        {
            if (call.newState == 1)
            {
                IsPlaying = false;
                timer.Enabled = true;
            }
        }
       
        // Adds to genre list
        private void AddToGList(int DiscGenre)
        {
            lst_Genre.Items.Clear();
            txt_Genre_Title.Text = Media_Library[DiscGenre].Items[0].ToString();
            for (int i = 1; i <= Media_Library[DiscGenre].Items.Count - 1; i++)
            {
                lst_Genre.Items.Add(Media_Library[DiscGenre].Items[i].ToString());
            }
        }

        // Opens Setup Form
        

        // 3 second interval between tracks
        private void timer_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                IsPlaying = true;
            }
            else if (MediaPlayer.playState == WMPPlayState.wmppsStopped)
            {
                timer.Enabled = false;
                FileLoadAndPlay();
            }
        }

        private void setupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new SetupForm()).ShowDialog();
        }
    }
            }
