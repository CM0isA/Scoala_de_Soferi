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
    public partial class Student_Cursuri : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Student_Cursuri()
        {
            InitializeComponent();
        }

        private void Vizualizare_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Vizualizare_Lectii", conn);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

        private void Selectare_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Selectare", conn);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ID", textBox1.Text.Trim());
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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
