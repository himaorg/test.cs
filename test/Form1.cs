using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// mouse hoverした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleChange_MouseHover(object sender, EventArgs e)
        {
            this.title.Text = "https://himatsubushi.org";
        }
        /// <summary>
        /// mouse leaveした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleChange_MouseLeave(object sender, EventArgs e)
        {
            this.title.Text = "HIMAORG";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
