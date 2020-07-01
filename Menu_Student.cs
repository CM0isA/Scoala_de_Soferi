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
    public partial class Menu_Student : Form
    {
        public Menu_Student()
        {
            InitializeComponent();
        }
        private void Menu_Student_Load(object sender, EventArgs e)
        {
            student_Personal_Control1.Hide();
            student_Instructor_Control1.Hide();
            student_Cars1.Hide();
            student_Cursuri1.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn log = new LogIn();
            log.Show();
        }

        private void Personalbutton_Click(object sender, EventArgs e)
        {
            student_Personal_Control1.Show();
            student_Instructor_Control1.Hide();
            student_Cars1.Hide();
            student_Cursuri1.Hide();            
            student_Personal_Control1.BringToFront();
        }

        private void InstructButton_Click(object sender, EventArgs e)
        {
            student_Personal_Control1.Hide();
            student_Instructor_Control1.Show();
            student_Cars1.Hide();
            student_Cursuri1.Hide();
            student_Instructor_Control1.BringToFront();
        }

        private void CursButton_Click(object sender, EventArgs e)
        {
            student_Personal_Control1.Hide();
            student_Instructor_Control1.Hide();
            student_Cars1.Hide();
            student_Cursuri1.Show();
            student_Cursuri1.BringToFront();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            student_Personal_Control1.Hide();
            student_Instructor_Control1.Hide();
            student_Cars1.Show();
            student_Cursuri1.Hide();
            student_Cars1.BringToFront();
        }
    }
}
