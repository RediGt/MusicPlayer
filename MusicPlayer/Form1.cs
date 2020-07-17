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

namespace MusicPlayer
{
    public partial class formMusic : Form
    {
        string[] path;
        string[] files;
        
        public formMusic()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                path = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                    listBoxSongs.Items.Add(files[i]);
            }

        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinMediaPlayer.URL = path[listBoxSongs.SelectedIndex];
        }
    }
}
