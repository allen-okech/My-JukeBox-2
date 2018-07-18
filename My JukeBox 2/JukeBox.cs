using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
