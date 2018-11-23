using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.Entity;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace CaseCost
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Premission { get; set; }

        bool accCheck = false;
        Thread th;

        List<UsersList> UsersName = new List<UsersList>();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            accCheck = false;
            txtUserName.Focus();
            using (CaseCostEntities db = new CaseCostEntities())
            {
                var query = db.UsersTs.Select( s => new UsersList { name = s.Name, password = s.Password, Premission = s.PremissionsID}).ToList();

                foreach (var item in query)
                {
                    UsersName.Add(item);
                }
            }
        }
        private void btnAddInv_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" && txtPassword.Text.Trim() != "")
            {
                MessageBox.Show("Please Type a UserName");
                txtUserName.WithError = true;
                return;
            }
            if (txtPassword.Text.Trim() == "" && txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Your UserName and Password");
                txtPassword.WithError = true;
                txtUserName.WithError = true;
                return;
            }
            if(txtPassword.Text.Trim() == "" && txtUserName.Text.Trim() != "")
            {
                MessageBox.Show("Please Insert Password");
                txtPassword.WithError = true;
                return;
            }
            
            foreach (var item in UsersName)
            {
                bool areEqual = string.Equals(txtUserName.Text.Trim(), item.name, StringComparison.OrdinalIgnoreCase);
                if (areEqual && txtPassword.Text.Trim() == item.password)
                {
                    this.UserName = item.name;
                    this.Premission = item.Premission;
                    MultithreadsMain();                  
                    this.Close();
                    accCheck = true;
                    break;
                }
            }
            if(accCheck == false)
            {
                MessageBox.Show("UserName Or Password Wrong !!");
            }
        }

        private void btnDeleteInv_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void MultithreadsMain()
    {
        if (Application.OpenForms["MainForm"] != null)
        {
            Application.OpenForms["MainForm"].WindowState = FormWindowState.Normal;
            Application.OpenForms["MainForm"].Activate();
            this.Close();
        }
        else
        {
            th = new Thread(ShowMainForm);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();

        }
    }

        private void ShowMainForm()
        {
            Application.Run(new MainForm(this.UserName, this.Premission));
        }
    }




    public class UsersList
    {
        public string name { get; set; }
        public string password { get; set; }

        public int Premission { get; set; }
    }
}