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
    public partial class Student_Cars : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Student_Cars()
        {
            InitializeComponent();
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("StudentCarSearch", conn);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@mod", comboBox1.SelectedItem);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@combustibil", comboBox2.SelectedItem);

                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
