using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button[] b = new Button[16];
        public Form1()
        {
            InitializeComponent();
            b[0] = b1;
            b[1] = b2;
            b[2] = b3;
            b[3] = b4;
            b[4] = b5; 
            b[5] = b6;
            b[6] = b7;
            b[7] = b8;
            b[8] = b9;
            b[9] = b10;
            b[10] = b11;
            b[11] = b12;
            b[12] = b13;
            b[13] = b14;
            b[14] = b15;
            b[15] = b16;
            iniciaBoton();
        }
        public void iniciaBoton()
        {
            for (int i = 0; i < 16; i++)
            {
                if (i==15)
                    b[i].Text = "";
                else
                    b[i].Text = (i + 1) + "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b16 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.b16);
            this.groupBox1.Controls.Add(this.b15);
            this.groupBox1.Controls.Add(this.b14);
            this.groupBox1.Controls.Add(this.b13);
            this.groupBox1.Controls.Add(this.b12);
            this.groupBox1.Controls.Add(this.b11);
            this.groupBox1.Controls.Add(this.b10);
            this.groupBox1.Controls.Add(this.b9);
            this.groupBox1.Controls.Add(this.b8);
            this.groupBox1.Controls.Add(this.b7);
            this.groupBox1.Controls.Add(this.b6);
            this.groupBox1.Controls.Add(this.b5);
            this.groupBox1.Controls.Add(this.b4);
            this.groupBox1.Controls.Add(this.b3);
            this.groupBox1.Controls.Add(this.b2);
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // b16
            // 
            this.b16.BackColor = System.Drawing.Color.MediumPurple;
            this.b16.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b16.Location = new System.Drawing.Point(302, 278);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(75, 75);
            this.b16.TabIndex = 15;
            this.b16.Text = "___";
            this.b16.UseVisualStyleBackColor = false;
            this.b16.Click += new System.EventHandler(this.b16_Click);
            // 
            // b15
            // 
            this.b15.BackColor = System.Drawing.Color.MediumPurple;
            this.b15.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b15.Location = new System.Drawing.Point(221, 278);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(75, 75);
            this.b15.TabIndex = 14;
            this.b15.Text = "15";
            this.b15.UseVisualStyleBackColor = false;
            this.b15.Click += new System.EventHandler(this.b15_Click);
            // 
            // b14
            // 
            this.b14.BackColor = System.Drawing.Color.MediumPurple;
            this.b14.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b14.Location = new System.Drawing.Point(129, 278);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(75, 75);
            this.b14.TabIndex = 13;
            this.b14.Text = "14";
            this.b14.UseVisualStyleBackColor = false;
            this.b14.Click += new System.EventHandler(this.b14_Click);
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.MediumPurple;
            this.b13.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b13.Location = new System.Drawing.Point(30, 278);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(75, 75);
            this.b13.TabIndex = 12;
            this.b13.Text = "13";
            this.b13.UseVisualStyleBackColor = false;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.MediumPurple;
            this.b12.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b12.Location = new System.Drawing.Point(302, 197);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(75, 75);
            this.b12.TabIndex = 11;
            this.b12.Text = "12";
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.MediumPurple;
            this.b11.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b11.Location = new System.Drawing.Point(221, 197);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(75, 75);
            this.b11.TabIndex = 10;
            this.b11.Text = "11";
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.MediumPurple;
            this.b10.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b10.Location = new System.Drawing.Point(129, 197);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(75, 75);
            this.b10.TabIndex = 9;
            this.b10.Text = "10";
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.MediumPurple;
            this.b9.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b9.Location = new System.Drawing.Point(30, 197);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 75);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.MediumPurple;
            this.b8.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b8.Location = new System.Drawing.Point(302, 116);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 75);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.MediumPurple;
            this.b7.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b7.Location = new System.Drawing.Point(221, 116);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 75);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.MediumPurple;
            this.b6.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b6.Location = new System.Drawing.Point(129, 116);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 75);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.MediumPurple;
            this.b5.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b5.Location = new System.Drawing.Point(30, 116);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 75);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.MediumPurple;
            this.b4.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b4.Location = new System.Drawing.Point(302, 32);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 75);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.MediumPurple;
            this.b3.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b3.Location = new System.Drawing.Point(221, 32);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.MediumPurple;
            this.b2.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b2.Location = new System.Drawing.Point(129, 32);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.MediumPurple;
            this.b1.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.b1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b1.Location = new System.Drawing.Point(30, 32);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(436, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void b15_Click(object sender, EventArgs e)
        {
            if (b14.Text.Equals(""))
            {
                b14.Text = b15.Text;
                b15.Text = "";
            }
            if (b11.Text.Equals(""))
            {
                b11.Text = b15.Text;
                b15.Text = "";
            }
            if (b16.Text.Equals(""))
            {
                b16.Text = b15.Text;
                b15.Text = "";
            }
        }

        private void b16_Click(object sender, EventArgs e)
        {
            if (b12.Text.Equals(""))
            {
                b12.Text = b16.Text;
                b16.Text = "";
            }
            if (b15.Text.Equals(""))
            {
                b15.Text = b16.Text;
                b16.Text = "";
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (b10.Text.Equals(""))
            {
                b10.Text = b11.Text;
                b11.Text = "";
            }
            if (b7.Text.Equals(""))
            {
                b7.Text = b11.Text;
                b11.Text = "";
            }
            if (b12.Text.Equals(""))
            {
                b12.Text = b11.Text;
                b11.Text = "";
            }
            if (b15.Text.Equals(""))
            {
                b15.Text = b11.Text;
                b11.Text = "";
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b11.Text.Equals(""))
            {
                b11.Text = b12.Text;
                b12.Text = "";
            }
            if (b16.Text.Equals(""))
            {
                b16.Text = b12.Text;
                b12.Text = "";
            }
            if (b4.Text.Equals(""))
            {
                b4.Text = b12.Text;
                b12.Text = "";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b12.Text.Equals(""))
            {
                b12.Text = b8.Text;
                b8.Text = "";
            }
            if (b7.Text.Equals(""))
            {
                b7.Text = b8.Text;
                b8.Text = "";
            }
            if (b4.Text.Equals(""))
            {
                b4.Text = b8.Text;
                b8.Text = "";
            }

        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b8.Text.Equals(""))
            {
                b8.Text = b7.Text;
                b7.Text = "";
            }
            if (b6.Text.Equals(""))
            {
                b6.Text = b7.Text;
                b7.Text = "";
            }
            if (b3.Text.Equals(""))
            {
                b3.Text = b7.Text;
                b7.Text = "";
            }
            if (b11.Text.Equals(""))
            {
                b11.Text = b7.Text;
                b7.Text = "";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b3.Text.Equals(""))
            {
                b3.Text = b4.Text;
                b4.Text = "";
            }
            if (b8.Text.Equals(""))
            {
                b8.Text = b4.Text;
                b4.Text = "";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b7.Text.Equals(""))
            {
                b7.Text = b3.Text;
                b3.Text = "";
            }
            if (b4.Text.Equals(""))
            {
                b4.Text = b3.Text;
                b3.Text = "";
            }
            if (b2.Text.Equals(""))
            {
                b2.Text = b3.Text;
                b3.Text = "";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b1.Text.Equals(""))
            {
                b1.Text = b2.Text;
                b2.Text = "";
            }
            if (b3.Text.Equals(""))
            {
                b3.Text = b2.Text;
                b2.Text = "";
            }
            if (b6.Text.Equals(""))
            {
                b6.Text = b2.Text;
                b2.Text = "";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b2.Text.Equals(""))
            {
                b2.Text = b1.Text;
                b1.Text = "";
            }
            if (b5.Text.Equals(""))
            {
                b5.Text = b1.Text;
                b1.Text = "";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b1.Text.Equals(""))
            {
                b1.Text = b5.Text;
                b5.Text = "";
            }
            if (b6.Text.Equals(""))
            {
                b6.Text = b5.Text;
                b5.Text = "";
            }
            if (b9.Text.Equals(""))
            {
                b9.Text = b5.Text;
                b5.Text = "";
            }

        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b2.Text.Equals(""))
            {
                b2.Text = b6.Text;
                b6.Text = "";
            }
            if (b5.Text.Equals(""))
            {
                b5.Text = b6.Text;
                b6.Text = "";
            }
            if (b7.Text.Equals(""))
            {
                b7.Text = b6.Text;
                b6.Text = "";
            }
            if (b10.Text.Equals(""))
            {
                b10.Text = b6.Text;
                b6.Text = "";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b5.Text.Equals(""))
            {
                b5.Text = b9.Text;
                b9.Text = "";
            }
            if (b10.Text.Equals(""))
            {
                b10.Text = b9.Text;
                b9.Text = "";
            }
            if (b13.Text.Equals(""))
            {
                b13.Text = b9.Text;
                b9.Text = "";
            }
        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (b6.Text.Equals(""))
            {
                b6.Text = b10.Text;
                b10.Text = "";
            }
            if (b14.Text.Equals(""))
            {
                b14.Text = b10.Text;
                b10.Text = "";
            }
            if (b9.Text.Equals(""))
            {
                b9.Text = b10.Text;
                b10.Text = "";
            }
            if (b11.Text.Equals(""))
            {
                b11.Text = b10.Text;
                b10.Text = "";
            }

        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (b9.Text.Equals(""))
            {
                b9.Text = b13.Text;
                b13.Text = "";
            }
            if (b14.Text.Equals(""))
            {
                b14.Text = b13.Text;
                b13.Text = "";
            }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (b15.Text.Equals(""))
            {
                b15.Text = b14.Text;
                b14.Text = "";
            }
            if (b13.Text.Equals(""))
            {
                b13.Text = b14.Text;
                b14.Text = "";
            }
            if (b10.Text.Equals(""))
            {
                b10.Text = b14.Text;
                b14.Text = "";
            }
        }
    }
}
