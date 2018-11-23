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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        Thread thread;
        public string User { get; set; }
        public int Premission { get; set; }


        public MainForm()
        {      
            InitializeComponent();
        }
        public MainForm(string username, int premission)
        {
            User = username;
            Premission = premission;

            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsNameCB.ItemsT' table. You can move, or remove it, as needed.
            this.itemsTTableAdapter.Fill(this.itemsNameCB.ItemsT);
            // TODO: This line of code loads data into the 'caseCostDataSet1.ProceduresT' table. You can move, or remove it, as needed.
            this.proceduresTTableAdapter.Fill(this.caseCostDataSet1.ProceduresT);
            InvoiceDatePicker.Value = DateTime.Now;
            lblname.Text += " " + User;
            if (this.Premission != 1)
            {
                this.pictureBox2.Visible = false; 
            }
        }


        private void cbItemInv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                int InvItemId = Convert.ToInt32(cbItemInv.SelectedValue);
                //get the value of unitprice
                txtUnitPriceInv.Text = db.ItemsTs.Where(i => i.ItemID == InvItemId).Select(u => u.UnitPrice).FirstOrDefault().ToString();

                //get the initail value of Quantity
                txtQuantityInv.Text = db.ItemsTs.Where(i => i.ItemID == InvItemId).Select(q => q.Quantity).FirstOrDefault().ToString();
            }
        }

        private void txtQuantityInv_TextChanged(object sender, EventArgs e)
        {
            decimal txtQunatityValue = 0;
            decimal txtUnitPriceValue = 0;
            string stringQuantity = txtQuantityInv.Text;
            string stringUnitPrice = txtUnitPriceInv.Text;
            //calculate the total 
            if (Regex.IsMatch(stringQuantity, @"^[0-9]\d{0,9}(\.\d{1,2})?%?$"))
            {
                decimal.TryParse(stringQuantity, out txtQunatityValue);
                decimal.TryParse(stringUnitPrice, out txtUnitPriceValue);
                decimal TotalTextValue = Math.Round(txtUnitPriceValue * txtQunatityValue, 2);
                txtTotal.Text = TotalTextValue.ToString();
            }
            else
                txtTotal.Text = string.Empty;
        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {

            bool itemScan = false;
            if (txtUnitPriceInv.Text.Trim() != string.Empty && txtQuantityInv.Text.Trim() != string.Empty)
            {
                if (Regex.IsMatch(txtQuantityInv.Text, @"^[0-9]\d{0,9}(\.\d{1,2})?%?$"))
                {

                    string ItemName = cbItemInv.Text;
                    decimal UnitPrice = Convert.ToDecimal(txtUnitPriceInv.Text);
                    decimal Quantity = Convert.ToDecimal(txtQuantityInv.Text);
                    decimal Total = Math.Round((UnitPrice * Quantity), 2);

                    if (Quantity > 0)
                    {
                        for (int i = 0; i < InvGridView.RowCount; i++)
                        {
                            if (Convert.ToInt32(InvGridView.Rows[i].Cells[4].Value) != Convert.ToInt32(cbItemInv.SelectedValue))
                            {
                                itemScan = true;
                            }
                            else
                            {
                                itemScan = false;
                                break;
                            }
                        }
                        if (itemScan == true)
                        {
                            int rowIndex = InvGridView.Rows.Add();
                            var row = InvGridView.Rows[rowIndex];
                            row.Cells[0].Value = ItemName;
                            row.Cells[1].Value = UnitPrice;
                            row.Cells[2].Value = Quantity;
                            row.Cells[3].Value = Total;
                            row.Cells[4].Value = cbItemInv.SelectedValue;

                        }
                        else
                            MessageBox.Show("This Item Inserted Before !!");
                    }
                    else
                        MessageBox.Show("Please Set Quantity More than 0");
                }
                else
                    MessageBox.Show("You should put a number in Quantity Field");

                cbItemInv.Text = txtTotal.Text = txtUnitPriceInv.Text = txtQuantityInv.Text = string.Empty;

            }
            else
                MessageBox.Show("Choose an Item and Set The Quantity");
        }

        int selectedRow;  //catch selected row index for updating

        private void InvGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InvGridView.SelectedRows.Count > 0 && InvGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                selectedRow = e.RowIndex;


                //fill textboxes
                txtQuantityInv.Text = InvGridView.Rows[selectedRow].Cells[2].Value.ToString();

                //buttons enabled status
                btnAddInv.Enabled = false;
                btnUpdateInv.Enabled = true;
                btnDeleteInv.Enabled = true;
                cbItemInv.Enabled = false;
            }
        }

        //update item quantity in grid view
        private void btnUpdateInv_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = InvGridView.Rows[selectedRow];
            row.Cells[2].Value = txtQuantityInv.Text;
            row.Cells[3].Value = Math.Round(Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[1].Value), 2);


            txtQuantityInv.Clear();

            //buttons enabled status
            btnAddInv.Enabled = true;
            btnUpdateInv.Enabled = false;
            btnDeleteInv.Enabled = false;
            cbItemInv.Enabled = true;
        }

        //delete an item in grid view
        private void btnDeleteInv_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = InvGridView.Rows[selectedRow];
            var confirmResult = MessageBox.Show("Are you sure to Remove this item for the invoice ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                InvGridView.Rows.RemoveAt(selectedRow);
            }

            txtQuantityInv.Clear();

            //buttons enabled status
            btnAddInv.Enabled = true;
            btnUpdateInv.Enabled = false;
            btnDeleteInv.Enabled = false;
            cbItemInv.Enabled = true;
        }

        private int cost_id = 0;


        //make invoice 
        private void btnMakeInv_Click(object sender, EventArgs e)
        {
            if (InvGridView.RowCount > 1)
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {

                    //transaction to rollback
                    using (DbContextTransaction transaction = db.Database.BeginTransaction())
                    {
                        List<CostDetailsT> costDetailsTs = new List<CostDetailsT>();
                        CostT costT = new CostT() { ProcedureID = Convert.ToInt32(cmbProcedureName.SelectedValue), Date = InvoiceDatePicker.Value };
                        int check_Cost = new InvoiceModel().InsertCost(costT, out cost_id);

                        //add data into list
                        for (int i = 0; i < InvGridView.RowCount - 1; i++)
                        {
                            costDetailsTs.Add(new CostDetailsT() { ItemID = Convert.ToInt32(InvGridView.Rows[i].Cells[4].Value), CostID = cost_id, Quantity = Convert.ToDecimal(InvGridView.Rows[i].Cells[2].Value) });
                        }

                        int check_CostDetails = new InvoiceModel().InsertCostDetails(costDetailsTs);

                        //if something went wrong rollback or commit if done
                        if (check_Cost == 1 && check_CostDetails == 1)
                        {
                            transaction.Commit();
                            MessageBox.Show($"Inv NO.{cost_id} Has Made Succesfully");
                            btnPreview.Enabled = true;

                        }
                        else
                            transaction.Rollback();
                    }
                }
            }
            else
                MessageBox.Show("Please Insert Items");

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            thread = new Thread(OpenInv);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            InvGridView.Rows.Clear();
            btnPreview.Enabled = false;
        }
        private void OpenInv()
        {
            Application.Run(new InvoiceForm());
        }

        private void btnNewInv_Click(object sender, EventArgs e)
        {
            InvGridView.Rows.Clear();
            btnPreview.Enabled = false;
        }


        private void btnPreviewAll_Click(object sender, EventArgs e)
        {
            new InvoicesForm().Invoke(new MethodInvoker(MultiThreadInvoicesForm));
        }

        private void MultiThreadInvoicesForm()
        {
            if (Application.OpenForms["InvoicesForm"] != null)
            {
                Application.OpenForms["InvoicesForm"].Activate();
            }
            else
            {
                thread = new Thread(InvoicesFormShow);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void InvoicesFormShow()
        {
            Application.Run(new InvoicesForm());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            thread = new Thread(OpenLogInForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            //to close all forms
            Invoke(new MethodInvoker(CloseAllThreadsForms));
            this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Close();

           
        }

        private static void CloseAllThreadsForms()
        {
            if (Application.OpenForms["UsersForm"] != null)
            {
                Application.OpenForms["UsersForm"].Close();
            }

            if (Application.OpenForms["InvoicesForm"] != null)
            {
                Application.OpenForms["InvoicesForm"].Close();
            }

            if (Application.OpenForms["ItemsForm"] != null)
            {
                Application.OpenForms["ItemsForm"].Close();
            }

            if (Application.OpenForms["InvoiceForm"] != null)
            {
                Application.OpenForms["InvoiceForm"].Close();
            }

            if (Application.OpenForms["AuditForm"] != null)
            {
                Application.OpenForms["AuditForm"].Close();
            }

            if (Application.OpenForms["InvDatesForm"] != null)
            {
                Application.OpenForms["InvDatesForm"].Close();
            }

            if (Application.OpenForms["ProceduresForm"] != null)
            {
                Application.OpenForms["ProceduresForm"].Close();
            }
        }

        public void OpenLogInForm()
        {
            Application.Run(new LoginForm());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MidForm().ShowDialog();
            InvGridView.Rows.Clear();
            btnPreview.Enabled = false;
        }
    }
}
