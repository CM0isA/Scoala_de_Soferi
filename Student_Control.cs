using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Scoala_de_Soferi
{
    public partial class Student_Control : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Student_Control()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchcommand = "StudentSearch";
            try
            {
                FillDataGridView(searchcommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        void FillDataGridView(string searchcommand)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(searchcommand, conn);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nume", SearchTxt.Text.Trim());
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            StudentView.DataSource = table;
            conn.Close();
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ADDStudent", conn);
                cmd.Parameters.AddWithValue("@nume", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@prenume", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@nastere", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@legislatie", 0);
                cmd.Parameters.AddWithValue("@categorie", comboBox1.SelectedIndex);
                cmd.Parameters.AddWithValue("@categorii", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@examen", dateTimePicker2.Value.Date);
                cmd.Parameters.AddWithValue("@lectie", 0);
                cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@CNPI", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@username", textBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@role", "Student");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                conn.Close();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand("RemoveStudent", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CNP", TextBox5.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Studentul nu a putut fi sters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Update1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("StudentEdit", conn);
                cmd.Parameters.AddWithValue("@mod", "data1");
                cmd.Parameters.AddWithValue("@punctaj", 0);
                cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                if (dateTimePicker3.Value.Date > DateTime.Today)
                    cmd.Parameters.AddWithValue("@date", dateTimePicker3.Value.Date);
                else
                    MessageBox.Show("Data selectata nu poate fi mai devreme fata de ziua curenta","Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Data selectata nu poate fi mai devreme fata de ziua curenta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("StudentEdit", conn);
                cmd.Parameters.AddWithValue("@mod", "data2");
                cmd.Parameters.AddWithValue("@punctaj", 0);
                cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                if (dateTimePicker3.Value.Date > DateTime.Today)
                    cmd.Parameters.AddWithValue("@date", dateTimePicker3.Value.Date);
                else
                    MessageBox.Show("Data selectata nu poate fi mai devreme fata de ziua curenta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Data selectata nu poate fi mai devreme fata de ziua curenta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Punctaj_Legislatie_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("StudentEdit", conn);
                cmd.Parameters.AddWithValue("@mod", "pct1");
                cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@punctaj", textBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@date", dateTimePicker3.Value.Date);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Valoarea introdusa pentru punctaj nu este corecta!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Examen_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("StudentEdit", conn);
                cmd.Parameters.AddWithValue("@mod", "pct2");
                cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@punctaj", textBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@date", dateTimePicker3.Value.Date);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Valoarea introdusa pentru punctaj nu este corecta!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
