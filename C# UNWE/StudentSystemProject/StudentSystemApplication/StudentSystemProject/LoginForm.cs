using StudentSystemProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);

            //Check student ID and Password
            SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Students WHERE StudentID = @studentID AND StPassword = @stPassword", con);
            string fnumber = this.FNumberTextBox.Text;
            string pass = this.PassTextBox.Text;

            cmd.Parameters.AddWithValue("@studentID", fnumber);
            cmd.Parameters.AddWithValue("@stPassword", pass);
            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        //Hiding this form and creating and showing next
                        StudentBasicData studentForm = new StudentBasicData();
                        studentForm.SetFacultyNumber = this.FNumberTextBox.Text;
                        studentForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Грешен факултетен номер и/или парола !");
                    }

                }

            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterAdminButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLog = new AdminLogin();
            adminLog.Show();
            this.Hide();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Check connection
            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се установи връзна с базата данни !\n" + ex.Message);
                this.Close();
            }
        }
    }
}

