using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Scoala_de_Soferi
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVS4RR7\SQL_SERVER;Initial Catalog=Scoala;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LogIn WHERE username='" + textBox1.Text + "'AND password='" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM LogIn WHERE username='" + textBox1.Text + "'AND password='" + textBox2.Text + "'", conn);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);



                if (dt.Rows[0][0].ToString() != "0")
                {

                    this.Hide();
                    if (dt2.Rows[0][2].ToString() == "Admin")
                    {
                        Menu_Admin admin = new Menu_Admin();
                        admin.Show();
                    }
                    else
                    {
                        Menu_Student mn = new Menu_Student();
                        mn.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Username does not exist", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Serverul nu este activ",ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
