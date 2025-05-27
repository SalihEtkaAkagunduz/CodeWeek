using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Code_WEEK
{
    public partial class Form3 : Form
    {


        bool exist1;
        public Form3()
        {

            string exist1_1 = @"C:\ProgramData\SEAPP\" + mevcut + @"\Kayıt.txt";
            exist1 = File.Exists(exist1_1);


            InitializeComponent();

            pictureBox18.Hide();
            tabControl1.Hide();

            pictureBox48.Hide();


            timer1.Interval = 1;
            tabControl1.SelectedTab = tabPage2;
            timer1.Start();
            pictureBox2.Hide();
            pictureBox3.Hide();
            groupBox1.Hide();
            button1.Hide();
            pictureBox6.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            linkLabel1.Hide();

            textBox1.Hide();
            checkBox1.Hide();
            richTextBox1.Hide();
            numericUpDown1.Hide();
            button3.Hide();
            label6.Hide();
            comboBox2.Hide();
            button2.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox5.Hide();
            pictureBox4.Hide();

        }
        public string mevcut = File.ReadAllText(@"C:\ProgramData\SEAPP\mevcut.txt");



        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int ilk = 0;
        int iki = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {

            Point ddd = new Point(618, 266);
            Point ddd3 = new Point(619, 266);
            Point ddd2 = new Point(530, 345);
            if (label1.Location == ddd || label1.Location == ddd3)
            {
                ilk = 1;
            }
            else
            {
                label1.Left += 2;
            }
            if (label2.Location == ddd2)
            {
                iki = 1;
            }
            else
            {
                label2.Left += -2;
            }
            if (ilk == 1 && iki == 1)
            {

                timer2.Interval = 1;
                timer2.Start();
                timer1.Stop();
            }

        }
        int ilk2 = 0;
        int iki2 = 0;
        int y2 = 266;
        int y1 = 345;
        int y3 = -270;
        int yyy = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (yyy == 0)
            {
                timer3.Start();
                yyy += 1;
                timer3.Interval = 1;
            }
            Point ddd = new Point(618, 483);//label2
            Point ddd3 = new Point(619, 543);//label2
            Point ddd2 = new Point(530, 617);//label1
            if (label2.Location == ddd2)
            {
                iki2 = 1;
            }
            else
            {
                y1 = y1 + 1;
                label2.Location = new Point(530, y1);
            }
            if (label1.Location == ddd || label1.Location == ddd3)
            {
                ilk2 = 1;
            }
            else
            {
                y2 = y2 + 1;
                label1.Location = new Point(619, y2);
            }
            if (ilk2 == 1 && iki2 == 1)
            {

                timer2.Stop();
                timer1.Stop();


            }


        }
        int bghj = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            Point ddd2 = new Point(552, 27);//label1
            if (pictureBox1.Location == ddd2)
            {
                bghj = 1;
            }
            else
            {
                y3 = y3 + 1;
                pictureBox1.Location = new Point(552, y3);
            }
            if (bghj == 1)
            {

                timer2.Stop();
                timer1.Stop();
                timer3.Interval = 1;
                timer3.Stop();
                pictureBox2.Show();
                pictureBox3.Show();
                button2.Show();
                pictureBox6.Show();
                pictureBox5.Show();
                pictureBox4.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (exist1)
            {
                string kayıtiçisorgu = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Kayıt.txt");
                if (kayıtiçisorgu == "1")
                {
                    string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
                    if (dil == "English")
                    {
                        MessageBox.Show("You can choose the \"Turkish\" language for this application to improve the user experience", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }


                    pictureBox2.Hide();
                    pictureBox1.Hide();
                    pictureBox3.Hide();
                    groupBox1.Show();
                    button1.Hide();

                    pictureBox48.Show();


                    pictureBox6.Hide();
                    label8.Hide();
                    label9.Hide();
                    label10.Hide();
                    label2.Hide();
                    label3.Hide();
                    label7.Hide();

                    label11.Hide();
                    label1.Hide();
                    tabControl1.Show();
                    linkLabel1.Hide();
                    textBox1.Hide();
                    checkBox1.Hide();
                    richTextBox1.Hide();
                    numericUpDown1.Hide();
                    button3.Hide();
                    label6.Hide();
                    comboBox2.Hide();
                    button2.Hide();


                    pictureBox16.Hide();


                    pictureBox15.Hide();
                    pictureBox4.Hide();

                    if (dil == "Türkçe")
                    {
                        button71.Text = "Türk-İslam\nMatematik Tarihi\nAlıştırmaları";
                        button70.Text = "Dünya\nMatematik Tarihi\nAlıştırmaları";
                        button68.Text = "Matematiksel işlem \nAlıştırmaları";
                        button16.Text = "Türk\nMatematik Tarihi";
                        button17.Text = "İslam\nMatematik Tarihi";
                        button18.Text = "Dünya\nMatematik Tarihi";
                        button47.Text = "Matematiksel \nİşlemler";
                        pictureBox18.Image = Properties.Resources.öğren_removebg_preview;
                        pictureBox18.Show();
                        pictureBox19.Image = Properties.Resources.Egzersiz;
                        pictureBox19.Show();
                        pictureBox42.Image = Properties.Resources.Diğer;
                        pictureBox42.Show();
                        pictureBox44.Image = Properties.Resources.Ayarlar;
                        pictureBox44.Show();
                        pictureBox44.Image = Properties.Resources.H_akkında;
                        pictureBox44.Show();
                        button21.Text = "1.Seviye Egzersiz";
                        button20.Text = "2.seviye Egzersiz";
                        button22.Text = "3.Seviye Egzersiz";
                        button37.Text = "1.Seviye Egzersiz";
                        button30.Text = "2.seviye Egzersiz";
                        button29.Text = "3.Seviye Egzersiz";
                        button46.Text = "1.Seviye Egzersiz";
                        button39.Text = "2.seviye Egzersiz";
                        button38.Text = "3.Seviye Egzersiz";
                    }
                    if (dil == "English")
                    {
                        button71.Text = "Turkish-Islamic\n History of Mathematics\n Exercises";
                        button70.Text = "Math Exercises\n for world history";
                        button68.Text = "Mathematical\n operation exercises";
                        button47.Text = "Mathematical \nOperation";
                        label12.Text = "Unfortunately, this page is not yet available for the version of the \"SEA Learning\" product -1.27.13- or \r\nit has not been made available yet. Please continue with the sections available in your region\r\n work if you think there is a problem, you can contact us \r\n                                                                                                                                          -SEAAPP-";
                        button46.Text = "Turkish-Islamic E.";
                        button39.Text = "World E.";
                        button38.Text = "Mathematic E.";
                        button37.Text = "Turkish-Islamic E.";
                        button30.Text = "World E.";
                        button29.Text = "Mathematic E.";
                        button21.Text = "Turkish-Islamic E.";
                        button20.Text = "World E.";
                        button22.Text = "Mathematic E.";
                        button16.Text = "Turkish \n Mathematical History";
                        button17.Text = "Islamic \nMathematical History";
                        button18.Text = "mathematical\nHistory of the World";
                        pictureBox18.Image = Properties.Resources.Learn_removebg_preview;
                        pictureBox18.Show();
                        pictureBox19.Image = Properties.Resources.excersize2;
                        pictureBox19.Show();
                        pictureBox42.Image = Properties.Resources.Other2;
                        pictureBox42.Show();
                        pictureBox44.Image = Properties.Resources.Settings;
                        pictureBox44.Show();
                        pictureBox45.Image = Properties.Resources.About;
                        pictureBox45.Show();
                    }
                }
                else
                {
                    groupBox1.Show();
                    pictureBox1.Hide();
                    label2.Hide();
                    label1.Hide();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    button1.Hide();
                    button2.Hide();
                    FileStream flstm = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\Kayıt.txt");
                    flstm.Close();

                    FileStream flstm2 = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
                    flstm2.Close();
                    groupBox1.Show();
                    comboBox1.Text = "Please Select a Language";
                    comboBox2.Text = "Please Select a Language";

                    //Burada kaldım
                }
            }
            else
            {
                groupBox1.Show();
                pictureBox1.Hide();
                label2.Hide();
                label1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                button1.Hide();
                button2.Hide();
                FileStream flstm = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\Kayıt.txt");
                flstm.Close();

                FileStream flstm2 = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
                flstm2.Close();
                groupBox1.Show();
                comboBox1.Text = "Please Select a Language";
                comboBox2.Text = "Please Select a Language";

                //Burada kaldım
            }
        }
        void Kayıtolunmamış()
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Show();
            label9.Show();
            textBox1.Show();
            checkBox1.Show();
            label10.Show();
            label11.Show();
            linkLabel1.Show();
            richTextBox1.Show();
            numericUpDown1.Show();
            button3.Show();

            pictureBox15.Show();
            pictureBox16.Show();
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "English")
            {
                label7.Text = "Final Checks";
                label8.Text = "Please Enter the Name You Want to Use(We will address you like this)";
                label9.Text = "Tell Us How Many Days You Will Be Online";
                label10.Text = "Usage Agreement:";
                richTextBox1.Text = "----------------------------------------------------------------------------------SEAAPP---------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n1-->This program has been prepared within the scope of the Code Week event and it is forbidden to use it consciously or unconsciously without obtaining the necessary permissions, unless otherwise stated.\r\n----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n2-->This program was produced by Salih Etka Akagündüz APP (SEAAPP) and all rights belong to it\r\n----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n3-->In case of an error in the program, the specified problem should be reported from the given gsm instead of investigating the source code of the applications in order to avoid more damage.\r\n----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n4-->It is normal that there are certain errors in the operation of the program and it is the user's duty not to tamper with them too much\r\n\r\n\r\n----------------------------------------------------------------------------------SEAAPP---------------------------------------------------------------------------------------------------------------";
                checkBox1.Text = "I have read the ";
                linkLabel1.Text = "User Agreement";
                label11.Text = " mentioned above and I accept all the terms stated";
                button3.Text = "Finish";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "Türkçe")
            {
                label3.Text = "Merhaba" + mevcut;
                label4.Text = "Öğrenmeye hazır mısın? Hadi o zaman başlayalım.";
                label5.Text = "Lütfen mevcut dilinizi seçin";
                label6.Text = "Lütfen bu kısmı \"English\" olaak seçin";
                comboBox1.Text = "Lütfen bir dil seçiniz";
                comboBox2.Text = "Lütfen bir dil seçiniz";
                label6.Show();

                comboBox2.Show();
                FileStream flstm = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
                flstm.Close();
                File.WriteAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt", "Türkçe");
                comboBox1.Enabled = false;

            }
            else if (comboBox1.SelectedItem == "English")
            {
                File.WriteAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt", "English");
                label6.Show();
                comboBox2.Show();
                comboBox1.Enabled = false;
            }
            else if (comboBox1.SelectedItem == "Lütfen bir dil seçiniz" || comboBox1.SelectedItem == "Please Select a Language")
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream flstm = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\Learn.txt");
            flstm.Close();

            if (comboBox2.SelectedItem == "English")
            {
                button1.Show();
                File.WriteAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Learn.txt", "English");
                label6.Show();
                comboBox2.Show();
                comboBox2.Enabled = false;
                button1.Show();
            }
            else if (comboBox1.SelectedItem == "Lütfen bir dil seçiniz" || comboBox1.SelectedItem == "Please Select a Language")
            {

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "English")
            {
                string ExeDosyaYolu = Application.StartupPath.ToString();
                string ExeDosyaYolu2 = ExeDosyaYolu.Remove(ExeDosyaYolu.Length - 35, 35) + "Kayıt\\WindowsFormsApp5\\bin\\Debug\\English---------.txt";
                string hjkl = ExeDosyaYolu2;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "notepad.exe";
                startInfo.Arguments = ExeDosyaYolu2;
                Process.Start(startInfo);

            }
            else
            {
                string ExeDosyaYolu = Application.StartupPath.ToString();
                string ExeDosyaYolu2 = ExeDosyaYolu.Remove(ExeDosyaYolu.Length - 35, 35) + "Kayıt\\WindowsFormsApp5\\bin\\Debug\\Türkçe----------.txt";
                string hjkl = ExeDosyaYolu2;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "notepad.exe";
                startInfo.Arguments = ExeDosyaYolu2;
                Process.Start(startInfo);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {


            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (string.IsNullOrEmpty(textBox1.Text))
            {


                if (dil == "Türkçe")
                {
                    MessageBox.Show("Lütfen adınızı doldurunuz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dil == "English")
                {
                    MessageBox.Show("Please fill in your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (numericUpDown1.Value == 0)
            {


                if (dil == "Türkçe")
                {
                    MessageBox.Show("Lütfen kaç günde bir aktif olcağınızı girin (En az 1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dil == "English")
                {
                    MessageBox.Show("Please enter how many days you will be active (At least 1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBox1.Checked == false)
            {


                if (dil == "Türkçe")
                {
                    MessageBox.Show("Lütfen Kullanıcı sözleşmesini kabul edin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dil == "English")
                {
                    MessageBox.Show("Please accept the User agreement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                FileStream flstm = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\AktifGün.txt");
                flstm.Close();
                File.WriteAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\AktifGün.txt", numericUpDown1.Value.ToString());
                FileStream flstm2 = File.Create(@"C:\ProgramData\SEAPP\" + mevcut + @"\KullanılacakAd.txt");
                flstm2.Close();
                File.WriteAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\KullanılacakAd.txt", textBox1.Text);

                File.WriteAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Kayıt.txt", "1");

                pictureBox2.Hide();
                pictureBox1.Hide();
                pictureBox3.Hide();
                groupBox1.Show();
                button1.Hide();

                pictureBox48.Show();


                pictureBox6.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label2.Hide();
                label3.Hide();
                label7.Hide();

                label11.Hide();
                label1.Hide();
                tabControl1.Show();
                linkLabel1.Hide();
                textBox1.Hide();
                checkBox1.Hide();
                richTextBox1.Hide();
                numericUpDown1.Hide();
                button3.Hide();
                label6.Hide();
                comboBox2.Hide();
                button2.Hide();


                pictureBox16.Hide();


                pictureBox15.Hide();
                pictureBox4.Hide();

                if (dil == "Türkçe")
                {
                    button71.Text = "Türk-İslam\nMatematik Tarihi\nAlıştırmaları";
                    button70.Text = "Dünya\nMatematik Tarihi\nAlıştırmaları";
                    button68.Text = "Matematiksel işlem \nAlıştırmaları";
                    button16.Text = "Türk\nMatematik Tarihi";
                    button17.Text = "İslam\nMatematik Tarihi";
                    button18.Text = "Dünya\nMatematik Tarihi";
                    button47.Text = "Matematiksel \nİşlemler";
                    pictureBox18.Image = Properties.Resources.öğren_removebg_preview;
                    pictureBox18.Show();
                    pictureBox19.Image = Properties.Resources.Egzersiz;
                    pictureBox19.Show();
                    pictureBox42.Image = Properties.Resources.Diğer;
                    pictureBox42.Show();
                    pictureBox44.Image = Properties.Resources.Ayarlar;
                    pictureBox44.Show();
                    pictureBox44.Image = Properties.Resources.H_akkında;
                    pictureBox44.Show();
                    button21.Text = "1.Seviye Egzersiz";
                    button20.Text = "2.seviye Egzersiz";
                    button22.Text = "3.Seviye Egzersiz";
                    button37.Text = "1.Seviye Egzersiz";
                    button30.Text = "2.seviye Egzersiz";
                    button29.Text = "3.Seviye Egzersiz";
                    button46.Text = "1.Seviye Egzersiz";
                    button39.Text = "2.seviye Egzersiz";
                    button38.Text = "3.Seviye Egzersiz";
                }
                if (dil == "English")
                {
                    button71.Text = "Turkish-Islamic\n History of Mathematics\n Exercises";
                    button70.Text = "Math Exercises\n for world history";
                    button68.Text = "Mathematical\n operation exercises";
                    button47.Text = "Mathematical \nOperation";
                    label12.Text = "Unfortunately, this page is not yet available for the version of the \"SEA Learning\" product -1.27.13- or \r\nit has not been made available yet. Please continue with the sections available in your region\r\n work if you think there is a problem, you can contact us \r\n                                                                                                                                          -SEAAPP-";
                    button46.Text = "Turkish-Islamic E.";
                    button39.Text = "World E.";
                    button38.Text = "Mathematic E.";
                    button37.Text = "Turkish-Islamic E.";
                    button30.Text = "World E.";
                    button29.Text = "Mathematic E.";
                    button21.Text = "Turkish-Islamic E.";
                    button20.Text = "World E.";
                    button22.Text = "Mathematic E.";
                    button16.Text = "Turkish \n Mathematical History";
                    button17.Text = "Islamic \nMathematical History";
                    button18.Text = "mathematical\nHistory of the World";
                    pictureBox18.Image = Properties.Resources.Learn_removebg_preview;
                    pictureBox18.Show();
                    pictureBox19.Image = Properties.Resources.excersize2;
                    pictureBox19.Show();
                    pictureBox42.Image = Properties.Resources.Other2;
                    pictureBox42.Show();
                    pictureBox44.Image = Properties.Resources.Settings;
                    pictureBox44.Show();
                    pictureBox45.Image = Properties.Resources.About;
                    pictureBox45.Show();
                }
            }
        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox18.Image = Properties.Resources.öğrenx_removebg_preview;


            }
            if (dil == "English")
            {
                pictureBox18.Image = Properties.Resources.learnx_removebg_preview;


            }
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox18.Image = Properties.Resources.öğren_removebg_preview;


            }
            if (dil == "English")
            {
                pictureBox18.Image = Properties.Resources.Learn_removebg_preview;


            }


        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox19.Image = Properties.Resources.Egzersizx;


            }
            if (dil == "English")
            {
                pictureBox19.Image = Properties.Resources.Exercisex;


            }
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox19.Image = Properties.Resources.Egzersiz;


            }
            if (dil == "English")
            {
                pictureBox19.Image = Properties.Resources.excersize2;


            }
        }

        private void pictureBox42_MouseEnter(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox42.Image = Properties.Resources.Diğerx;


            }
            if (dil == "English")
            {
                pictureBox42.Image = Properties.Resources.Otherx;


            }
        }

        private void pictureBox42_MouseLeave(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox42.Image = Properties.Resources.Diğer;


            }
            if (dil == "English")
            {
                pictureBox42.Image = Properties.Resources.Other2;


            }
        }

        private void pictureBox44_MouseEnter(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox44.Image = Properties.Resources.Ayalarx;


            }
            if (dil == "English")
            {
                pictureBox44.Image = Properties.Resources.Settingsx;


            }
        }

        private void pictureBox44_MouseLeave(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox44.Image = Properties.Resources.Ayarlar;


            }
            if (dil == "English")
            {
                pictureBox44.Image = Properties.Resources.Settings;


            }
        }


        private void pictureBox45_MouseEnter(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox45.Image = Properties.Resources.Hakkındax;


            }
            if (dil == "English")
            {
                pictureBox45.Image = Properties.Resources.Aboutx;


            }
        }

        private void pictureBox45_MouseLeave(object sender, EventArgs e)
        {
            string dil = File.ReadAllText(@"C:\ProgramData\SEAPP\" + mevcut + @"\Dil.txt");
            if (dil == "Türkçe")
            {
                pictureBox45.Image = Properties.Resources.H_akkında;


            }
            if (dil == "English")
            {
                pictureBox45.Image = Properties.Resources.About;


            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;

        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage45;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button16_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void pictureBox45_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage44;
        }

        private void button70_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            pictureBox60.Visible = true;

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            pictureBox62.Visible = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            pictureBox61.Visible = true;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            pictureBox63.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            pictureBox64.Visible = true;
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            pictureBox65.Visible = true;

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            pictureBox66.Visible = true;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            pictureBox67.Visible = true;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void tabPage36_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage40;
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage41;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage42;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage39;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage39;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            pictureBox75.Visible = true;
            tabControl1.SelectedTab = tabPage19;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            pictureBox74.Visible = true;
            tabControl1.SelectedTab = tabPage20;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            pictureBox72.Visible = true;
            tabControl1.SelectedTab = tabPage3;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            pictureBox70.Visible = true;
            tabControl1.SelectedTab = tabPage22;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            pictureBox68.Visible = true;
            tabControl1.SelectedTab = tabPage26;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            pictureBox69.Visible = true;
            tabControl1.SelectedTab = tabPage25;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            pictureBox71.Visible = true;
            tabControl1.SelectedTab = tabPage24;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            pictureBox73.Visible = true;
            tabControl1.SelectedTab = tabPage23;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            pictureBox83.Visible = true;
            tabControl1.SelectedTab = tabPage27;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            pictureBox82.Visible = true;
            tabControl1.SelectedTab = tabPage28;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            pictureBox80.Visible = true;
            tabControl1.SelectedTab = tabPage19;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            pictureBox78.Visible = true;
            tabControl1.SelectedTab = tabPage29;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            pictureBox81.Visible = true;
            tabControl1.SelectedTab = tabPage33;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            pictureBox79.Visible = true;
            tabControl1.SelectedTab = tabPage32;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            pictureBox77.Visible = true;
            tabControl1.SelectedTab = tabPage31;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            pictureBox76.Visible = true;
            tabControl1.SelectedTab = tabPage30;
        }

        int dmt()
        {
            int doğru1 = 0;

            if (comboBox32.Text == "Pascall")
            {
                doğru1 += 1;

            }

            if (comboBox30.Text == "Descartes")
            {
                doğru1 += 1;

            }
            if (comboBox28.Text == "Descartes")
            {
                doğru1 += 1;

            }
            if (comboBox26.Text == "Arşimet")
            {
                doğru1 += 1;

            }
            if (comboBox24.Text == "Pisagor")
            {
                doğru1 += 1;

            }
            if (comboBox31.Text == "Öklid")
            {
                doğru1 += 1;

            }
            if (comboBox29.Text == "Öklid")
            {
                doğru1 += 1;

            }
            if (comboBox27.Text == "Pisagor")
            {
                doğru1 += 1;

            }
            if (comboBox25.Text == "Thales")
            {
                doğru1 += 1;

            }
            if (comboBox23.Text == "Thales")
            {
                doğru1 += 1;

            }
            return doğru1;
        }
        private void button97_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int dmt1 = dmt();
            if (dmt1 >= 7)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox98.Image = Properties.Resources._3yıldız;
            }
            else if (dmt1 >= 5)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox98.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox98.Image = Properties.Resources._1yıldız;
            }
            comboBox32.Text = " ";
            comboBox30.Text = " ";
            comboBox28.Text = " ";
            comboBox26.Text = " ";
            comboBox24.Text = " ";
            comboBox31.Text = " ";
            comboBox29.Text = " ";
            comboBox27.Text = " ";
            comboBox25.Text = " ";
            comboBox23.Text = " ";

        }

        private void button98_Click(object sender, EventArgs e)
        {
            comboBox32.Text = " ";
            comboBox30.Text = " ";
            comboBox28.Text = " ";
            comboBox26.Text = " ";
            comboBox24.Text = " ";
            comboBox31.Text = " ";
            comboBox29.Text = " ";
            comboBox27.Text = " ";
            comboBox25.Text = " ";
            comboBox23.Text = " ";
        }

        private void button99_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int dmt1 = dmt();


            label179.Text = "Azim Başarmanın Yarısıdır";
            pictureBox57.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
            comboBox32.Text = " ";
            comboBox30.Text = " ";
            comboBox28.Text = " ";
            comboBox26.Text = " ";
            comboBox24.Text = " ";
            comboBox31.Text = " ";
            comboBox29.Text = " ";
            comboBox27.Text = " ";
            comboBox25.Text = " ";
            comboBox23.Text = " ";

        }
        int tmt()
        {
            int doğru1 = 0;

            if (comboBox3.Text == "Ali Kuşçu ")
            {
                doğru1 += 1;

            }

            if (comboBox4.Text == "Cahit Arf")
            {
                doğru1 += 1;

            }
            if (comboBox5.Text == "Matrakçı Nasuh")
            {
                doğru1 += 1;

            }
            if (comboBox6.Text == "Ömer Hayyam")
            {
                doğru1 += 1;

            }
            if (comboBox7.Text == "Fatih Erim")
            {
                doğru1 += 1;

            }
            if (comboBox8.Text == "Ali Nesin")
            {
                doğru1 += 1;

            }
            if (comboBox9.Text == "Ali Kuşçu")
            {
                doğru1 += 1;

            }
            if (comboBox10.Text == "Salih Zeki")
            {
                doğru1 += 1;

            }
            if (comboBox11.Text == "Gelembevi İsmail Efendi")
            {
                doğru1 += 1;

            }
            if (comboBox12.Text == "Ali Kuşçu")
            {
                doğru1 += 1;

            }
            return doğru1;
        }
        private void button102_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int tmt1 = tmt();
            if (tmt1 >= 7)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox93.Image = Properties.Resources._3yıldız;
            }
            else if (tmt1 >= 5)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox93.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox93.Image = Properties.Resources._1yıldız;
            }
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";
            comboBox6.Text = " ";
            comboBox7.Text = " ";
            comboBox8.Text = " ";
            comboBox9.Text = " ";
            comboBox10.Text = " ";
            comboBox11.Text = " ";
            comboBox12.Text = " ";
        }

        private void button101_Click(object sender, EventArgs e)
        {
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";
            comboBox6.Text = " ";
            comboBox7.Text = " ";
            comboBox8.Text = " ";
            comboBox9.Text = " ";
            comboBox10.Text = " ";
            comboBox11.Text = " ";
            comboBox12.Text = " ";



        }

        private void button100_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int tmt1 = tmt();


            label179.Text = "Azim Başarmanın Yarısıdır";
            pictureBox57.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";
            comboBox6.Text = " ";
            comboBox7.Text = " ";
            comboBox8.Text = " ";
            comboBox9.Text = " ";
            comboBox10.Text = " ";
            comboBox11.Text = " ";
            comboBox12.Text = " ";
        }
        int imt()
        {
            int doğru1 = 0;

            if (comboBox22.Text == "Muhyiddin El-Mağribi")
            {
                doğru1 += 1;

            }

            if (comboBox20.Text == "Siczi")
            {
                doğru1 += 1;

            }
            if (comboBox18.Text == "El Harizmi")
            {
                doğru1 += 1;

            }
            if (comboBox16.Text == "Abbas bin Said Cevheri")
            {
                doğru1 += 1;

            }
            if (comboBox12.Text == "Ahmed bin Musa")
            {
                doğru1 += 1;

            }
            if (comboBox21.Text == "Yakub bin Tarık")
            {
                doğru1 += 1;

            }
            if (comboBox19.Text == "")
            {
                doğru1 += 1;

            }
            if (comboBox17.Text == "El Harizmi")
            {
                doğru1 += 1;

            }
            if (comboBox15.Text == "Muhyiddin El-Mağribi")
            {
                doğru1 += 1;

            }
            if (comboBox13.Text == "Ahmed bin Musa")
            {
                doğru1 += 1;

            }
            return doğru1;
        }
        private void button105_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int imt1 = imt();
            if (imt1 >= 7)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox95.Image = Properties.Resources._3yıldız;
            }
            else if (imt1 >= 5)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox95.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox95.Image = Properties.Resources._1yıldız;
            }
            comboBox22.Text = " ";
            comboBox20.Text = " ";
            comboBox18.Text = " ";
            comboBox16.Text = " ";
            comboBox12.Text = " ";
            comboBox21.Text = " ";
            comboBox19.Text = " ";
            comboBox17.Text = " ";
            comboBox15.Text = " ";
            comboBox13.Text = " ";
        }

        private void button104_Click(object sender, EventArgs e)
        {
            comboBox22.Text = " ";
            comboBox20.Text = " ";
            comboBox18.Text = " ";
            comboBox16.Text = " ";
            comboBox12.Text = " ";
            comboBox21.Text = " ";
            comboBox19.Text = " ";
            comboBox17.Text = " ";
            comboBox15.Text = " ";
            comboBox13.Text = " ";
        }

        private void button103_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int imt1 = imt();


            label179.Text = "Azim Başarmanın Yarısıdır";
            pictureBox57.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
            comboBox22.Text = " ";
            comboBox20.Text = " ";
            comboBox18.Text = " ";
            comboBox16.Text = " ";
            comboBox12.Text = " ";
            comboBox21.Text = " ";
            comboBox19.Text = " ";
            comboBox17.Text = " ";
            comboBox15.Text = " ";
            comboBox13.Text = " ";
        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void tabPage35_Click(object sender, EventArgs e)
        {

        }

        private void button142_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        #region DMT
        int DMTR = 0;
        int dmtdoğru = 0;
        private void button118_Click(object sender, EventArgs e)
        {
            if (DMTR == 0)
            {
                button118.BackColor = Color.Red;
                DMTR += 1;

                button118.BackColor = Color.FromArgb(24, 218, 210);
                button118.Text = "Issac Newton";
                button114.Text = "Öklid";
                button112.Text = "El-Harizmi";
                pictureBox54.Image = Properties.Resources.Oklid_Kimdir;
            }
            else if (DMTR == 1)
            {
                button118.BackColor = Color.Red;
                DMTR += 1;

                button118.BackColor = Color.FromArgb(24, 218, 210);
                button118.Text = "Pascall";
                button114.Text = "Thales";
                button112.Text = "Pisagor";
                pictureBox54.Image = Properties.Resources.pascal;
            }
            else if (DMTR == 2)
            {
                button118.BackColor = Color.Green;
                DMTR += 1;
                dmtdoğru += 1;

                button118.BackColor = Color.FromArgb(24, 218, 210);
                button118.Text = "Issac Newton";
                button114.Text = "Descartes";
                button112.Text = "Thales";
                pictureBox54.Image = Properties.Resources.newton;
            }

            else if (DMTR == 3)
            {
                button118.BackColor = Color.Red;
                DMTR += 1;
                dmtdoğru += 1;

                button118.BackColor = Color.FromArgb(24, 218, 210);
                button118.Text = "El Harizmi";
                button114.Text = "Thales";
                button112.Text = "Pascall";
                pictureBox54.Image = Properties.Resources.thales;
            }
            else if (DMTR == 4)
            {
                button118.BackColor = Color.Red;
                DMTR += 1;


                button118.BackColor = Color.FromArgb(24, 218, 210);
                button118.Text = "Oklid";
                button114.Text = "Pisagor";
                button112.Text = "El Harizmi";
                pictureBox54.Image = Properties.Resources.resim3__1_;
            }
            else if (DMTR == 5)
            {
                button118.BackColor = Color.Red;
                button118.BackColor = Color.FromArgb(24, 218, 210);
                tabControl1.SelectedTab = tabPage43;
                int imt1 = imt();
                if (dmtdoğru >= 4)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._3yıldız;
                }
                else if (dmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._1yıldız;
                }
                DMTR = 0;
                dmtdoğru = 0;
                button118.Text = "Arşimet";
                button114.Text = "İssac Newton";
                button112.Text = "Descartes";
                pictureBox54.Image = Properties.Resources.descartes;
            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (DMTR == 0)
            {
                button114.BackColor = Color.Red;
                DMTR += 1;

                button114.BackColor = Color.FromArgb(24, 218, 230);
                button114.Text = "Issac Newton";
                button114.Text = "Öklid";
                button112.Text = "El-Harizmi";
                pictureBox54.Image = Properties.Resources.Oklid_Kimdir;
            }
            else if (DMTR == 1)
            {
                button114.BackColor = Color.Green;
                DMTR += 1;
                dmtdoğru += 1;

                button114.BackColor = Color.FromArgb(24, 218, 230);
                button114.Text = "Pascall";
                button114.Text = "Thales";
                button112.Text = "Pisagor";
                pictureBox54.Image = Properties.Resources.pascal;
            }
            else if (DMTR == 2)
            {
                button114.BackColor = Color.Red;
                DMTR += 1;

                button114.BackColor = Color.FromArgb(24, 218, 230);
                button114.Text = "Issac Newton";
                button114.Text = "Descartes";
                button112.Text = "Thales";
                pictureBox54.Image = Properties.Resources.newton;
            }

            else if (DMTR == 3)
            {
                button114.BackColor = Color.Red;
                DMTR += 1;


                button114.BackColor = Color.FromArgb(24, 218, 230);
                button114.Text = "El Harizmi";
                button114.Text = "Thales";
                button112.Text = "Pascall";
                pictureBox54.Image = Properties.Resources.thales;
            }
            else if (DMTR == 4)
            {
                button114.BackColor = Color.Green;
                DMTR += 1;
                dmtdoğru += 1;

                button114.BackColor = Color.FromArgb(24, 218, 230);
                button114.Text = "Oklid";
                button114.Text = "Pisagor";
                button112.Text = "El Harizmi";
                pictureBox54.Image = Properties.Resources.resim3__1_;
            }
            else if (DMTR == 5)
            {
                button118.BackColor = Color.Red;
                button118.BackColor = Color.FromArgb(24, 218, 210);
                tabControl1.SelectedTab = tabPage43;
                int imt1 = imt();
                if (dmtdoğru >= 4)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._3yıldız;
                }
                else if (dmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._1yıldız;
                }
                DMTR = 0;
                dmtdoğru = 0;
                button118.Text = "Arşimet";
                button114.Text = "İssac Newton";
                button112.Text = "Descartes";
                pictureBox54.Image = Properties.Resources.descartes;
            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (DMTR == 0)
            {


                dmtdoğru += 1;
                DMTR += 1;
                button118.Text = "Issac Newton";
                button114.Text = "Öklid";
                button112.Text = "El-Harizmi";
                pictureBox54.Image = Properties.Resources.Oklid_Kimdir;
            }
            else if (DMTR == 1)
            {

                DMTR += 1;

                button118.Text = "Pascall";
                button114.Text = "Thales";
                button112.Text = "Pisagor";
                pictureBox54.Image = Properties.Resources.pascal;
            }
            else if (DMTR == 2)
            {

                DMTR += 1;

                button118.Text = "Issac Newton";
                button114.Text = "Descartes";
                button112.Text = "Thales";
                pictureBox54.Image = Properties.Resources.newton;
            }
            else if (DMTR == 3)
            {

                DMTR += 1;


                button118.Text = "El Harizmi";
                button114.Text = "Thales";
                button112.Text = "Pascall";
                pictureBox54.Image = Properties.Resources.thales;
            }

            else if (DMTR == 4)
            {



                DMTR += 1;

                button118.Text = "Oklid";
                button114.Text = "Pisagor";
                button112.Text = "El Harizmi";
                pictureBox54.Image = Properties.Resources.resim3__1_;
            }
            else if (DMTR == 5)
            {
                button118.BackColor = Color.Red;
                button118.BackColor = Color.FromArgb(24, 218, 210);
                tabControl1.SelectedTab = tabPage43;
                dmtdoğru += 1;
                if (dmtdoğru >= 4)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._3yıldız;
                }
                else if (dmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._1yıldız;
                }
                DMTR = 0;
                dmtdoğru = 0;
                button118.Text = "Arşimet";
                button114.Text = "İssac Newton";
                button112.Text = "Descartes";
                pictureBox54.Image = Properties.Resources.descartes;
            }

        }

        private void button120_Click(object sender, EventArgs e)
        {
            //bırak-tekrar
            DMTR = 0;
            dmtdoğru = 0;
            button118.Text = "Arşimet";
            button114.Text = "İssac Newton";
            button112.Text = "Descartes";
            pictureBox54.Image = Properties.Resources.descartes;
        }


        private void button119_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;
            int imt1 = imt();


            label179.Text = "Azim Başarmanın Yarısıdır";
            pictureBox57.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
            pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
            DMTR = 0;
            dmtdoğru = 0;
            button118.Text = "Arşimet";
            button114.Text = "İssac Newton";
            button112.Text = "Descartes";
            pictureBox54.Image = Properties.Resources.descartes;

        }
        private void button113_Click(object sender, EventArgs e)
        {
            if (DMTR == 0)
            {

                DMTR += 1;


                button118.Text = "Issac Newton";
                button114.Text = "Öklid";
                button112.Text = "El-Harizmi";
                pictureBox54.Image = Properties.Resources.Oklid_Kimdir;
            }
            else if (DMTR == 1)
            {

                DMTR += 1;


                button118.Text = "Pascall";
                button114.Text = "Thales";
                button112.Text = "Pisagor";
                pictureBox54.Image = Properties.Resources.pascal;
            }
            else if (DMTR == 2)
            {

                DMTR += 1;


                button118.Text = "Issac Newton";
                button114.Text = "Descartes";
                button112.Text = "Thales";
                pictureBox54.Image = Properties.Resources.newton;
            }

            else if (DMTR == 3)
            {

                DMTR += 1;



                button118.Text = "El Harizmi";
                button114.Text = "Thales";
                button112.Text = "Pascall";
                pictureBox54.Image = Properties.Resources.thales;
            }
            else if (DMTR == 4)
            {

                DMTR += 1;



                button118.Text = "Oklid";
                button114.Text = "Pisagor";
                button112.Text = "El Harizmi";
                pictureBox54.Image = Properties.Resources.resim3__1_;
            }
            else if (DMTR == 5)
            {

                tabControl1.SelectedTab = tabPage43;
                int imt1 = imt();
                if (dmtdoğru >= 4)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._3yıldız;
                }
                else if (dmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox99.Image = Properties.Resources._1yıldız;
                }
                DMTR = 0;
                dmtdoğru = 0;
                button118.Text = "Arşimet";
                button114.Text = "İssac Newton";
                button112.Text = "Descartes";
                pictureBox54.Image = Properties.Resources.descartes;
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        int İMTR = 0;
        int imtdoğru = 0;
        private void button117_Click(object sender, EventArgs e)
        {
            if (İMTR == 0)
            {

                İMTR += 1;
                button115.Text = "Said Cevheri";
                button116.Text = "Ahmed Bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.muhyiddini_ibn_arabi_hz_ks__1_;
            }
            else if (İMTR == 1)
            {
                İMTR += 1;
                button115.Text = "Zekeriya El Kazvini";
                button116.Text = "Said Cevheri";
                button117.Text = "Yakub bin Tarık";
                pictureBox53.Image = Properties.Resources.ahmet_celebi;
            }
            else if (İMTR == 2)
            {
                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Siczi";
                button117.Text = "El Biruni";
                pictureBox53.Image = Properties.Resources._64004;
            }
            else if (İMTR == 3)
            {
                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Ahmed bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.resim3;
            }



            else if (İMTR == 4)
            {
                imtdoğru += 1;
                tabControl1.SelectedTab = tabPage43;

                if (imtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._3yıldız;
                }
                else if (imtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._1yıldız;
                }
                İMTR = 0;
                imtdoğru = 0;
                button115.Text = "Abbas bin Said Cevheri";
                button116.Text = "El Biruni";
                button117.Text = "El Harizmi";
                pictureBox53.Image = Properties.Resources.Al_Biruni_big1;
            }

        }


        private void button116_Click(object sender, EventArgs e)
        {
            if (İMTR == 0)
            {
                imtdoğru += 1;

                İMTR += 1;
                button115.Text = "Said Cevheri";
                button116.Text = "Ahmed Bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.muhyiddini_ibn_arabi_hz_ks__1_;
            }
            else if (İMTR == 1)
            {
                İMTR += 1;
                button115.Text = "Zekeriya El Kazvini";
                button116.Text = "Said Cevheri";
                button117.Text = "Yakub bin Tarık";
                pictureBox53.Image = Properties.Resources.ahmet_celebi;
            }
            else if (İMTR == 2)
            {
                imtdoğru += 1;
                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Siczi";
                button117.Text = "El Biruni";
                pictureBox53.Image = Properties.Resources._64004;
            }
            else if (İMTR == 3)
            {
                imtdoğru += 1;
                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Ahmed bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.resim3;
            }



            else if (İMTR == 4)
            {

                tabControl1.SelectedTab = tabPage43;

                if (imtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._3yıldız;
                }
                else if (imtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._1yıldız;
                }
                İMTR = 0;
                imtdoğru = 0;
                button115.Text = "Abbas bin Said Cevheri";
                button116.Text = "El Biruni";
                button117.Text = "El Harizmi";
                pictureBox53.Image = Properties.Resources.Al_Biruni_big1;
            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (İMTR == 0)
            {

                İMTR += 1;
                button115.Text = "Said Cevheri";
                button116.Text = "Ahmed Bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.muhyiddini_ibn_arabi_hz_ks__1_;
            }
            else if (İMTR == 1)
            {
                imtdoğru += 1;
                İMTR += 1;
                button115.Text = "Zekeriya El Kazvini";
                button116.Text = "Said Cevheri";
                button117.Text = "Yakub bin Tarık";
                pictureBox53.Image = Properties.Resources.ahmet_celebi;
            }
            else if (İMTR == 2)
            {
                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Siczi";
                button117.Text = "El Biruni";
                pictureBox53.Image = Properties.Resources._64004;
            }
            else if (İMTR == 3)
            {

                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Ahmed bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.resim3;
            }



            else if (İMTR == 4)
            {

                tabControl1.SelectedTab = tabPage43;

                if (imtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._3yıldız;
                }
                else if (imtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._1yıldız;
                }
                İMTR = 0;
                imtdoğru = 0;
                button115.Text = "Abbas bin Said Cevheri";
                button116.Text = "El Biruni";
                button117.Text = "El Harizmi";
                pictureBox53.Image = Properties.Resources.Al_Biruni_big1;
            }
        }

        private void button109_Click(object sender, EventArgs e)
        {
            İMTR = 0;
            imtdoğru = 0;
            button115.Text = "Abbas bin Said Cevheri";
            button116.Text = "El Biruni";
            button117.Text = "El Harizmi";
            pictureBox53.Image = Properties.Resources.Al_Biruni_big1;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;

            if (imtdoğru >= 3)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox96.Image = Properties.Resources._3yıldız;
            }
            else if (imtdoğru >= 2)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox96.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox96.Image = Properties.Resources._1yıldız;
            }




            İMTR = 0;
            imtdoğru = 0;
            button115.Text = "Abbas bin Said Cevheri";
            button116.Text = "El Biruni";
            button117.Text = "El Harizmi";
            pictureBox53.Image = Properties.Resources.Al_Biruni_big1;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (İMTR == 0)
            {

                İMTR += 1;
                button115.Text = "Said Cevheri";
                button116.Text = "Ahmed Bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.muhyiddini_ibn_arabi_hz_ks__1_;
            }
            else if (İMTR == 1)
            {

                İMTR += 1;
                button115.Text = "Zekeriya El Kazvini";
                button116.Text = "Said Cevheri";
                button117.Text = "Yakub bin Tarık";
                pictureBox53.Image = Properties.Resources.ahmet_celebi;
            }
            else if (İMTR == 2)
            {
                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Siczi";
                button117.Text = "El Biruni";
                pictureBox53.Image = Properties.Resources._64004;
            }
            else if (İMTR == 3)
            {

                İMTR += 1;
                button115.Text = "El Harizmi";
                button116.Text = "Ahmed bin Musa";
                button117.Text = "Muhyiddin El Mağribi";
                pictureBox53.Image = Properties.Resources.resim3;
            }



            else if (İMTR == 4)
            {

                tabControl1.SelectedTab = tabPage43;

                if (imtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._3yıldız;
                }
                else if (imtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox96.Image = Properties.Resources._1yıldız;
                }
                İMTR = 0;
                imtdoğru = 0;
                button115.Text = "Abbas bin Said Cevheri";
                button116.Text = "El Biruni";
                button117.Text = "El Harizmi";
                pictureBox53.Image = Properties.Resources.Al_Biruni_big1;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        int TMTR = 0;
        int tmtdoğru = 0;
        private void button121_Click(object sender, EventArgs e)
        {
            if (TMTR == 0)
            {

                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Ömer Hayyam";
                button106.Text = "Matrakçı Nasuh";
                pictureBox41.Image = Properties.Resources._0x0_bir_osmanli_dhisi_matrakci_nasuh_1524239778355;
            }
            else if (TMTR == 1)
            {
                TMTR += 1;
                button121.Text = "Ali Kuşçu";
                button108.Text = "Gelenbevi İsmail Efendi";
                button106.Text = "Ali Nesin";
                pictureBox41.Image = Properties.Resources.ali_kuscu_nerede_dogmustur_629f0e1920d55;
            }
            else if (TMTR == 2)
            {
                tmtdoğru += 1;
                TMTR += 1;
                button121.Text = "Cahit Arf";
                button108.Text = "Ali Nesin";
                button106.Text = "Salih Zeki";
                pictureBox41.Image = Properties.Resources.Ali_Nesin;
            }
            else if (TMTR == 3)
            {
                TMTR += 1;
                button121.Text = "Kerim Erim";
                button108.Text = "Ali Kuşçu";
                button106.Text = "Ömer Hayyam";
                pictureBox41.Image = Properties.Resources._50801d0bad947494cf02f3a5ea29a956;
            }
            else if (TMTR == 4)
            {
                tmtdoğru += 1;
                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Cahit Arf";
                button106.Text = "Gelenbevi İsmail Efendi";
                pictureBox41.Image = Properties.Resources.resized_01863_47dfbdc2adsiz;
            }


            else if (TMTR == 5)
            {

                tabControl1.SelectedTab = tabPage43;

                if (tmtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._3yıldız;
                }
                else if (tmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._1yıldız;
                }
                TMTR = 0;
                tmtdoğru = 0;
                button121.Text = "Ali Nesin";
                button108.Text = "Cahit Arf";
                button106.Text = "Kerim Erim";
                pictureBox41.Image = Properties.Resources.Cahit_Arf;
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (TMTR == 0)
            {
                tmtdoğru += 1;
                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Ömer Hayyam";
                button106.Text = "Matrakçı Nasuh";
                pictureBox41.Image = Properties.Resources._0x0_bir_osmanli_dhisi_matrakci_nasuh_1524239778355;
            }
            else if (TMTR == 1)
            {
                TMTR += 1;
                button121.Text = "Ali Kuşçu";
                button108.Text = "Gelenbevi İsmail Efendi";
                button106.Text = "Ali Nesin";
                pictureBox41.Image = Properties.Resources.ali_kuscu_nerede_dogmustur_629f0e1920d55;
            }
            else if (TMTR == 2)
            {
                TMTR += 1;
                button121.Text = "Cahit Arf";
                button108.Text = "Ali Nesin";
                button106.Text = "Salih Zeki";
                pictureBox41.Image = Properties.Resources.Ali_Nesin;
            }
            else if (TMTR == 3)
            {
                tmtdoğru += 1;
                TMTR += 1;
                button121.Text = "Kerim Erim";
                button108.Text = "Ali Kuşçu";
                button106.Text = "Ömer Hayyam";
                pictureBox41.Image = Properties.Resources._50801d0bad947494cf02f3a5ea29a956;
            }
            else if (TMTR == 4)
            {
                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Cahit Arf";
                button106.Text = "Gelenbevi İsmail Efendi";
                pictureBox41.Image = Properties.Resources.resized_01863_47dfbdc2adsiz;
            }


            else if (TMTR == 5)
            {

                tabControl1.SelectedTab = tabPage43;

                if (tmtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._3yıldız;
                }
                else if (tmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._1yıldız;
                }
                TMTR = 0;
                tmtdoğru = 0;
                button121.Text = "Ali Nesin";
                button108.Text = "Cahit Arf";
                button106.Text = "Kerim Erim";
                pictureBox41.Image = Properties.Resources.Cahit_Arf;
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (TMTR == 0)
            {

                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Ömer Hayyam";
                button106.Text = "Matrakçı Nasuh";
                pictureBox41.Image = Properties.Resources._0x0_bir_osmanli_dhisi_matrakci_nasuh_1524239778355;
            }
            else if (TMTR == 1)
            {
                tmtdoğru += 1;
                TMTR += 1;
                button121.Text = "Ali Kuşçu";
                button108.Text = "Gelenbevi İsmail Efendi";
                button106.Text = "Ali Nesin";
                pictureBox41.Image = Properties.Resources.ali_kuscu_nerede_dogmustur_629f0e1920d55;
            }
            else if (TMTR == 2)
            {
                TMTR += 1;
                button121.Text = "Cahit Arf";
                button108.Text = "Ali Nesin";
                button106.Text = "Salih Zeki";
                pictureBox41.Image = Properties.Resources.Ali_Nesin;
            }
            else if (TMTR == 3)
            {

                TMTR += 1;
                button121.Text = "Kerim Erim";
                button108.Text = "Ali Kuşçu";
                button106.Text = "Ömer Hayyam";
                pictureBox41.Image = Properties.Resources._50801d0bad947494cf02f3a5ea29a956;
            }
            else if (İMTR == 4)
            {
                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Cahit Arf";
                button106.Text = "Gelenbevi İsmail Efendi";
                pictureBox41.Image = Properties.Resources.resized_01863_47dfbdc2adsiz;
            }


            else if (TMTR == 5)
            {
                tmtdoğru += 1;
                tabControl1.SelectedTab = tabPage43;

                if (tmtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._3yıldız;
                }
                else if (tmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._1yıldız;
                }
                TMTR = 0;
                tmtdoğru = 0;
                button121.Text = "Ali Nesin";
                button108.Text = "Cahit Arf";
                button106.Text = "Kerim Erim";
                pictureBox41.Image = Properties.Resources.Cahit_Arf;
            }
        }

        private void button123_Click(object sender, EventArgs e)
        {
            TMTR = 0;
            tmtdoğru = 0;
            button121.Text = "Ali Nesin";
            button108.Text = "Cahit Arf";
            button106.Text = "Kerim Erim";
            pictureBox41.Image = Properties.Resources.Cahit_Arf;
        }

        private void button122_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;

            if (tmtdoğru >= 3)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox90.Image = Properties.Resources._3yıldız;
            }
            else if (tmtdoğru >= 2)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox90.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox90.Image = Properties.Resources._1yıldız;
            }




            TMTR = 0;
            tmtdoğru = 0;
            button121.Text = "Ali Nesin";
            button108.Text = "Cahit Arf";
            button106.Text = "Kerim Erim";
            pictureBox41.Image = Properties.Resources.Cahit_Arf;
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (TMTR == 0)
            {

                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Ömer Hayyam";
                button106.Text = "Matrakçı Nasuh";
                pictureBox41.Image = Properties.Resources._0x0_bir_osmanli_dhisi_matrakci_nasuh_1524239778355;
            }
            else if (TMTR == 1)
            {
                TMTR += 1;
                button121.Text = "Ali Kuşçu";
                button108.Text = "Gelenbevi İsmail Efendi";
                button106.Text = "Ali Nesin";
                pictureBox41.Image = Properties.Resources.ali_kuscu_nerede_dogmustur_629f0e1920d55;
            }
            else if (TMTR == 2)
            {
                TMTR += 1;
                button121.Text = "Cahit Arf";
                button108.Text = "Ali Nesin";
                button106.Text = "Salih Zeki";
                pictureBox41.Image = Properties.Resources.Ali_Nesin;
            }
            else if (TMTR == 3)
            {

                TMTR += 1;
                button121.Text = "Kerim Erim";
                button108.Text = "Ali Kuşçu";
                button106.Text = "Ömer Hayyam";
                pictureBox41.Image = Properties.Resources._50801d0bad947494cf02f3a5ea29a956;
            }
            else if (TMTR == 4)
            {
                TMTR += 1;
                button121.Text = "Salih Zeki";
                button108.Text = "Cahit Arf";
                button106.Text = "Gelenbevi İsmail Efendi";
                pictureBox41.Image = Properties.Resources.resized_01863_47dfbdc2adsiz;
            }


            else if (TMTR == 5)
            {
                tabControl1.SelectedTab = tabPage43;

                if (tmtdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._3yıldız;
                }
                else if (tmtdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox90.Image = Properties.Resources._1yıldız;
                }
                TMTR = 0;
                tmtdoğru = 0;
                button121.Text = "Ali Nesin";
                button108.Text = "Cahit Arf";
                button106.Text = "Kerim Erim";
                pictureBox41.Image = Properties.Resources.Cahit_Arf;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        int DMTK = 0;
        int dmtkdoğru = 0;
        private void button139_Click(object sender, EventArgs e)
        {
            if (DMTK == 0)
            {
                dmtkdoğru += 1;
                DMTK += 1;
                button139.Text = "Pisagor";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text= "Binam Üçgenini bulan biilim adamı.";
            }
            else if (DMTK == 1)
            {
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Öklid";
                button136.Text = "Descates";
                label184.Text= "Geometriyi tanımlamak için kullanılan analatik geometri ve kartezyeni geliştiren bilim adamı";
            }
            else if (DMTK == 2)
            {
                DMTK += 1;
                button139.Text = "Öklid";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text= "Geometrinin temel ispatını ve aksiyomu bulan bilim adamı";
            }
            else if (DMTK == 3)
            {
                dmtkdoğru += 1;
                DMTK += 1;
                button139.Text = "Descartes";
                button138.Text = "Aeşimet";
                button136.Text = "Pisagor";
                label184.Text= "Bir Dik üçgende kısa kenarlarının karesinin toplamı hipotenüsün karesine eşit olduğunu bulan bilim adamı.";
            }
            else if (DMTK == 4)
            {
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Thales";
                button136.Text = "Öklid";
                label184.Text= "Birbirini kesen iki doğrunun oluşturduğu zıt açıların birbirine eşit olduğunu bulan bilim adamı.";
            }


            else if (DMTK == 5)
            {
                tabControl1.SelectedTab = tabPage43;

                if (dmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._3yıldız;
                }
                else if (dmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._1yıldız;
                }
                //123132
                DMTK = 0;
                dmtkdoğru = 0;
                button139.Text = "Arşimet";
                button138.Text = "Issac Newton";
                button136.Text = "Pisagor";
                label184.Text= "Bir kürenin yüzölçümünün 4πr²ve hacminin ise 4/3πr³eşit olduğunu bulan bilim adamı.";
            }
        }

        private void button138_Click(object sender, EventArgs e)
        {
            if (DMTK == 0)
            {
                
                DMTK += 1;
                button139.Text = "Pisagor";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text= "Binam Üçgenini bulan biilim adamı.";
            }
            else if (DMTK == 1)
            {
                dmtkdoğru += 1;
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Öklid";
                button136.Text = "Descates";
                label184.Text= "Geometriyi tanımlamak için kullanılan analatik geometri ve kartezyeni geliştiren bilim adamı";
            }
            else if (DMTK == 2)
            {
                DMTK += 1;
                button139.Text = "Öklid";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text= "Geometrinin temel ispatını ve aksiyomu bulan bilim adamı";
            }
            else if (DMTK == 3)
            {
               
                DMTK += 1;
                button139.Text = "Descartes";
                button138.Text = "Aeşimet";
                button136.Text = "Pisagor";
                label184.Text= "Bir Dik üçgende kısa kenarlarının karesinin toplamı hipotenüsün karesine eşit olduğunu bulan bilim adamı.";
            }
            else if (DMTK == 4)
            {
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Thales";
                button136.Text = "Öklid";
                label184.Text= "Birbirini kesen iki doğrunun oluşturduğu zıt açıların birbirine eşit olduğunu bulan bilim adamı.";
            }


            else if (DMTK == 5)
            {
                dmtkdoğru += 1;
                tabControl1.SelectedTab = tabPage43;

                if (dmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._3yıldız;
                }
                else if (dmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._1yıldız;
                }
                //123132
                DMTK = 0;
                dmtkdoğru = 0;
                button139.Text = "Arşimet";
                button138.Text = "Issac Newton";
                button136.Text = "Pisagor";
                label184.Text= "Bir kürenin yüzölçümünün 4πr²ve hacminin ise 4/3πr³eşit olduğunu bulan bilim adamı.";
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            if (DMTK == 0)
            {

                DMTK += 1;
                button139.Text = "Pisagor";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text = "Binam Üçgenini bulan biilim adamı.";
            }
            else if (DMTK == 1)
            {
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Öklid";
                button136.Text = "Descates";
                label184.Text = "Geometriyi tanımlamak için kullanılan analatik geometri ve kartezyeni geliştiren bilim adamı";
            }
            else if (DMTK == 2)
            {
                dmtkdoğru += 1;
                DMTK += 1;
                button139.Text = "Öklid";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text = "Geometrinin temel ispatını ve aksiyomu bulan bilim adamı";
            }
            else if (DMTK == 3)
            {

                DMTK += 1;
                button139.Text = "Descartes";
                button138.Text = "Aeşimet";
                button136.Text = "Pisagor";
                label184.Text = "Bir Dik üçgende kısa kenarlarının karesinin toplamı hipotenüsün karesine eşit olduğunu bulan bilim adamı.";
            }
            else if (DMTK == 4)
            {
                dmtkdoğru += 1;
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Thales";
                button136.Text = "Öklid";
                label184.Text = "Birbirini kesen iki doğrunun oluşturduğu zıt açıların birbirine eşit olduğunu bulan bilim adamı.";
            }


            else if (DMTK == 5)
            {
                tabControl1.SelectedTab = tabPage43;

                if (dmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._3yıldız;
                }
                else if (dmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._1yıldız;
                }
                //123132
                DMTK = 0;
                dmtkdoğru = 0;
                button139.Text = "Arşimet";
                button138.Text = "Issac Newton";
                button136.Text = "Pisagor";
                label184.Text = "Bir kürenin yüzölçümünün 4πr²ve hacminin ise 4/3πr³eşit olduğunu bulan bilim adamı.";
            }
        }

        private void button141_Click(object sender, EventArgs e)
        {
            DMTK = 0;
            dmtkdoğru = 0;
            button139.Text = "Arşimet";
            button138.Text = "Issac Newton";
            button136.Text = "Pisagor";
            label184.Text = "Bir kürenin yüzölçümünün 4πr²ve hacminin ise 4/3πr³eşit olduğunu bulan bilim adamı.";
        }

        private void button140_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;

            if (dmtkdoğru >= 3)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox100.Image = Properties.Resources._3yıldız;
            }
            else if (dmtkdoğru >= 2)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox100.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox100.Image = Properties.Resources._1yıldız;
            }




            DMTK = 0;
            dmtkdoğru = 0;
            button139.Text = "Arşimet";
            button138.Text = "Issac Newton";
            button136.Text = "Pisagor";
            label184.Text = "Bir kürenin yüzölçümünün 4πr²ve hacminin ise 4/3πr³eşit olduğunu bulan bilim adamı.";
        }

        private void button137_Click(object sender, EventArgs e)
        {
            if (DMTK == 0)
            {

                DMTK += 1;
                button139.Text = "Pisagor";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text = "Binom Üçgenini bulan biilim adamı.";
            }
            else if (DMTK == 1)
            {
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Öklid";
                button136.Text = "Descates";
                label184.Text = "Geometriyi tanımlamak için kullanılan analatik geometri ve kartezyeni geliştiren bilim adamı";
            }
            else if (DMTK == 2)
            {
                DMTK += 1;
                button139.Text = "Öklid";
                button138.Text = "Pascal";
                button136.Text = "Issac Newton";
                label184.Text = "Geometrinin temel ispatını ve aksiyomu bulan bilim adamı";
            }
            else if (DMTK == 3)
            {

                DMTK += 1;
                button139.Text = "Descartes";
                button138.Text = "Aeşimet";
                button136.Text = "Pisagor";
                label184.Text = "Bir Dik üçgende kısa kenarlarının karesinin toplamı hipotenüsün karesine eşit olduğunu bulan bilim adamı.";
            }
            else if (DMTK == 4)
            {
                DMTK += 1;
                button139.Text = "Arşimet";
                button138.Text = "Thales";
                button136.Text = "Öklid";
                label184.Text = "Birbirini kesen iki doğrunun oluşturduğu zıt açıların birbirine eşit olduğunu bulan bilim adamı.";
            }


            else if (DMTK == 5)
            {
                tabControl1.SelectedTab = tabPage43;

                if (dmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._3yıldız;
                }
                else if (dmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox100.Image = Properties.Resources._1yıldız;
                }
                //123132
                DMTK = 0;
                dmtkdoğru = 0;
                button139.Text = "Arşimet";
                button138.Text = "Issac Newton";
                button136.Text = "Pisagor";
                label184.Text = "Bir kürenin yüzölçümünün 4πr²ve hacminin ise 4/3πr³eşit olduğunu bulan bilim adamı.";
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        int TMTK = 0;
        int tmtkdoğru = 0;
        private void button127_Click(object sender, EventArgs e)
        {
            if (TMTK== 0)
            {
                tmtkdoğru += 1;
                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Levaati Ödülünü kazanan türk matematikçi.";
            }
            else if (TMTK == 1)
            {
                tmtkdoğru += 1;
                TMTK += 1;
                button127.Text = "Salih Zeki";
                button126.Text = "Cahit Arf";
                button124.Text = "Ali Kuşçu";
                label177.Text = "Arf Sabiti ve Arf Denklemlerini bulan matematikçimiz";
            }
            else if (TMTK == 2)
            {
                TMTK += 1;
                button127.Text = "Kerim Erim";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Türkiyeye lagoritmayı sokan bilim adamıdır.";
            }
            else if (TMTK == 3)
            {

                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Ömer Hayyam";
                button124.Text = "Cahit Arf";
                label177.Text = "Kafes çarpım yöntemi gibi çarpma yöntemlerini keşfeden kişi.";
            }
            else if (TMTK == 4)
            {

                tmtkdoğru += 1;
                TMTK += 1;
                button127.Text = "Cahit Arf";
                button126.Text = "Salih Zeki";
                button124.Text = "Kerim Erim";
                label177.Text = "Matemetik doktorası alan ilk türk matematikçi.";
            }


            else if (TMTK == 5)
            {
                tmtkdoğru += 1;
                tabControl1.SelectedTab = tabPage43;

                if (tmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._3yıldız;
                }
                else if (tmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._1yıldız;
                }
                //123132
                TMTK = 0;
                tmtkdoğru = 0;
                button127.Text = "Ali Kuşçu";
                button126.Text = "Cahit Arf";
                button124.Text = "Matrakçı Nasuh";
                label177.Text = "Güneş saatini icat edip dünyanın eksenini ölçen Türk bilim adımının adı.";
            }
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (TMTK == 0)
            {

                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Levaati Ödülünü kazanan türk matematikçi.";
            }
            else if (TMTK == 1)
            {
                TMTK += 1;
                button127.Text = "Salih Zeki";
                button126.Text = "Cahit Arf";
                button124.Text = "Ali Kuşçu";
                label177.Text = "Arf Sabiti ve Arf Denklemlerini bulan matematikçimiz";
            }
            else if (TMTK == 2)
            {
                tmtkdoğru += 1;
                TMTK += 1;
                button127.Text = "Kerim Erim";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Türkiyeye lagoritmayı sokan bilim adamıdır.";
            }
            else if (TMTK == 3)
            {
                tmtkdoğru += 1;
                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Ömer Hayyam";
                button124.Text = "Cahit Arf";
                label177.Text = "Kafes çarpım yöntemi gibi çarpma yöntemlerini keşfeden kişi.";
            }
            else if (TMTK == 4)
            {
                TMTK += 1;
                button127.Text = "Cahit Arf";
                button126.Text = "Salih Zeki";
                button124.Text = "Kerim Erim";
                label177.Text = "Matemetik doktorası alan ilk türk matematikçi.";
            }


            else if (TMTK == 5)
            {
                tabControl1.SelectedTab = tabPage43;

                if (tmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._3yıldız;
                }
                else if (tmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._1yıldız;
                }
                //123132
                TMTK = 0;
                tmtkdoğru = 0;
                button127.Text = "Ali Kuşçu";
                button126.Text = "Cahit Arf";
                button124.Text = "Matrakçı Nasuh";
                label177.Text = "Güneş saatini icat edip dünyanın eksenini ölçen Türk bilim adımının adı.";
            }
        }

        private void button124_Click(object sender, EventArgs e)
        {
            if (TMTK == 0)
            {

                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Levaati Ödülünü kazanan türk matematikçi.";
            }
            else if (TMTK == 1)
            {
                tmtkdoğru += 1;
                TMTK += 1;
                button127.Text = "Salih Zeki";
                button126.Text = "Cahit Arf";
                button124.Text = "Ali Kuşçu";
                label177.Text = "Arf Sabiti ve Arf Denklemlerini bulan matematikçimiz";
            }
            else if (TMTK == 2)
            {
                TMTK += 1;
                button127.Text = "Kerim Erim";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Türkiyeye lagoritmayı sokan bilim adamıdır.";
            }
            else if (TMTK == 3)
            {

                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Ömer Hayyam";
                button124.Text = "Cahit Arf";
                label177.Text = "Kafes çarpım yöntemi gibi çarpma yöntemlerini keşfeden kişi.";
            }
            else if (TMTK == 4)
            {
                TMTK += 1;
                button127.Text = "Cahit Arf";
                button126.Text = "Salih Zeki";
                button124.Text = "Kerim Erim";
                label177.Text = "Matemetik doktorası alan ilk türk matematikçi.";
            }


            else if (TMTK == 5)
            {
                tmtkdoğru += 1;
                tabControl1.SelectedTab = tabPage43;

                if (tmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._3yıldız;
                }
                else if (tmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._1yıldız;
                }
                //123132
                TMTK = 0;
                tmtkdoğru = 0;
                button127.Text = "Ali Kuşçu";
                button126.Text = "Cahit Arf";
                button124.Text = "Matrakçı Nasuh";
                label177.Text = "Güneş saatini icat edip dünyanın eksenini ölçen Türk bilim adımının adı.";
            }
        }

        private void button129_Click(object sender, EventArgs e)
        {
            TMTK = 0;
            tmtkdoğru = 0;
            button127.Text = "Ali Kuşçu";
            button126.Text = "Cahit Arf";
            button124.Text = "Matrakçı Nasuh";
            label177.Text = "Güneş saatini icat edip dünyanın eksenini ölçen Türk bilim adımının adı.";
        }

        private void button128_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage43;

            if (tmtkdoğru >= 3)
            {
                label179.Text = "Tebrikler";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox89.Image = Properties.Resources._3yıldız;
            }
            else if (tmtkdoğru >= 2)
            {
                label179.Text = "İdare Eder";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox89.Image = Properties.Resources._2yıldız;
            }
            else
            {
                label179.Text = "Biraz Daha Çalış";
                pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                pictureBox89.Image = Properties.Resources._1yıldız;
            }
            //123132
            TMTK = 0;
            tmtkdoğru = 0;
            button127.Text = "Ali Kuşçu";
            button126.Text = "Cahit Arf";
            button124.Text = "Matrakçı Nasuh";
            label177.Text = "Güneş saatini icat edip dünyanın eksenini ölçen Türk bilim adımının adı.";
        }
    

        private void button125_Click(object sender, EventArgs e)
        {
            if (TMTK == 0)
            {

                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Levaati Ödülünü kazanan türk matematikçi.";
            }
            else if (TMTK == 1)
            {
                TMTK += 1;
                button127.Text = "Salih Zeki";
                button126.Text = "Cahit Arf";
                button124.Text = "Ali Kuşçu";
                label177.Text = "Arf Sabiti ve Arf Denklemlerini bulan matematikçimiz";
            }
            else if (TMTK == 2)
            {
                TMTK += 1;
                button127.Text = "Kerim Erim";
                button126.Text = "Gelenbevi İsmail Efendi";
                button124.Text = "Ali Nesin";
                label177.Text = "Türkiyeye lagoritmayı sokan bilim adamıdır.";
            }
            else if (TMTK == 3)
            {

                TMTK += 1;
                button127.Text = "Matrakçı Nasuh";
                button126.Text = "Ömer Hayyam";
                button124.Text = "Cahit Arf";
                label177.Text = "Kafes çarpım yöntemi gibi çarpma yöntemlerini keşfeden kişi.";
            }
            else if (TMTK == 4)
            {
                TMTK += 1;
                button127.Text = "Cahit Arf";
                button126.Text = "Salih Zeki";
                button124.Text = "Kerim Erim";
                label177.Text = "Matemetik doktorası alan ilk türk matematikçi.";
            }


            else if (TMTK == 5)
            {
                tabControl1.SelectedTab = tabPage43;

                if (tmtkdoğru >= 3)
                {
                    label179.Text = "Tebrikler";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._3yıldız;
                }
                else if (tmtkdoğru >= 2)
                {
                    label179.Text = "İdare Eder";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._2yıldız;
                }
                else
                {
                    label179.Text = "Biraz Daha Çalış";
                    pictureBox57.Image = Properties.Resources.a_removebg_preview__1_;
                    pictureBox58.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox59.Image = Properties.Resources.b_removebg_preview__1_;
                    pictureBox89.Image = Properties.Resources._1yıldız;
                }
                //123132
                TMTK = 0;
                tmtkdoğru = 0;
                button127.Text = "Ali Kuşçu";
                button126.Text = "Cahit Arf";
                button124.Text = "Matrakçı Nasuh";
                label177.Text = "Güneş saatini icat edip dünyanın eksenini ölçen Türk bilim adımının adı.";
            }
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button143_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Ayarlara girmeden önce giriş yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Bilgiler Kısmına girmeden önce giriş yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 frm = new();
            frm.ShowDialog();
        }
    }
 }

