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
    public partial class User_Control : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public User_Control()
        {
            InitializeComponent();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand Cmd = new SqlCommand("AdminEdit", conn);
                Cmd.Parameters.AddWithValue("@mode", "Update");
                Cmd.Parameters.AddWithValue("@change", "password");
                Cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                Cmd.Parameters.AddWithValue("@role", comboBox1.Text);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfull UPDATE");

            }
            catch(Exception upd)
            {
                MessageBox.Show(upd.Message, "Error Message");
            }
            finally
            {
                conn.Close();
            }
        }

        void FillDataGridView()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("UserSearch", conn);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@username",SearchTxt.Text.Trim());
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            UserView.DataSource = table;
            conn.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand sqlCommand = new SqlCommand("RemoveUser", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted");
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something didn't work right", ex.Message);
            }
        }

        private void NewRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand Cmd = new SqlCommand("AdminEdit", conn);
                Cmd.Parameters.AddWithValue("@mode", "Update");
                Cmd.Parameters.AddWithValue("@change", "role");
                Cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                Cmd.Parameters.AddWithValue("@role", comboBox1.Text.Trim());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfull UPDATE");

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
