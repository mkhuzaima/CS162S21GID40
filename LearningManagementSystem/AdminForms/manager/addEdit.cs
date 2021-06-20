using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningManagementSystem.AdminForms.manager
{
    public partial class addEdit : Form
    {
        public addEdit(string action)
        {
            InitializeComponent();
            this.Text = action + " Manager";
            actionbtn.Text = this.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
