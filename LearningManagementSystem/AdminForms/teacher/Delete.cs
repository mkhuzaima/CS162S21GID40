using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningManagementSystem.AdminForms.teacher
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            actionbtn.Text = this.Text;
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control button in this.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    Button btn = (Button)button;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (button.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)button;
                    tb.ReadOnly = true;
                }
            }

        }

        private void actionbtn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Text = null;
                    //University.instance.Mngr = null;
                }
            }
        }
    }
}
