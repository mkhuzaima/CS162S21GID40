using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningManagementSystem
{
    public partial class LoginForm : Form
    {
        //constructor
        public LoginForm()
        {
            InitializeComponent();
            //round edges
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ///////////////////////////////////////////////////////////////////////////////////
            ///                     temporary (for ease in developement)
            usernameField.Text = "admin@lms.uet.edu.pk";
            passwordField.Text = "Admin123";
            //////////////////////////////////////////////////////////////////////////////////
        }

        #region For Round Edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

        );
        #endregion

        #region For dragging without the title bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(showpwd.Checked)
            {
                passwordField.PasswordChar = '\0';
            }
            else
            {
                passwordField.PasswordChar = '•';
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;
            if (username.Equals("admin@lms.uet.edu.pk") && password.Equals("Admin123"))
            {
                this.Hide();
                AdminDashboardForm frm = new AdminDashboardForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
