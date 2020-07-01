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
    public partial class Instruct_Control : UserControl
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Instruct_Control()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                conn.Open();
                SqlCommand cmd = new SqlCommand("ADDInstructor", conn);
                cmd.Parameters.AddWithValue("@nume", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@prenume", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@CNP", textBox3.Text.Trim() );
                cmd.Parameters.AddWithValue("@nastere", Nastere.Value.Date);
                cmd.Parameters.AddWithValue("@angajare", Angajare.Value.Date);
                cmd.Parameters.AddWithValue("@Sex", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@IDCategorie", comboBox1.SelectedIndex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@role", "Admin");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "FAIL");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail", ex.Message);
            }
        }

        void FillDataGridView()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("InstructSearch", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@nume", textBox6.Text.Trim());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand("RemoveInstructor", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CNP", textBox3.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu mere", ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
