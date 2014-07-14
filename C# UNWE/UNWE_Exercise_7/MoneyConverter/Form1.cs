using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            try
            {
                sum = decimal.Parse((textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Моля въведете коректна стойност за Сума !");
                Clear();
            }
            
            switch (comboBox1.SelectedIndex)
            {
                case 0: textBox2.Text = Math.Round(sum, 2).ToString();
                    textBox3.Text = Math.Round(sum * 0.5114m,2).ToString();
                    textBox4.Text = Math.Round(sum * 0.7036m,2).ToString();
                    textBox5.Text = Math.Round(sum * 0.4175m,2).ToString(); break;
                case 1: textBox2.Text = Math.Round(sum * 1.9554m,2).ToString();
                    textBox3.Text = Math.Round(sum,2).ToString();
                    textBox4.Text = Math.Round(sum * 1.3759m,2).ToString();
                    textBox5.Text = Math.Round(sum * 0.8165m,2).ToString(); break;
                case 2: textBox2.Text = Math.Round(sum * 1.4212m,2).ToString();
                    textBox3.Text = Math.Round(sum * 0.7268m,2).ToString();
                    textBox4.Text = Math.Round(sum).ToString();
                    textBox5.Text = Math.Round(sum * 0.5934m,2).ToString(); break;
                case 3: textBox2.Text = Math.Round(sum * 2.3949m,2).ToString();
                    textBox3.Text = Math.Round(sum * 1.2248m,2).ToString();
                    textBox4.Text = Math.Round(sum * 1.6852m,2).ToString();
                    textBox5.Text = Math.Round(sum,2).ToString(); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        
    }
}
