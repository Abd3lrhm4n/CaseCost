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
    public partial class UsersForm : MetroFramework.Forms.MetroForm
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        int id;

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premissionDataSet.PremissionsT' table. You can move, or remove it, as needed.
            this.premissionsTTableAdapter.Fill(this.premissionDataSet.PremissionsT);
            UsersGirdViewDataSource();
        }

        bool usersCheck = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            UsersT user = new UsersT() { Name = txtUserName.Text, Number = "", Password = txtPass.Text, PremissionsID = (int)cbPremissions.SelectedValue };
            if (txtUserName.Text.Trim() != "")
            {
                if (txtPass.Text.Trim() != "")
                {
                    for (int i = 0; i < UsersGirdView.RowCount; i++)
                    {
                        if (UsersGirdView.Rows[i].Cells[0].Value.ToString().ToLower().Trim() != user.Name.ToLower().Trim())
                        {
                            usersCheck = true;
                        }
                        else
                        {
                            usersCheck = false;
                            MessageBox.Show($"{user.Name} is Exist");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Write The Password");
                    txtPass.WithError = true;
                }
            }
            else
            {
                MessageBox.Show("Please Write User Name");
                txtUserName.WithError = true;
            }
            if (usersCheck == true)
            {
                MessageBox.Show(new UsersModel().InsertUser(user));
                UsersGirdViewDataSource();
            }
            
        }

        private void UsersGirdViewDataSource()
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                var query = db.UsersTs.Join(db.PremissionsTs, s => s.PremissionsID, p => p.ID, (s, p) => new { s.Name, s.Password, p.Premission, s.ID }).ToList();
                UsersGirdView.DataSource = query;
            }

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            //if (btnDelete.Enabled == false && btnEdit.Enabled == false)
            //{
            //    lblPassConfirm.Visible = true;
            //    txtPassConfirm.Visible = true;
            //}
        }

        private void UsersGirdView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = UsersGirdView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPass.Text = UsersGirdView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbPremissions.Text = UsersGirdView.Rows[e.RowIndex].Cells[2].Value.ToString();
            id = (int)UsersGirdView.Rows[e.RowIndex].Cells[3].Value;

            btnCreateNew.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UsersT user = new UsersT() { ID = id, Name = txtUserName.Text, Password = txtPass.Text, Number = "", PremissionsID = (int)cbPremissions.SelectedValue };
            MessageBox.Show(new UsersModel().UpdateUser(user));
            UsersGirdViewDataSource();
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtPass.Text = txtUserName.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UsersT user = new UsersT() { ID = id, Name = txtUserName.Text, Password = txtPass.Text, Number = "", PremissionsID = (int)cbPremissions.SelectedValue };
            MessageBox.Show(new UsersModel().DeleteUser(user));
            UsersGirdViewDataSource();
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtPass.Text = txtUserName.Text = string.Empty;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtPass.Text = txtUserName.Text = string.Empty;
        }
    }
}
