using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CaseCost
{
    public partial class MidForm : MetroFramework.Forms.MetroForm
    {
        Thread th;
        public MidForm()
        {
            InitializeComponent();
        }
        #region hovers

        private void picItems_MouseHover(object sender, EventArgs e)
        {

            picItems.BackColor = Color.FromArgb(243, 169, 53);//(93, 209, 48);//(243, 169, 53);0, 174, 219
            lblItems.ForeColor = Color.FromArgb(243, 169, 53);
            lblItems.UseCustomForeColor = true;

        }

        private void picItems_MouseLeave(object sender, EventArgs e)
        {
            picItems.BackColor = Color.Transparent;
            lblItems.ForeColor = Color.FromArgb(0, 174, 219);
            lblItems.UseCustomForeColor = false;

        }

        private void picProcedures_MouseHover(object sender, EventArgs e)
        {
            picProcedures.BackColor = Color.FromArgb(243, 169, 53);//(93, 209, 48);//(243, 169, 53);0, 174, 219
            lblProcedures.ForeColor = Color.FromArgb(243, 169, 53);
            lblProcedures.UseCustomForeColor = true;
        }

        private void picProcedures_MouseLeave(object sender, EventArgs e)
        {
            picProcedures.BackColor = Color.Transparent;
            lblProcedures.ForeColor = Color.FromArgb(0, 174, 219);
            lblProcedures.UseCustomForeColor = false;
        }

        private void picUsers_MouseHover(object sender, EventArgs e)
        {
            picUsers.BackColor = Color.FromArgb(243, 169, 53);//(93, 209, 48);//(243, 169, 53);0, 174, 219
            lblUsers.ForeColor = Color.FromArgb(243, 169, 53);
            lblUsers.UseCustomForeColor = true;
        }

        private void picUsers_MouseLeave(object sender, EventArgs e)
        {
            picUsers.BackColor = Color.Transparent;
            lblUsers.ForeColor = Color.FromArgb(0, 174, 219);
            lblUsers.UseCustomForeColor = false;
        }

        #endregion

        private void picItems_Click(object sender, EventArgs e)
        {

            new ItemsForm().Invoke(new MethodInvoker((MultithreadsItems)));


        }

        private void MultithreadsItems()
        {
            if (Application.OpenForms["ItemsForm"] != null)
            {
                Application.OpenForms["ItemsForm"].WindowState = FormWindowState.Normal;
                Application.OpenForms["ItemsForm"].Activate();
                this.Close();
            }
            else
            {
                th = new Thread(ShowItemsForm);
                th.SetApartmentState(ApartmentState.STA);

                th.Start();
                this.Close();

            }
        }
        private void ShowItemsForm()
        {
            Application.Run(new  ItemsForm());
        }

        private void picProcedures_Click(object sender, EventArgs e)
        {
            new ProceduresForm().Invoke(new MethodInvoker((MultithreadsProcedures)));
        }

        private void MultithreadsProcedures()
        {
            if (Application.OpenForms["ProceduresForm"] != null)
            {
                Application.OpenForms["ProceduresForm"].WindowState = FormWindowState.Normal;
                Application.OpenForms["ProceduresForm"].Activate();
                this.Close();
            }
            else
            {
                th = new Thread(ShowProceduresForm);
                th.SetApartmentState(ApartmentState.STA);

                th.Start();
                this.Close();

            }
        }

      

        private void ShowProceduresForm()
        {
            Application.Run(new ProceduresForm());
        }

        private void picUsers_Click(object sender, EventArgs e)
        {
            new UsersForm().Invoke(new MethodInvoker((MultithreadsUsersForm)));

        }

        private void MultithreadsUsersForm()
        {
            if (Application.OpenForms["UsersForm"] != null)
            {
                Application.OpenForms["UsersForm"].WindowState = FormWindowState.Normal;
                Application.OpenForms["UsersForm"].Activate();
                this.Close();
            }
            else
            {
                th = new Thread(ShowUsersForm);
                th.SetApartmentState(ApartmentState.STA);

                th.Start();
                this.Close();

            }
        }

        private void ShowUsersForm()
        {
            Application.Run(new UsersForm());
        }
    }
}
