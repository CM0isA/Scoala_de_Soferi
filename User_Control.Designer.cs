namespace Scoala_de_Soferi
{
    partial class User_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewPassword = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserView = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.NewRole = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            this.OperationsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(134, 287);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(197, 52);
            this.NewPassword.TabIndex = 0;
            this.NewPassword.TabStop = false;
            this.NewPassword.Text = "Schimbare parola";
            this.NewPassword.UseVisualStyleBackColor = true;
            this.NewPassword.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(134, 403);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 52);
            this.Delete.TabIndex = 0;
            this.Delete.TabStop = false;
            this.Delete.Text = "Stergere Utilizator";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 1;
            // 
            // UserView
            // 
            this.UserView.AllowUserToAddRows = false;
            this.UserView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.UserView.Location = new System.Drawing.Point(362, 83);
            this.UserView.Name = "UserView";
            this.UserView.ReadOnly = true;
            this.UserView.Size = new System.Drawing.Size(788, 624);
            this.UserView.TabIndex = 4;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(224, 37);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(300, 20);
            this.SearchTxt.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(530, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.comboBox1);
            this.OperationsPanel.Controls.Add(this.panel1);
            this.OperationsPanel.Controls.Add(this.NewRole);
            this.OperationsPanel.Controls.Add(this.NewPassword);
            this.OperationsPanel.Controls.Add(this.textBox2);
            this.OperationsPanel.Controls.Add(this.Delete);
            this.OperationsPanel.Controls.Add(this.label1);
            this.OperationsPanel.Controls.Add(this.textBox1);
            this.OperationsPanel.Controls.Add(this.label2);
            this.OperationsPanel.Controls.Add(this.label3);
            this.OperationsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OperationsPanel.Location = new System.Drawing.Point(0, 0);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(361, 707);
            this.OperationsPanel.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(165, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 85);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(55, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Operations";
            // 
            // NewRole
            // 
            this.NewRole.Location = new System.Drawing.Point(134, 345);
            this.NewRole.Name = "NewRole";
            this.NewRole.Size = new System.Drawing.Size(197, 52);
            this.NewRole.TabIndex = 0;
            this.NewRole.TabStop = false;
            this.NewRole.Text = "Schimbare Rol";
            this.NewRole.UseVisualStyleBackColor = true;
            this.NewRole.Click += new System.EventHandler(this.NewRole_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.label4);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTxt);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(361, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(789, 83);
            this.SearchPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(41, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Username:";
            // 
            // User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.UserView);
            this.Name = "User_Control";
            this.Size = new System.Drawing.Size(1150, 707);
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            this.OperationsPanel.ResumeLayout(false);
            this.OperationsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewPassword;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView UserView;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel OperationsPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewRole;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
