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
    public partial class AdminExamsTable : Form
    {
        public AdminExamsTable()
        {
            InitializeComponent();

        }

        private void FillAdminExamsGrid()
        {
            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Exams", con);

            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        DataTable ExTable = new DataTable();
                        ExTable.Load(reader);
                        this.AdminExamGrid.DataSource = ExTable;
                    }
                }
            }
        }
        private void AdminExamsTable_Load(object sender, EventArgs e)
        {
            FillAdminExamsGrid();
        }

        private void DeleteExamButton_Click(object sender, EventArgs e)
        {
            //Getting selected row data
            DateTime CurrentDate = (DateTime)AdminExamGrid.CurrentRow.Cells[0].Value;
            string CurrentDateStr = CurrentDate.ToString("yyyy-MM-dd");
            string CurrentStudent = AdminExamGrid.CurrentRow.Cells[1].Value.ToString();
            string CurrentProfessor = AdminExamGrid.CurrentRow.Cells[2].Value.ToString();

            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);

            //Delete selected row from database and reload the grid
            SqlCommand cmd = new SqlCommand("DELETE FROM Exams WHERE ExamDate = @ExDate AND StudentID = @StID AND ProfessorID = @PrID", con);
            cmd.Parameters.AddWithValue("@ExDate", CurrentDateStr);
            cmd.Parameters.AddWithValue("@StID", CurrentStudent);
            cmd.Parameters.AddWithValue("@PrID", CurrentProfessor);
            con.Open();

            using (con)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Записът е успешно изтрит");
                    FillAdminExamsGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }   
            }
        }

        private void ExamUpdateButton_Click(object sender, EventArgs e)
        {
            //Getting selected row data
            DateTime CurrentDate = (DateTime)AdminExamGrid.CurrentRow.Cells[0].Value;
            string CurrentDateStr = CurrentDate.ToString("yyyy-MM-dd");
            string CurrentStudent = AdminExamGrid.CurrentRow.Cells[1].Value.ToString();
            string CurrentProfessor = AdminExamGrid.CurrentRow.Cells[2].Value.ToString();
            string CurrentGrade = AdminExamGrid.CurrentRow.Cells[3].Value.ToString();

            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);

            // Update current row from database and reload the grid
            SqlCommand cmd = new SqlCommand("UPDATE Exams SET Grade = @StGrade WHERE ExamDate = @ExDate AND StudentID = @StID AND ProfessorID = @PrID", con);
            cmd.Parameters.AddWithValue("@ExDate", CurrentDateStr);
            cmd.Parameters.AddWithValue("@StID", CurrentStudent);
            cmd.Parameters.AddWithValue("@PrID", CurrentProfessor);
            cmd.Parameters.AddWithValue("@StGrade", CurrentGrade);
            con.Open();

            using (con)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Промените бяха направени успешно !");
                    FillAdminExamsGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невалидни данни за обновяване !");
                }


            }
        }

        private void ExamInsertButton_Click(object sender, EventArgs e)
        {
            //Getting selected row data
            DateTime CurrentDate = (DateTime)AdminExamGrid.CurrentRow.Cells[0].Value;
            string CurrentDateStr = CurrentDate.ToString("yyyy-MM-dd");
            string CurrentStudent = AdminExamGrid.CurrentRow.Cells[1].Value.ToString();
            string CurrentProfessor = AdminExamGrid.CurrentRow.Cells[2].Value.ToString();
            string CurrentGrade = AdminExamGrid.CurrentRow.Cells[3].Value.ToString();

            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);

            //Insert selected row data in Database and reload the grid
            SqlCommand cmd = new SqlCommand("INSERT INTO Exams VALUES (@ExDate, @StID, @PrID, @StGrade)", con);
            cmd.Parameters.AddWithValue("@ExDate", CurrentDateStr);
            cmd.Parameters.AddWithValue("@StID", CurrentStudent);
            cmd.Parameters.AddWithValue("@PrID", CurrentProfessor);
            cmd.Parameters.AddWithValue("@StGrade", CurrentGrade);
            con.Open();

            using (con)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Записът е добавен успешно");
                    FillAdminExamsGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невалиден запис за добавяне !");
                }


            }
        }

        private void ExamSearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Settings.Default.Student_SystemConnectionString);
            
            string SearchCommand = "SELECT * FROM Exams ";
            SqlCommand cmd = new SqlCommand(SearchCommand, con);

            if (this.StudentCheck.Checked && this.ProfessorCheck.Checked)
            {
                SearchCommand += "WHERE StudentID = @StID AND ProfessorID = @PrID";
                cmd = new SqlCommand(SearchCommand, con);
                cmd.Parameters.AddWithValue("@StID", this.SearchByStudentBox.Text);
                cmd.Parameters.AddWithValue("@PrID", this.SearchByProfessorBox.Text);
            }
            else
            {
                if (this.StudentCheck.Checked)
                {
                    SearchCommand += "WHERE StudentID = @StID";
                    cmd = new SqlCommand(SearchCommand, con);
                    cmd.Parameters.AddWithValue("@StID", this.SearchByStudentBox.Text);
                }

                if (this.ProfessorCheck.Checked)
                {
                    SearchCommand += "WHERE ProfessorID = @PrID";
                    cmd = new SqlCommand(SearchCommand, con);
                    cmd.Parameters.AddWithValue("@PrID", this.SearchByProfessorBox.Text);
                }
            }

            con.Open();
            using (con)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        DataTable ExTable = new DataTable();
                        ExTable.Load(reader);
                        this.AdminExamGrid.DataSource = ExTable;
                    }
                }
            }
            

        }

    }
}
