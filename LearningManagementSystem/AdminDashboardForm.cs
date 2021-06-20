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

    public partial class AdminDashboardForm : Form
    {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Panel currentSubmenuPanel;
        

        //constructor
        public AdminDashboardForm()
        {
            InitializeComponent();
            random = new Random();
            //          color = Color.FromArgb(30, 0, 150, 136);
            //OpenChildForm(null, homeBtn);
            btnCloseChildForm.Visible = false;

           // homePanel.Hide();
            managerpnl.Hide();
            teacherpnl.Hide();
            studentpnl.Hide();

            //ManagerBtn_Click(ManagerBtn, EventArgs.Empty);
            btnCloseChildForm_Click(btnCloseChildForm, EventArgs.Empty);
            //To avoid hiding of taskbar on maximizing screen 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }



        #region for dragging without title bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
#endregion

        //Methods

        private void ActivateButton(object btnSender)
        {
            if ( (btnSender != null) &&
                 (btnSender.GetType() == typeof(Button) && 
                 (currentButton != (Button)btnSender)) )
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelTitleBar.BackColor = color;
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                panelLogo.BackColor = ThemeColor.SecondaryColor;
                btnCloseChildForm.Visible = true;

                panelBar.Show();
                panelBar.BackColor = ThemeColor.SecondaryColor;
                panelBar.Top = currentButton.Top;
                panelBar.Height = currentButton.Height;
            }
        }

        private void DisableButton()
        {
            panelBar.Hide();
            if (currentButton == null) return;
            currentButton.BackColor = Color.FromArgb(51, 51, 76);
            currentButton.ForeColor = Color.Gainsboro;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            /*foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }*/
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;

            //////////////////////////////////////////
            if (childForm == null) return;
            ///////////////////////////////////////////
            
            childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        
        /*private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSetting(), sender);
        }*/

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            HidePanel();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        //fordragging
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region maximize buttons 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //activate(sender);
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        /*private void homeBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(homePanel);
            //OpenChildForm(new Forms.FormSetting(), sender);

            //panelLogo.BackColor = color;
            OpenChildForm(null, sender);
        }*/

        private void ShowPanel(Panel submenuPanel)
        {
            if (currentSubmenuPanel != submenuPanel)
            {
                if (currentSubmenuPanel != null)
                    currentSubmenuPanel.Hide();
                currentSubmenuPanel = submenuPanel;
                currentSubmenuPanel.Show();
            }
            else
            {
                HidePanel();
            }
        }

        private void HidePanel()
        {
            if (currentSubmenuPanel == null) return;
            currentSubmenuPanel.Hide();
            currentSubmenuPanel = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
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

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(null, sender);
            ShowPanel(managerpnl);
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(null, sender);
            ActivateButton(sender);
            ShowPanel(teacherpnl);
        }


        private void studentbtn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(null, sender);
            ActivateButton(sender);
            ShowPanel(studentpnl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void managerpnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void setting_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentbtn_Click_1(object sender, EventArgs e)
        {
            ShowPanel(studentpnl);

        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }

        private void viewTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }

        private void updateTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }

        private void viewStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }


        private void updateStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }

        private void deleteStdent_Click(object sender, EventArgs e)
        {
            OpenChildForm(null, sender);

        }
    }
}
