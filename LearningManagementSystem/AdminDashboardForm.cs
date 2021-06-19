using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        private Color color;
        public AdminDashboardForm()
        {
            InitializeComponent();
            color = Color.FromArgb(color.A, 0, 150, 136);
            activate(homeBtn);

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            activate(sender); 
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void activate(object sender)
        {
            if (sender.GetType() == typeof(Button))
            {
                //panelTitleBar.BackColor = color;
                panelLogo.BackColor = Color.FromArgb(color.A, 231, 123, 0);
                panelLogo.ForeColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                button5.ForeColor = Color.FromArgb(color.A, 231, 123, 0);
                panel1.BackColor = Color.FromArgb(color.A, 231, 123, 0);

                tempButton.ForeColor = ThemeColor.ChangeColorBrightness(color, -.3);
                panelBar.Top = ((Button)sender).Top;
                panelBar.Height = ((Button)sender).Height;
            }
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            activate(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activate(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activate(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activate(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activate(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activate(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
