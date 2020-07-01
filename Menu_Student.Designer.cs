namespace Scoala_de_Soferi
{
    partial class Menu_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CarButton = new System.Windows.Forms.Button();
            this.CursButton = new System.Windows.Forms.Button();
            this.InstructButton = new System.Windows.Forms.Button();
            this.Personalbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.student_Cars1 = new Scoala_de_Soferi.Student_Cars();
            this.student_Cursuri1 = new Scoala_de_Soferi.Student_Cursuri();
            this.student_Instructor_Control1 = new Scoala_de_Soferi.Student_Instructor_Control();
            this.student_Personal_Control1 = new Scoala_de_Soferi.Student_Personal_Control();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 61);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoala de Soferi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.CarButton);
            this.panel2.Controls.Add(this.CursButton);
            this.panel2.Controls.Add(this.InstructButton);
            this.panel2.Controls.Add(this.Personalbutton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 768);
            this.panel2.TabIndex = 1;
            // 
            // CarButton
            // 
            this.CarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarButton.ForeColor = System.Drawing.Color.White;
            this.CarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CarButton.Location = new System.Drawing.Point(0, 211);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(216, 50);
            this.CarButton.TabIndex = 3;
            this.CarButton.TabStop = false;
            this.CarButton.Text = "Masini";
            this.CarButton.UseVisualStyleBackColor = true;
            this.CarButton.Click += new System.EventHandler(this.CarButton_Click);
            // 
            // CursButton
            // 
            this.CursButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CursButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CursButton.ForeColor = System.Drawing.Color.White;
            this.CursButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CursButton.Location = new System.Drawing.Point(0, 161);
            this.CursButton.Name = "CursButton";
            this.CursButton.Size = new System.Drawing.Size(216, 50);
            this.CursButton.TabIndex = 4;
            this.CursButton.TabStop = false;
            this.CursButton.Text = "Cursuri Legislatie";
            this.CursButton.UseVisualStyleBackColor = true;
            this.CursButton.Click += new System.EventHandler(this.CursButton_Click);
            // 
            // InstructButton
            // 
            this.InstructButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InstructButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructButton.ForeColor = System.Drawing.Color.White;
            this.InstructButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InstructButton.Location = new System.Drawing.Point(0, 111);
            this.InstructButton.Name = "InstructButton";
            this.InstructButton.Size = new System.Drawing.Size(216, 50);
            this.InstructButton.TabIndex = 5;
            this.InstructButton.TabStop = false;
            this.InstructButton.Text = "Instructori";
            this.InstructButton.UseVisualStyleBackColor = true;
            this.InstructButton.Click += new System.EventHandler(this.InstructButton_Click);
            // 
            // Personalbutton
            // 
            this.Personalbutton.AllowDrop = true;
            this.Personalbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Personalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personalbutton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personalbutton.ForeColor = System.Drawing.Color.White;
            this.Personalbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Personalbutton.Location = new System.Drawing.Point(0, 61);
            this.Personalbutton.Name = "Personalbutton";
            this.Personalbutton.Size = new System.Drawing.Size(216, 50);
            this.Personalbutton.TabIndex = 6;
            this.Personalbutton.TabStop = false;
            this.Personalbutton.Text = "Personal";
            this.Personalbutton.UseVisualStyleBackColor = false;
            this.Personalbutton.Click += new System.EventHandler(this.Personalbutton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(216, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 61);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1098, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // student_Cars1
            // 
            this.student_Cars1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.student_Cars1.Location = new System.Drawing.Point(216, 61);
            this.student_Cars1.Name = "student_Cars1";
            this.student_Cars1.Size = new System.Drawing.Size(1150, 707);
            this.student_Cars1.TabIndex = 8;
            // 
            // student_Cursuri1
            // 
            this.student_Cursuri1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.student_Cursuri1.Location = new System.Drawing.Point(216, 61);
            this.student_Cursuri1.Name = "student_Cursuri1";
            this.student_Cursuri1.Size = new System.Drawing.Size(1150, 707);
            this.student_Cursuri1.TabIndex = 7;
            // 
            // student_Instructor_Control1
            // 
            this.student_Instructor_Control1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.student_Instructor_Control1.Location = new System.Drawing.Point(216, 61);
            this.student_Instructor_Control1.Name = "student_Instructor_Control1";
            this.student_Instructor_Control1.Size = new System.Drawing.Size(1150, 707);
            this.student_Instructor_Control1.TabIndex = 5;
            // 
            // student_Personal_Control1
            // 
            this.student_Personal_Control1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.student_Personal_Control1.Location = new System.Drawing.Point(216, 61);
            this.student_Personal_Control1.Name = "student_Personal_Control1";
            this.student_Personal_Control1.Size = new System.Drawing.Size(1150, 707);
            this.student_Personal_Control1.TabIndex = 3;
            // 
            // Menu_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.student_Cars1);
            this.Controls.Add(this.student_Cursuri1);
            this.Controls.Add(this.student_Instructor_Control1);
            this.Controls.Add(this.student_Personal_Control1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Student";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Menu_Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CarButton;
        private System.Windows.Forms.Button CursButton;
        private System.Windows.Forms.Button InstructButton;
        private System.Windows.Forms.Button Personalbutton;
        private Student_Personal_Control student_Personal_Control1;
        private Student_Instructor_Control student_Instructor_Control1;
        private Student_Cursuri student_Cursuri1;
        private Student_Cars student_Cars1;
    }
}