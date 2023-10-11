namespace Library_Management
{
    partial class ReturnBook
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EnrollmentNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(52, 228);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 34);
            this.button3.TabIndex = 55;
            this.button3.Text = "Search Student";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(11, 197);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(201, 27);
            this.textBox8.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 265);
            this.dataGridView1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(612, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 57;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(540, 370);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 58;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 9, 22, 25, 19, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EnrollmentNo
            // 
            this.EnrollmentNo.AutoSize = true;
            this.EnrollmentNo.Location = new System.Drawing.Point(72, 172);
            this.EnrollmentNo.Name = "EnrollmentNo";
            this.EnrollmentNo.Size = new System.Drawing.Size(70, 13);
            this.EnrollmentNo.TabIndex = 60;
            this.EnrollmentNo.Text = "EnrollmentNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Return Date :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Return Date :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 359);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Return Book";
            this.label3.Visible = false;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnrollmentNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label EnrollmentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}