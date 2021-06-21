using LearningManagementSystem.classes;
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
    public partial class AddEdit : Form
    {
        private string action;

        public AddEdit(string action)
        {
            this.action = action;
            InitializeComponent();
            this.Text = action + " Manager";
            actionbtn.Text = this.Text;
            LoadTheme();

            if (action.Equals("Edit"))
            {
                LoadData();
            }
            else
            {
                passwordtxtbox.Text = GeneratePassword();
            }
        }

        private string GeneratePassword()
        {
            string pwd = "";

            return pwd;
        }

        private void LoadData() 
        {
            if (University.instance.managers.Count == 0) return;
            
            Manager mn = University.instance.managers.ElementAt(0);
            if (mn == null) return;


            nametxtbox.Text = mn.Name;
            cnictxtbox.Text = mn.Cnic;
            emailtxtbox.Text = mn.Email;
            joiningDate.Value = mn.joinigDate;
            birthDate.Value = mn.DateOfBirth;
            qualificationtxtbox.Text = mn.Qualification;
            addressbox.Text = mn.Address;
            contactNumbertxtbox.Text = mn.ContactNubmer;
            passwordtxtbox.Text = mn.Password;
            usernametxtbox.Text = mn.Username;
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
            if (action.Equals("Add"))
            {
                string name = nametxtbox.Text;
                string cnic = cnictxtbox.Text;
                DateTime dateOfJoining = joiningDate.Value;
                DateTime dob = birthDate.Value;
                string contactNumber = contactNumbertxtbox.Text;
                string email = emailtxtbox.Text;
                string username = usernametxtbox.Text;
                string qualification = qualificationtxtbox.Text;
                string password = passwordtxtbox.Text;
                string address = addressbox.Text;
            
                Manager mn = new Manager();
                mn.Name = name;
                mn.Cnic = cnic;
                mn.DateOfBirth = dob;
                mn.joinigDate = dateOfJoining;
                mn.ContactNubmer = contactNumber;
                mn.Email = email;
                mn.Username = username;
                mn.Qualification = qualification;
                mn.Password = password;
                mn.Address = address;
                University.instance.managers.Add(mn);
                Console.WriteLine("Manager has been added Successfully.");
                MessageBox.Show("Manager has been added successfully! ");
            }
            else if (action.Equals("Edit"))
            {
                
            }
            
        }

    }
}
