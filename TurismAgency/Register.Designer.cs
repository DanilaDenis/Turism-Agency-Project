using System.ComponentModel;

namespace WindowsFormsApp3
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Agency = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(342, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = " return to log in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(223, 64);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(91, 26);
            this.Nume.TabIndex = 2;
            this.Nume.Text = "Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(223, 111);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(92, 29);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Agency
            // 
            this.Agency.Location = new System.Drawing.Point(223, 164);
            this.Agency.Name = "Agency";
            this.Agency.Size = new System.Drawing.Size(96, 33);
            this.Agency.TabIndex = 4;
            this.Agency.Text = "Agency";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(220, 213);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(94, 31);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(359, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(359, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(359, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(220, 263);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(90, 42);
            this.Confirm.TabIndex = 10;
            this.Confirm.Text = "Confirm Password";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(358, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Agency);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Confirm;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Agency;
        private System.Windows.Forms.Label Password;

        #endregion
    }
}