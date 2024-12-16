using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system.Media;
using System.Windows.Forms;

namespace test
{
    public partial class timer : Form
    {
        private string alarmSoundPath;

        public timer()
        {
            InitializeComponent();
        }

        private void timer_Load(object sender, EventArgs e)
        {

        }

        private void sonudSlect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "音声ファイル (*.wav;*.mp3;*.ogg)|*.wav;*.mp3;*.ogg";
                openFileDialog.Title = "音を選択してください";
            }

            if(OpenFileDialog.showDiarog() == DialogResult.OK)
            {
                alarmSoundPath = openFileDialog.FileName;
                slectedSound.Text = $"選択済み: {alarmSoundPath}";

            }
        }
    }
}
