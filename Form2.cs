using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_WEEK
{
    public partial class Form2 : Form
    {
        int aa = 0;
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aa == 0)
            {
                label1.Text = "DLL ler ayarlanıyor";
                aa++;
                timer1.Interval = 500;
            }
            else if (aa == 1)
            {
                label1.Text = "Temalar Uygulanıyor";
                aa++;
                timer1.Interval = 400;
            }
            else if (aa == 2)
            {
                label1.Text = "Seçenekler Uygulanıyor";
                aa++;
                timer1.Interval = 300;
            }
            else if (aa == 3)
            {
                label1.Text = "Son Ayarlamalar Yapılıyor";
                aa++;
                timer1.Interval = 200;
            }
            else if (aa == 4)
            {
                label1.Text = "Kayıtlar İşleniyor";
                aa++;
                timer1.Interval = 100;
            }
            else if (aa == 5)
            {
                Form3 frm2 = new Form3();
                frm2.Show();
                this.Hide();
                timer1.Stop();

            }
        }
    }
}
