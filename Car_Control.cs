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
    public partial class Car_Control : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Car_Control()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchcommand = "AdminCarSearch";
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
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@numar", SearchTxt.Text.Trim());
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            CarView.DataSource = table;
            conn.Close();
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ADDCar", conn);
                cmd.Parameters.AddWithValue("@numar", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@marca", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@model", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@putere", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@combustibil", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@IDCategorie", comboBox1.SelectedIndex);
                cmd.Parameters.AddWithValue("@ITP", ITP.Value.Date);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Masina a fost adaugata cu succes in baza de date.");
            }
            catch (Exception )
            {
                MessageBox.Show("Masina nu a putut fi adaugata in baza de date", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand("RemoveCar", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Numar", textBox1.Text.Trim());
                command.ExecuteNonQuery();
                MessageBox.Show("Masina a fost scoasa din baza de date!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Masina nu a fost scoasa din baza de date!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Verificare_ITP", conn);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ITP", ITP.Value.Date);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            CarView.DataSource = table;
            conn.Close();
        }
    }
}
