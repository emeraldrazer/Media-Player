using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace SimpleMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Multiselect=true, ValidateNames= true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> mediaFiles = new List<MediaFile>();
                    foreach (string file in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(file);
                        mediaFiles.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path=fi.FullName });
                    }

                    listFile.DataSource = mediaFiles;
                }
            }
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listFile.SelectedItem as MediaFile;

            if(file != null)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "Filename";
        }
    }
}
