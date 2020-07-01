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
    
    public partial class Admin_Legislatie : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Admin_Legislatie()
        {
            InitializeComponent();
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LessonAdd", conn);
                cmd.Parameters.AddWithValue("@nume", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Durata", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Programare", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Lectie", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@CNP", textBox3.Text.Trim());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
                MessageBox.Show("Lectia nu a putut fi adaugata", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("LessonRemove", conn);
                cmd.Parameters.AddWithValue("@ID", textBox4.Text.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Numarul lectiei este invalid", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("LessonUpdate", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@ID", textBox4.Text.Trim());
                sda.SelectCommand.Parameters.AddWithValue("@Lectie", textBox3.Text);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conn.Close();

            }
            catch (Exception upd)
            {
                MessageBox.Show(upd.Message, "Error Message");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Search(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SearchLesson", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@denumire", textBox1.Text.Trim());
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conn.Close();

            }
            catch (Exception upd)
            {
                MessageBox.Show(upd.Message, "Error Message");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("LessonProgram", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@ID", textBox4.Text.Trim());
                sda.SelectCommand.Parameters.AddWithValue("@program", dateTimePicker1.Value.Date);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conn.Close();

            }
            catch (Exception upd)
            {
                MessageBox.Show(upd.Message, "Error Message");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
