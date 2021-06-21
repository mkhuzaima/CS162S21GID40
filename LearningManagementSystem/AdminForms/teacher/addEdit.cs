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
    public partial class addEdit : Form
    {
        public addEdit(string action)
        {
            InitializeComponent();
            this.Text = action + " Teacher";
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
            }
        }

        private void actionbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
