using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com",
                UseShellExecute = true
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com",
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.Google.com",
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "www.nesine.com/iddaa/futbol?et=1&le=3&ocg=MS-2%2C5&gt=Popüler",
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "x.com/?lang=tr",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "www.tranimeizle.top",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "www.primevideo.com/region/eu/offers/nonprimehomepage/ref=atv_dp_tv_c_9zZ8D2_hom",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "www.fullhdfilmizlesene.de",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
