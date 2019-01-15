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
    public partial class ProceduresForm : MetroFramework.Forms.MetroForm
    {
        MainForm main = new MainForm();
        int id = 0;
        public ProceduresForm()
        {
            InitializeComponent();
        }

        private void ProceduresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'caseCostDataSet1.ProceduresT' table. You can move, or remove it, as needed.
            this.proceduresTTableAdapter.Fill(this.caseCostDataSet1.ProceduresT);
            this.WindowState = FormWindowState.Normal;


            main = (MainForm)Application.OpenForms["MainForm"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
            {
                ProceduresT procedures = new ProceduresT() { ProcedureName = txtName.Text, Note = txtDescription.Text };

                MessageBox.Show(new ProcedureModel().InsertProcedure(procedures));

                //refresh procedures combox in main form
                if (main.CmbProcedureName.InvokeRequired)
                {
                    main.Invoke(new MethodInvoker(delegate { main.ProceduresTTableAdapter.Fill(main.CaseCostDataSet1.ProceduresT); }));

                }

                // refresh GridView
                this.proceduresTTableAdapter.Fill(this.caseCostDataSet1.ProceduresT);

                this.txtName.WithError = false;
                txtDescription.Clear();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter a Procedure Name");
                this.txtName.WithError = true;
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProcGridView.SelectedRows.Count > 0 && ProcGridView.SelectedRows.Count <= 1 && ProcGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtName.Text = ProcGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescription.Text = ProcGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                id = (int)ProcGridView.Rows[e.RowIndex].Cells[0].Value;

                btnSave.Enabled = false;
                btnReset.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnSave.Enabled = true;
                btnReset.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
            {
                ProceduresT procedures = new ProceduresT() { ID = id, ProcedureName = txtName.Text, Note = txtDescription.Text };

                MessageBox.Show(new ProcedureModel().UpdateProcedure(procedures));

                //refresh procedures combox in main form
                if (main.CmbProcedureName.InvokeRequired)
                {
                    main.Invoke(new MethodInvoker(delegate { main.ProceduresTTableAdapter.Fill(main.CaseCostDataSet1.ProceduresT); }));

                }

                // refresh GridView
                this.proceduresTTableAdapter.Fill(this.caseCostDataSet1.ProceduresT);

                this.txtName.WithError = false;
                txtDescription.Clear();
                txtName.Clear();
                id = 0;
                
                btnSave.Enabled = true;
                btnReset.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please Enter a Procedure Name");
                this.txtName.WithError = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (id != 0 && confirmResult == DialogResult.Yes)
            {
                ProceduresT procedures = new ProceduresT() { ID = id };
                MessageBox.Show(new ProcedureModel().DeleteProcedure(procedures));

                //refresh procedures combox in main form
                if (main.CmbProcedureName.InvokeRequired)
                {
                    main.Invoke(new MethodInvoker(delegate { main.ProceduresTTableAdapter.Fill(main.CaseCostDataSet1.ProceduresT); }));
                    
                }

                // refresh GridView
                this.proceduresTTableAdapter.Fill(this.caseCostDataSet1.ProceduresT);

                txtName.Clear();
                txtDescription.Clear();
                btnSave.Enabled = true;
                btnReset.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
            btnSave.Enabled = true;
            btnReset.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        //search text box
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {
                    var query = db.ProceduresTs.Where(i => i.ProcedureName.Contains(txtSearch.Text));
                    ProcGridView.DataSource = query.ToList();

                }

            }
            else
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {
                    var query = db.ProceduresTs;
                    ProcGridView.DataSource = query.ToList();
                }
            }
        }


    }  
}
