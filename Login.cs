using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Laboratory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.Shown += (s, e) => this.ActiveControl = label2;

            textBox2.Text = "Username";
            textBox2.ForeColor = Color.Gray;

            textBox2.GotFocus += (s, ev) =>
            {
                if (textBox2.Text == "Username")
                {
                    textBox2.Text = "";
                    textBox2.ForeColor = Color.Black;
                }
            };
            textBox2.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    textBox2.Text = "Username";
                    textBox2.ForeColor = Color.Gray;
                }
            };

            // Startup
            textBox1.Text = "Password";
            textBox1.ForeColor = Color.Gray;
            textBox1.UseSystemPasswordChar = false; 

            // Enter event and mask
            textBox1.Enter += (s, ev) =>
            {
                if (textBox1.Text == "Password" && textBox1.ForeColor == Color.Gray)
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.Black;

                    textBox1.UseSystemPasswordChar = true;
                }
            };
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CenterPanel(panel2);
        }
        private void CenterPanel(Panel pnl)
        {
            pnl.Left = (this.ClientSize.Width - pnl.Width) / 2;
            pnl.Top = (this.ClientSize.Height - pnl.Height) / 2;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterPanel(panel2);
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left
            path.AddArc(panel2.Width - radius, 0, radius, radius, 270, 90); // top-right
            path.AddArc(panel2.Width - radius, panel2.Height - radius, radius, radius, 0, 90); // bottom-right
            path.AddArc(0, panel2.Height - radius, radius, radius, 90, 90); // bottom-left
            path.CloseFigure();

            panel2.Region = new Region(path);

            // Draw background image inside the rounded region
            if (panel2.BackgroundImage != null)
            {
                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(panel2.BackgroundImage, panel2.ClientRectangle);
                e.Graphics.ResetClip();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            CenterPanel(panel2);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CenterPanel(panel2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }      

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CenterPanel(panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CenterPanel(panel2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            CenterPanel(panel2);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
