using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralCreditRegisterDataSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileToSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter sr = new StreamWriter(FileToSavePath + "\\" + "CreditRegister.txt", true);
            using (sr)
            {
                sr.WriteLine(this.groupBox1.Text);
                sr.WriteLine(this.label1.Text + " " + this.textBox1.Text);
                sr.WriteLine(this.label2.Text + " " + this.textBox2.Text);
                sr.WriteLine(this.label3.Text + " " + this.textBox3.Text);
                sr.WriteLine(this.label4.Text + " " + this.textBox4.Text);
                sr.WriteLine(this.label5.Text + " " + this.textBox5.Text);
                sr.WriteLine(this.label6.Text + " " + this.textBox6.Text);
                sr.WriteLine(this.label7.Text + " " + this.textBox7.Text);
                sr.WriteLine("---------");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FileToSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter sr = new StreamWriter(FileToSavePath + "\\" + "CreditData.txt", true);
            using (sr)
            {
                sr.WriteLine(this.groupBox2.Text);
                sr.WriteLine(this.label8.Text + " " + this.textBox1.Text);
                sr.WriteLine(this.label9.Text + " " + this.textBox2.Text);
                sr.WriteLine(this.label10.Text + " " + this.textBox3.Text);
                sr.WriteLine(this.label11.Text + " " + this.textBox4.Text);
                sr.WriteLine(this.label12.Text + " " + this.textBox5.Text);
                sr.WriteLine(this.label13.Text + " " + this.textBox6.Text);
                sr.WriteLine("---------");
            }

        }
    }
}
