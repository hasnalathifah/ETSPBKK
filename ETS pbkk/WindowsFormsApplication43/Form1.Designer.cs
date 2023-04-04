namespace WindowsFormsApplication43
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtmaxtemp = new System.Windows.Forms.TextBox();
            this.txtmintemp = new System.Windows.Forms.TextBox();
            this.txtwindm = new System.Windows.Forms.TextBox();
            this.txtwindk = new System.Windows.Forms.TextBox();
            this.txthumidity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max temp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min temp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wind Speed mph";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wind Speed kph";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(87, 20);
            this.txtcity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(226, 21);
            this.txtcity.TabIndex = 7;
            // 
            // txtmaxtemp
            // 
            this.txtmaxtemp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtmaxtemp.Location = new System.Drawing.Point(210, 106);
            this.txtmaxtemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaxtemp.Name = "txtmaxtemp";
            this.txtmaxtemp.Size = new System.Drawing.Size(103, 21);
            this.txtmaxtemp.TabIndex = 8;
            // 
            // txtmintemp
            // 
            this.txtmintemp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtmintemp.Location = new System.Drawing.Point(210, 151);
            this.txtmintemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmintemp.Name = "txtmintemp";
            this.txtmintemp.Size = new System.Drawing.Size(103, 21);
            this.txtmintemp.TabIndex = 9;
            // 
            // txtwindm
            // 
            this.txtwindm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtwindm.Location = new System.Drawing.Point(640, 103);
            this.txtwindm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtwindm.Name = "txtwindm";
            this.txtwindm.Size = new System.Drawing.Size(103, 21);
            this.txtwindm.TabIndex = 10;
            // 
            // txtwindk
            // 
            this.txtwindk.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtwindk.Location = new System.Drawing.Point(640, 145);
            this.txtwindk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtwindk.Name = "txtwindk";
            this.txtwindk.Size = new System.Drawing.Size(103, 21);
            this.txtwindk.TabIndex = 11;
            // 
            // txthumidity
            // 
            this.txthumidity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txthumidity.Location = new System.Drawing.Point(640, 197);
            this.txthumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthumidity.Name = "txthumidity";
            this.txthumidity.Size = new System.Drawing.Size(103, 21);
            this.txthumidity.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 254);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 98);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cloud";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 238);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Show weather forecast for a week";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcountry
            // 
            this.txtcountry.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtcountry.Location = new System.Drawing.Point(561, 19);
            this.txtcountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(213, 21);
            this.txtcountry.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "o";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "o";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(864, 630);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txthumidity);
            this.Controls.Add(this.txtwindk);
            this.Controls.Add(this.txtwindm);
            this.Controls.Add(this.txtmintemp);
            this.Controls.Add(this.txtmaxtemp);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtmaxtemp;
        private System.Windows.Forms.TextBox txtmintemp;
        private System.Windows.Forms.TextBox txtwindm;
        private System.Windows.Forms.TextBox txtwindk;
        private System.Windows.Forms.TextBox txthumidity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

