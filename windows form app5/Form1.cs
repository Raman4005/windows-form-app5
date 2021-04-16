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

namespace windows_form_app5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrannum_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 100);

            lblRanNum.Text = "Random Num " + num;

            Console.WriteLine("Random number generated " + num);
        }

        private void btnimage_Click(object sender, EventArgs e)
        { 
            Random ran = new Random();
        int num = ran.Next(1, 10);

            if (num % 2 == 0)
            {
                pbImage.Image = global::windows_form_app5.Properties.Resources.aasesment_7_images;
            }
            else
            {

                pbImage.Image = global::windows_form_app5.Properties.Resources.step_4_;

        }
        }

        private void btnsound_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(windows_form_app5.Properties.Resources.Warning_Siren_SoundBible_com_898272278);
            player.Load();
            player.Play();
         


        }
    }
}
