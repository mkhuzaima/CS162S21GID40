
namespace LearningManagementSystem
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.studentpnl = new System.Windows.Forms.Panel();
            this.teacherpnl = new System.Windows.Forms.Panel();
            this.managerpnl = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.deleteStdent = new System.Windows.Forms.Button();
            this.updateStudent = new System.Windows.Forms.Button();
            this.viewStudent = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.studentbtn = new System.Windows.Forms.Button();
            this.deleteTeacher = new System.Windows.Forms.Button();
            this.updateTeacher = new System.Windows.Forms.Button();
            this.viewTeacher = new System.Windows.Forms.Button();
            this.addTeacher = new System.Windows.Forms.Button();
            this.teacherbtn = new System.Windows.Forms.Button();
            this.deleteManger = new System.Windows.Forms.Button();
            this.updateManager = new System.Windows.Forms.Button();
            this.viewManager = new System.Windows.Forms.Button();
            this.addManager = new System.Windows.Forms.Button();
            this.ManagerBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.settingbtn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.studentpnl.SuspendLayout();
            this.teacherpnl.SuspendLayout();
            this.managerpnl.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.settingbtn);
            this.panelMenu.Controls.Add(this.studentpnl);
            this.panelMenu.Controls.Add(this.studentbtn);
            this.panelMenu.Controls.Add(this.teacherpnl);
            this.panelMenu.Controls.Add(this.teacherbtn);
            this.panelMenu.Controls.Add(this.managerpnl);
            this.panelMenu.Controls.Add(this.ManagerBtn);
            this.panelMenu.Controls.Add(this.panelBar);
            this.panelMenu.Controls.Add(this.logoutBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 581);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // studentpnl
            // 
            this.studentpnl.Controls.Add(this.deleteStdent);
            this.studentpnl.Controls.Add(this.updateStudent);
            this.studentpnl.Controls.Add(this.viewStudent);
            this.studentpnl.Controls.Add(this.addStudent);
            this.studentpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentpnl.Location = new System.Drawing.Point(0, 666);
            this.studentpnl.Name = "studentpnl";
            this.studentpnl.Size = new System.Drawing.Size(197, 203);
            this.studentpnl.TabIndex = 15;
            // 
            // teacherpnl
            // 
            this.teacherpnl.Controls.Add(this.deleteTeacher);
            this.teacherpnl.Controls.Add(this.updateTeacher);
            this.teacherpnl.Controls.Add(this.viewTeacher);
            this.teacherpnl.Controls.Add(this.addTeacher);
            this.teacherpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherpnl.Location = new System.Drawing.Point(0, 403);
            this.teacherpnl.Name = "teacherpnl";
            this.teacherpnl.Size = new System.Drawing.Size(197, 203);
            this.teacherpnl.TabIndex = 13;
            // 
            // managerpnl
            // 
            this.managerpnl.Controls.Add(this.deleteManger);
            this.managerpnl.Controls.Add(this.updateManager);
            this.managerpnl.Controls.Add(this.viewManager);
            this.managerpnl.Controls.Add(this.addManager);
            this.managerpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerpnl.Location = new System.Drawing.Point(0, 140);
            this.managerpnl.Name = "managerpnl";
            this.managerpnl.Size = new System.Drawing.Size(197, 203);
            this.managerpnl.TabIndex = 11;
            this.managerpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.managerpnl_Paint);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBar.Location = new System.Drawing.Point(0, 1084);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(5, 60);
            this.panelBar.TabIndex = 8;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(197, 80);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ULMS";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(214, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(699, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Location = new System.Drawing.Point(17, 27);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(37, 28);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(352, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(214, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(699, 501);
            this.panelDesktopPane.TabIndex = 9;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // deleteStdent
            // 
            this.deleteStdent.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteStdent.FlatAppearance.BorderSize = 0;
            this.deleteStdent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteStdent.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteStdent.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.deleteStdent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteStdent.Location = new System.Drawing.Point(0, 135);
            this.deleteStdent.Name = "deleteStdent";
            this.deleteStdent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deleteStdent.Size = new System.Drawing.Size(197, 45);
            this.deleteStdent.TabIndex = 13;
            this.deleteStdent.Text = "   Delete";
            this.deleteStdent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteStdent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteStdent.UseVisualStyleBackColor = true;
            this.deleteStdent.Click += new System.EventHandler(this.deleteStdent_Click);
            // 
            // updateStudent
            // 
            this.updateStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateStudent.FlatAppearance.BorderSize = 0;
            this.updateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateStudent.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.updateStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateStudent.Location = new System.Drawing.Point(0, 90);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.updateStudent.Size = new System.Drawing.Size(197, 45);
            this.updateStudent.TabIndex = 12;
            this.updateStudent.Text = "   Update";
            this.updateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // viewStudent
            // 
            this.viewStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewStudent.FlatAppearance.BorderSize = 0;
            this.viewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.viewStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewStudent.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.viewStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewStudent.Location = new System.Drawing.Point(0, 45);
            this.viewStudent.Name = "viewStudent";
            this.viewStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.viewStudent.Size = new System.Drawing.Size(197, 45);
            this.viewStudent.TabIndex = 11;
            this.viewStudent.Text = "   View";
            this.viewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewStudent.UseVisualStyleBackColor = true;
            this.viewStudent.Click += new System.EventHandler(this.viewStudent_Click);
            // 
            // addStudent
            // 
            this.addStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.addStudent.FlatAppearance.BorderSize = 0;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.addStudent.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.addStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudent.Location = new System.Drawing.Point(0, 0);
            this.addStudent.Name = "addStudent";
            this.addStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addStudent.Size = new System.Drawing.Size(197, 45);
            this.addStudent.TabIndex = 10;
            this.addStudent.Text = "   Add";
            this.addStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentbtn.FlatAppearance.BorderSize = 0;
            this.studentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.studentbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.studentbtn.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.studentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentbtn.Location = new System.Drawing.Point(0, 606);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.studentbtn.Size = new System.Drawing.Size(197, 60);
            this.studentbtn.TabIndex = 14;
            this.studentbtn.Text = "   Student";
            this.studentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentbtn.UseVisualStyleBackColor = true;
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click_1);
            // 
            // deleteTeacher
            // 
            this.deleteTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteTeacher.FlatAppearance.BorderSize = 0;
            this.deleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteTeacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteTeacher.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.deleteTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTeacher.Location = new System.Drawing.Point(0, 135);
            this.deleteTeacher.Name = "deleteTeacher";
            this.deleteTeacher.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deleteTeacher.Size = new System.Drawing.Size(197, 45);
            this.deleteTeacher.TabIndex = 13;
            this.deleteTeacher.Text = "   Delete";
            this.deleteTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteTeacher.UseVisualStyleBackColor = true;
            this.deleteTeacher.Click += new System.EventHandler(this.deleteTeacher_Click);
            // 
            // updateTeacher
            // 
            this.updateTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateTeacher.FlatAppearance.BorderSize = 0;
            this.updateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateTeacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateTeacher.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.updateTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateTeacher.Location = new System.Drawing.Point(0, 90);
            this.updateTeacher.Name = "updateTeacher";
            this.updateTeacher.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.updateTeacher.Size = new System.Drawing.Size(197, 45);
            this.updateTeacher.TabIndex = 12;
            this.updateTeacher.Text = "   Update";
            this.updateTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateTeacher.UseVisualStyleBackColor = true;
            this.updateTeacher.Click += new System.EventHandler(this.updateTeacher_Click);
            // 
            // viewTeacher
            // 
            this.viewTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewTeacher.FlatAppearance.BorderSize = 0;
            this.viewTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.viewTeacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewTeacher.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.viewTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTeacher.Location = new System.Drawing.Point(0, 45);
            this.viewTeacher.Name = "viewTeacher";
            this.viewTeacher.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.viewTeacher.Size = new System.Drawing.Size(197, 45);
            this.viewTeacher.TabIndex = 11;
            this.viewTeacher.Text = "   View";
            this.viewTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewTeacher.UseVisualStyleBackColor = true;
            this.viewTeacher.Click += new System.EventHandler(this.viewTeacher_Click);
            // 
            // addTeacher
            // 
            this.addTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTeacher.FlatAppearance.BorderSize = 0;
            this.addTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addTeacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.addTeacher.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.addTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTeacher.Location = new System.Drawing.Point(0, 0);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addTeacher.Size = new System.Drawing.Size(197, 45);
            this.addTeacher.TabIndex = 10;
            this.addTeacher.Text = "   Add";
            this.addTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // teacherbtn
            // 
            this.teacherbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherbtn.FlatAppearance.BorderSize = 0;
            this.teacherbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teacherbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.teacherbtn.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.teacherbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherbtn.Location = new System.Drawing.Point(0, 343);
            this.teacherbtn.Name = "teacherbtn";
            this.teacherbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.teacherbtn.Size = new System.Drawing.Size(197, 60);
            this.teacherbtn.TabIndex = 12;
            this.teacherbtn.Text = "   Teacher";
            this.teacherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.teacherbtn.UseVisualStyleBackColor = true;
            this.teacherbtn.Click += new System.EventHandler(this.teacherbtn_Click);
            // 
            // deleteManger
            // 
            this.deleteManger.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteManger.FlatAppearance.BorderSize = 0;
            this.deleteManger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteManger.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteManger.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.deleteManger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteManger.Location = new System.Drawing.Point(0, 135);
            this.deleteManger.Name = "deleteManger";
            this.deleteManger.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deleteManger.Size = new System.Drawing.Size(197, 45);
            this.deleteManger.TabIndex = 13;
            this.deleteManger.Text = "   Delete";
            this.deleteManger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteManger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteManger.UseVisualStyleBackColor = true;
            this.deleteManger.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // updateManager
            // 
            this.updateManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateManager.FlatAppearance.BorderSize = 0;
            this.updateManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateManager.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.updateManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateManager.Location = new System.Drawing.Point(0, 90);
            this.updateManager.Name = "updateManager";
            this.updateManager.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.updateManager.Size = new System.Drawing.Size(197, 45);
            this.updateManager.TabIndex = 12;
            this.updateManager.Text = "   Update";
            this.updateManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateManager.UseVisualStyleBackColor = true;
            this.updateManager.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // viewManager
            // 
            this.viewManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewManager.FlatAppearance.BorderSize = 0;
            this.viewManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.viewManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewManager.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.viewManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewManager.Location = new System.Drawing.Point(0, 45);
            this.viewManager.Name = "viewManager";
            this.viewManager.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.viewManager.Size = new System.Drawing.Size(197, 45);
            this.viewManager.TabIndex = 11;
            this.viewManager.Text = "   View";
            this.viewManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewManager.UseVisualStyleBackColor = true;
            this.viewManager.Click += new System.EventHandler(this.button6_Click);
            // 
            // addManager
            // 
            this.addManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.addManager.FlatAppearance.BorderSize = 0;
            this.addManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.addManager.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.addManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addManager.Location = new System.Drawing.Point(0, 0);
            this.addManager.Name = "addManager";
            this.addManager.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addManager.Size = new System.Drawing.Size(197, 45);
            this.addManager.TabIndex = 10;
            this.addManager.Text = "   Add";
            this.addManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.button7_Click);
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerBtn.FlatAppearance.BorderSize = 0;
            this.ManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ManagerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManagerBtn.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.ManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerBtn.Location = new System.Drawing.Point(0, 80);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ManagerBtn.Size = new System.Drawing.Size(197, 60);
            this.ManagerBtn.TabIndex = 10;
            this.ManagerBtn.Text = "   Manager";
            this.ManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManagerBtn.UseVisualStyleBackColor = true;
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logoutBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.logoutBtn.Image = global::LearningManagementSystem.Properties.Resources.home;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 1204);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(197, 60);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "   Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingbtn
            // 
            this.settingbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.settingbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingbtn.FlatAppearance.BorderSize = 0;
            this.settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingbtn.Image = global::LearningManagementSystem.Properties.Resources.settings;
            this.settingbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbtn.Location = new System.Drawing.Point(0, 1144);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.settingbtn.Size = new System.Drawing.Size(197, 60);
            this.settingbtn.TabIndex = 16;
            this.settingbtn.Text = "   Setting";
            this.settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingbtn.UseVisualStyleBackColor = true;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 581);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin\'s Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.studentpnl.ResumeLayout(false);
            this.teacherpnl.ResumeLayout(false);
            this.managerpnl.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button teacherbtn;
        private System.Windows.Forms.Panel managerpnl;
        private System.Windows.Forms.Button updateManager;
        private System.Windows.Forms.Button viewManager;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Button ManagerBtn;
        private System.Windows.Forms.Button deleteManger;
        private System.Windows.Forms.Panel studentpnl;
        private System.Windows.Forms.Button deleteStdent;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button viewStudent;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Panel teacherpnl;
        private System.Windows.Forms.Button deleteTeacher;
        private System.Windows.Forms.Button updateTeacher;
        private System.Windows.Forms.Button viewTeacher;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}