using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoala_de_Soferi
{

    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn log = new LogIn();
            log.Show();
        }

        private void Menu_Admin_Load(object sender, EventArgs e)
        {
            instruct_Control1.Hide();
            student_Control1.Hide();
            car_Control1.Hide();
            user_Control1.Hide();
            admin_Legislatie1.Hide();
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
            instruct_Control1.Hide();
            student_Control1.Hide();
            car_Control1.Hide();
            admin_Legislatie1.Hide();
            user_Control1.Show();
            user_Control1.BringToFront();
        }

        private void InstructButton_Click(object sender, EventArgs e)
        {
            user_Control1.Hide();
            student_Control1.Hide();
            car_Control1.Hide();
            admin_Legislatie1.Hide();
            instruct_Control1.Show();
            instruct_Control1.BringToFront();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            user_Control1.Hide();
            car_Control1.Hide();
            admin_Legislatie1.Hide();
            instruct_Control1.Hide();
            student_Control1.Show();
            student_Control1.BringToFront();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            instruct_Control1.Hide();
            user_Control1.Hide();
            admin_Legislatie1.Hide();
            student_Control1.Hide();
            car_Control1.Show();
            car_Control1.BringToFront();
        }

        private void Legislatie_Click(object sender, EventArgs e)
        {
            instruct_Control1.Hide();
            user_Control1.Hide();
            admin_Legislatie1.Show();
            student_Control1.Hide();
            car_Control1.Hide();
            admin_Legislatie1.BringToFront();
        }
    }
}
