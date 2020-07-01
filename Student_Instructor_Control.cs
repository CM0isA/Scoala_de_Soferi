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
    public partial class Student_Instructor_Control : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
        public Student_Instructor_Control()
        {
            InitializeComponent();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("TopInstructori", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@mod", comboBox2.SelectedItem);
                sda.SelectCommand.Parameters.AddWithValue("@cat", comboBox1.SelectedIndex);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
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
