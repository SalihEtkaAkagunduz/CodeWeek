using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace Code_WEEK
{
    public partial class Form1 : Form
    {
        public string þþ;
        public Form1()
        {
            InitializeComponent();
            groupBox2.Hide();
            ww();
        }
        void ww()
        {
            bool exists = Directory.Exists(@"C:\ProgramData\SEAPP");
            if (exists)
            {

            }
            else
            {
                Directory.CreateDirectory(@"C:\ProgramData\SEAPP");
            }
            bool þ = File.Exists(@"C:\ProgramData\SEAPP\HATIRLA.txt");
            if (þ)
            {
                þþ = File.ReadAllText(@"C:\ProgramData\SEAPP\HATIRLA.txt");

            }
            else
            {
                string jj = @"C:\ProgramData\SEAPP\HATIRLA.txt";
                FileStream þþþþ = File.Create(jj);
                þþþþ.Close();
                File.WriteAllText(@"C:\ProgramData\SEAPP\HATIRLA.txt", "0");
            }
            string hh = File.ReadAllText(@"C:\ProgramData\SEAPP\HATIRLA.txt");
            if (hh == "1")
            {
                this.Visible = false;
                Form2 t = new Form2();
                t.Show();



            }
            else
            {
                label1.Show();
                label2.Show();
                pictureBox1.Show();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                button1.Hide();
                textBox1.Hide();
                pictureBox3.Hide();
                String[] aaa = Directory.GetDirectories(@"C:\ProgramData\SEAPP");
                foreach (string s in aaa)
                {
                    string ss = s.Remove(0, 21);
                    listBox1.Items.Add(ss);
                }
                listBox1.Items.Add("Adýmý Göremiyorum");
            }
        }
        public string ne;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (listBox1.SelectedItem.ToString() != "Adýmý Göremiyorum")
            {
                ne = listBox1.SelectedItem.ToString();
                label4.Text = "Merhaba " + listBox1.SelectedItem.ToString();
                label1.Hide();
                label2.Hide();
                pictureBox1.Hide();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Hide();
                button1.Hide();
                textBox1.Show();
                pictureBox3.Show();
                this.AcceptButton = button2;
                File.Delete(@"C:\ProgramData\SEAPP\mevcut.txt");
                FileStream flstrm0 = File.Create(@"C:\ProgramData\SEAPP\mevcut.txt");
                flstrm0.Close();
                File.WriteAllText(@"C:\ProgramData\SEAPP\mevcut.txt", listBox1.SelectedItem.ToString());

            }
            else
            {


                this.AcceptButton = button1;
                textBox1.Hide();

                label4.Hide();
                label5.Hide();
                label6.Hide();
                label1.Hide();
                label2.Hide();
                pictureBox3.Show();
                button2.Hide();
                pictureBox1.Hide();
                label7.Show();
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ExeDosyaYolu = Application.StartupPath.ToString();
            string ExeDosyaYolu2 = ExeDosyaYolu.Remove(ExeDosyaYolu.Length - 35, 35) + "Kayýt\\WindowsFormsApp5\\bin\\Debug\\WindowsFormsApp5.exe";
            string hjkl = ExeDosyaYolu2;

            Process.Start(hjkl);
            
            this.Close();
        }
        string n0;
        string n1;
        string n2;
        string n3;
        string n4;
        string n5;
        string n0_0;
        string n0_1;
        string n2_0;
        string n2_1;
        string n2_2;
        string n2_0_0;
        string n2_0_1;
        string n2_0_2;
        string n2_2_0;
        string n3_0;
        string n3_1;
        string n3_0_1;
        string n3_0_2;
        string n3_0_3;
        string n3_0_4;
        string n3_0_0;
        string n3_1_0;
        string n3_1_1;
        string n3_1_2;
        string n3_1_3;
        string n3_1_4;
        string n3_1_5;
        string n3_1_6;
        string n3_1_7;
        string n3_1_8;


        private void button2_Click(object sender, EventArgs e)
        {
            string aa = @"C:\ProgramData\SEAPP\" + ne + @"\ÞÝFRE.txt";
            string aaaa = File.ReadAllText(aa);
            FileStream flstrm0 = File.Create(@"C:\ProgramData\SEAPP\mevcut.txt");
            flstrm0.Close();
            File.WriteAllText(@"C:\ProgramData\SEAPP\mevcut.txt", listBox1.SelectedItem.ToString());

            if (textBox1.Text == aaaa)
            {
                string button2sorgu = @"C:\ProgramData\SEAPP\" + ne + @"\KONULAR.txt";


                bool existsorgu = File.Exists(button2sorgu);
                if (existsorgu)
                {

                    Form2 t = new Form2();
                    t.Show();
                    this.Hide();


                }
                else
                {
                    #region uzun
                    n0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\0.txt";
                    n1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\1.txt";
                    n2 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2.txt";
                    n3 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3.txt";
                    n4 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\4.txt";
                    n5 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\5.txt";
                    n0_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\0-0.txt";
                    n0_1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\0-1.txt";
                    n2_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_0.txt";
                    n2_1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_1.txt";
                    n2_2 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_2.txt";
                    n2_0_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_0_0.txt";
                    n2_0_1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_0_1.txt";
                    n2_0_2 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_0_2.txt";
                    n2_2_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\2_2_0.txt";
                    n3_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_0.txt";
                    n3_1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1.txt";
                    n3_0_1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_0_1.txt";
                    n3_0_2 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_0_2.txt";
                    n3_0_3 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_0._3txt";
                    n3_0_4 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_0_4.txt";
                    n3_0_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_0_0.txt";
                    n3_1_0 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_0.txt";
                    n3_1_1 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_1.txt";
                    n3_1_2 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_2.txt";
                    n3_1_3 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_3.txt";
                    n3_1_4 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_4.txt";
                    n3_1_5 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_5.txt";
                    n3_1_6 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_6.txt";
                    n3_1_7 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_7.txt";
                    n3_1_8 = @"C:\ProgramData\SEAPP\" + ne + @"\DERS\3_1_8.txt";
                    FileStream flstrmc = File.Create(@"C:\ProgramData\SEAPP\" + ne + @"\CÝNSÝYET.txt");
                    flstrmc.Close();

                    Directory.CreateDirectory(@"C:\ProgramData\SEAPP\" + ne + @"\DERS");
                    //groupBox1.Hide();
                    FileStream flstrm = File.Create(button2sorgu);
                    flstrm.Close();


                    FileStream flstrm00 = File.Create(n0);
                    flstrm00.Close();
                    FileStream flstrm0_0 = File.Create(n0_0);
                    flstrm0_0.Close();
                    FileStream flstrm0_1 = File.Create(n0_1);
                    flstrm0_1.Close();
                    FileStream flstrm1 = File.Create(n1);
                    flstrm1.Close();
                    FileStream flstrm2 = File.Create(n2);
                    flstrm2.Close();
                    FileStream flstrm2_0 = File.Create(n2_0);
                    flstrm2_0.Close();
                    FileStream flstrm2_1 = File.Create(n2_1);
                    flstrm2_1.Close();
                    FileStream flstrm2_2 = File.Create(n2_2);
                    flstrm2_2.Close();
                    FileStream flstrm2_0_0 = File.Create(n2_0_0);
                    flstrm2_0_0.Close();
                    FileStream flstrm2_0_1 = File.Create(n2_0_1);
                    flstrm2_0_1.Close();
                    FileStream flstrm2_0_2 = File.Create(n2_0_2);
                    flstrm2_0_2.Close();
                    FileStream flstrm2_2_0 = File.Create(n2_2_0);
                    flstrm2_2_0.Close();
                    FileStream flstrm3 = File.Create(n3);
                    flstrm3.Close();
                    FileStream flstrm3_0 = File.Create(n3_0);
                    flstrm3_0.Close();
                    FileStream flstrm3_1 = File.Create(n3_1);
                    flstrm3_1.Close();
                    FileStream flstrm3_0_0 = File.Create(n3_0_0);
                    flstrm3_0_0.Close();
                    FileStream flstrm3_0_1 = File.Create(n3_0_1);
                    flstrm3_0_1.Close();
                    FileStream flstrm3_0_2 = File.Create(n3_0_2);
                    flstrm3_0_2.Close();
                    FileStream flstrm3_0_3 = File.Create(n3_0_3);
                    flstrm3_0_3.Close();
                    FileStream flstrm3_0_4 = File.Create(n3_0_4);
                    flstrm3_0_4.Close();
                    FileStream flstrm3_1_0 = File.Create(n3_1_0);
                    flstrm3_1_0.Close();
                    FileStream flstrm3_1_1 = File.Create(n3_1_1);
                    flstrm3_1_1.Close();
                    FileStream flstrm3_1_2 = File.Create(n3_1_2);
                    flstrm3_1_2.Close();
                    FileStream flstrm3_1_3 = File.Create(n3_1_3);
                    flstrm3_1_3.Close();
                    FileStream flstrm3_1_4 = File.Create(n3_1_4);
                    flstrm3_1_4.Close();
                    FileStream flstrm3_1_5 = File.Create(n3_1_5);
                    flstrm3_1_5.Close();
                    FileStream flstrm3_1_6 = File.Create(n3_1_6);
                    flstrm3_1_6.Close();
                    FileStream flstrm3_1_7 = File.Create(n3_1_7);
                    flstrm3_1_7.Close();
                    FileStream flstrm3_1_8 = File.Create(n3_1_8);
                    flstrm3_1_8.Close();
                    FileStream flstrm4 = File.Create(n4);
                    flstrm4.Close();
                    FileStream flstrm5 = File.Create(n5);
                    flstrm5.Close();
                    //groupBox2.Show();
                    #endregion
                    Form2 t = new Form2();
                    t.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("Þifre Hatalý!Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region uzun
            string radiobuttonsorgu = @"C:\ProgramData\SEAPP\" + ne + @"\CÝNSÝYET.txt";
            if (radioButton1.Checked)
            {
                File.WriteAllText(radiobuttonsorgu, "0");

            }
            if (radioButton2.Checked)
            {
                File.WriteAllText(radiobuttonsorgu, "1");

            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[0].Checked)
            {
                File.WriteAllText(n0, "1");
            }
            else
            {
                File.WriteAllText(n0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[0].Nodes[0].Checked)
            {
                File.WriteAllText(n0_0, "1");
            }
            else
            {
                File.WriteAllText(n0_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[0].Nodes[1].Checked)
            {
                File.WriteAllText(n0_1, "1");
            }
            else
            {
                File.WriteAllText(n0_1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[1].Checked)
            {
                File.WriteAllText(n1, "1");
            }
            else
            {
                File.WriteAllText(n1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Checked)
            {
                File.WriteAllText(n2, "1");
            }
            else
            {
                File.WriteAllText(n2, "0");
            }

            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[0].Checked)
            {
                File.WriteAllText(n2_0, "1");
            }
            else
            {
                File.WriteAllText(n2_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[1].Checked)
            {
                File.WriteAllText(n2_1, "1");
            }
            else
            {
                File.WriteAllText(n2_1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[2].Checked)
            {
                File.WriteAllText(n2_2, "1");
            }
            else
            {
                File.WriteAllText(n2_2, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[0].Nodes[0].Checked)
            {
                File.WriteAllText(n2_0_0, "1");
            }
            else
            {
                File.WriteAllText(n2_0_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[0].Nodes[1].Checked)
            {
                File.WriteAllText(n2_0_1, "1");
            }
            else
            {
                File.WriteAllText(n2_0_1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[0].Nodes[2].Checked)
            {
                File.WriteAllText(n2_0_2, "1");
            }
            else
            {
                File.WriteAllText(n2_0_2, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[2].Nodes[2].Nodes[0].Checked)
            {
                File.WriteAllText(n2_2_0, "1");
            }
            else
            {
                File.WriteAllText(n2_2_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Checked)
            {
                File.WriteAllText(n3, "1");
            }
            else
            {
                File.WriteAllText(n3, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[0].Checked)
            {
                File.WriteAllText(n3_0, "1");
            }
            else
            {
                File.WriteAllText(n3_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Checked)
            {
                File.WriteAllText(n3_1, "1");
            }
            else
            {
                File.WriteAllText(n3_1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[0].Nodes[0].Checked)
            {
                File.WriteAllText(n3_0_0, "1");
            }
            else
            {
                File.WriteAllText(n3_0_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[0].Nodes[1].Checked)
            {
                File.WriteAllText(n3_0_1, "1");
            }
            else
            {
                File.WriteAllText(n3_0_1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[0].Nodes[2].Checked)
            {
                File.WriteAllText(n3_0_2, "1");
            }
            else
            {
                File.WriteAllText(n3_0_2, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[0].Nodes[3].Checked)
            {
                File.WriteAllText(n3_0_3, "1");
            }
            else
            {
                File.WriteAllText(n3_0_3, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[0].Nodes[4].Checked)
            {
                File.WriteAllText(n3_0_4, "1");
            }
            else
            {
                File.WriteAllText(n3_0_4, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[0].Checked)
            {
                File.WriteAllText(n3_1_0, "1");
            }
            else
            {
                File.WriteAllText(n3_1_0, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[1].Checked)
            {
                File.WriteAllText(n3_1_1, "1");
            }
            else
            {
                File.WriteAllText(n3_1_1, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[2].Checked)
            {
                File.WriteAllText(n3_1_2, "1");
            }
            else
            {
                File.WriteAllText(n3_1_2, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[3].Checked)
            {
                File.WriteAllText(n3_1_3, "1");
            }
            else
            {
                File.WriteAllText(n3_1_3, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[4].Checked)
            {
                File.WriteAllText(n3_1_4, "1");
            }
            else
            {
                File.WriteAllText(n3_1_4, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[5].Checked)
            {
                File.WriteAllText(n3_1_5, "1");
            }
            else
            {
                File.WriteAllText(n3_1_5, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[6].Checked)
            {
                File.WriteAllText(n3_1_6, "1");
            }
            else
            {
                File.WriteAllText(n3_1_6, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[7].Checked)
            {
                File.WriteAllText(n3_1_7, "1");
            }
            else
            {
                File.WriteAllText(n3_1_7, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[3].Nodes[1].Nodes[8].Checked)
            {
                File.WriteAllText(n3_1_8, "1");
            }
            else
            {
                File.WriteAllText(n3_1_8, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[4].Checked)
            {
                File.WriteAllText(n4, "1");
            }
            else
            {
                File.WriteAllText(n4, "0");
            }
            //------------------------------------------------------------
            //------------------------------------------------------------
            //------------------------------------------------------------
            if (treeView1.Nodes[5].Checked)
            {
                File.WriteAllText(n5, "1");
            }
            else
            {
                File.WriteAllText(n5, "0");
            }
            #endregion
            FileStream flstrmgün = File.Create(@"C:\ProgramData\SEAPP\" + ne + @"\GÜN.txt");
            flstrmgün.Close();
            int y = (int)numericUpDown1.Value;
            string yy = y.ToString();
            File.WriteAllText(@"C:\ProgramData\SEAPP\" + ne + @"\GÜN.txt", yy);
            FileStream flstrmad = File.Create(@"C:\ProgramData\SEAPP\" + ne + @"\APPAD.txt");
            flstrmad.Close();
            File.WriteAllText(@"C:\ProgramData\SEAPP\" + ne + @"\APPAD.txt", textBox2.Text);
            //Form2 form2 = new Form2();
            MessageBox.Show("asgfhdjf");
            //form2.Show();
            groupBox2.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                File.WriteAllText(@"C:\ProgramData\SEAPP\HATIRLA.txt", "1");



            }
        }
        void fjýedjs()
        {

            this.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}