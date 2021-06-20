﻿using LearningManagementSystem.classes;
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
            LoadTheme();
            LoadData();
        }

        private void LoadData() 
        {
            Manager mn = University.instance.Mngr;
            if (mn == null) return;
            nametxtbox.Text = mn.Name;
            cnictxtbox.Text = mn.Cnic;
            emailtxtbox.Text = mn.Email;
            qualificationtxtbox.Text = mn.Qualification;
            addressbox.Text = mn.Address;
            contactNumbertxtbox.Text = mn.ContactNubmer;
            birthDate.Value = DateTime.Now;
            passwordtxtbox.Text = mn.Password;
            
        } 

        private void LoadTheme()
        {
            foreach(Control button in this.Controls)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEdit_Load(object sender, EventArgs e)
        {

        }

        private void actionbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
