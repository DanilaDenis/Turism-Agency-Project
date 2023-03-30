namespace WindowsFormsApp3
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.leave1 = new System.Windows.Forms.TextBox();
            this.leave2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trip = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.tickets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id, this.objective, this.transportFirm, this.leave, this.availableTickets, this.price });
            this.dataGridView1.Location = new System.Drawing.Point(301, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // objective
            // 
            this.objective.HeaderText = "objective";
            this.objective.Name = "objective";
            this.objective.ReadOnly = true;
            // 
            // transportFirm
            // 
            this.transportFirm.HeaderText = "transportFirm";
            this.transportFirm.Name = "transportFirm";
            this.transportFirm.ReadOnly = true;
            // 
            // leave
            // 
            this.leave.HeaderText = "leave";
            this.leave.Name = "leave";
            this.leave.ReadOnly = true;
            // 
            // availableTickets
            // 
            this.availableTickets.HeaderText = "availableTickets";
            this.availableTickets.Name = "availableTickets";
            this.availableTickets.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = " Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Book Trip";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search Trip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // leave1
            // 
            this.leave1.Location = new System.Drawing.Point(133, 66);
            this.leave1.Name = "leave1";
            this.leave1.Size = new System.Drawing.Size(49, 22);
            this.leave1.TabIndex = 5;
            // 
            // leave2
            // 
            this.leave2.Location = new System.Drawing.Point(233, 66);
            this.leave2.Name = "leave2";
            this.leave2.Size = new System.Drawing.Size(44, 22);
            this.leave2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(188, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "and";
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(556, 308);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(66, 22);
            this.Client.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Leave between";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Objective";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column4, this.Column5 });
            this.dataGridView2.Location = new System.Drawing.Point(12, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(280, 173);
            this.dataGridView2.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Objective";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Transport Firm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Leave";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Available Tickets";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(488, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Client name";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(649, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telephone number";
            // 
            // trip
            // 
            this.trip.Location = new System.Drawing.Point(556, 350);
            this.trip.Name = "trip";
            this.trip.Size = new System.Drawing.Size(66, 22);
            this.trip.TabIndex = 14;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(756, 308);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(90, 22);
            this.telephone.TabIndex = 15;
            // 
            // tickets
            // 
            this.tickets.Location = new System.Drawing.Point(756, 350);
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(90, 22);
            this.tickets.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(488, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trip ID";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(649, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tickets";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(699, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 54);
            this.button4.TabIndex = 19;
            this.button4.Text = "View bookings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tickets);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.trip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leave2);
            this.Controls.Add(this.leave1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.DataGridViewTextBoxColumn id;

        private System.Windows.Forms.TextBox trip;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox tickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

        private System.Windows.Forms.DataGridViewTextBoxColumn objective;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;

        private System.Windows.Forms.DataGridView dataGridView2;

        private System.Windows.Forms.TextBox leave1;
        private System.Windows.Forms.TextBox leave2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}