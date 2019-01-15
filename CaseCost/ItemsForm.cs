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
    public partial class ItemsForm : MetroFramework.Forms.MetroForm, IDisposable
    {
        MainForm main = new MainForm();

        int SelectedRow = -1;

        int id;

        public ItemsForm()
        {
            InitializeComponent();
        }
     
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsGridView.ItemsT' table. You can move, or remove it, as needed.
            this.itemsTTableAdapter.Fill(this.itemsGridView.ItemsT);
            DatePickerItems.Value = DateTime.Now;
            main = (MainForm)Application.OpenForms["MainForm"];

        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtUnitPrice.Text.Trim() != "" && txtQuantity.Text.Trim() != "")
            {
                if (Regex.IsMatch(txtUnitPrice.Text, @"^[0-9]\d{0,9}(\.\d{1,2})?%?$") && Regex.IsMatch(txtQuantity.Text, @"^[0-9]\d{0,9}(\.\d{1,2})?%?$"))
                {
                    if (Convert.ToDecimal(txtUnitPrice.Text) > 0 && Convert.ToDecimal(txtQuantity.Text) > 0)
                    {
                        ItemsT item = new ItemsT() { Name = txtName.Text, Date = DatePickerItems.Value, UnitPrice = Convert.ToDecimal(txtUnitPrice.Text), Quantity = Convert.ToDecimal(txtQuantity.Text), Description = txtDescription.Text };
                        MessageBox.Show(new ItemsModel().InsertItem(item));
                    }
                    else
                    {
                        MessageBox.Show("Unit Price and Quantity Must Be More Than Zero");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter a Number Into Unit Price and Quantity Fields");
                }
            }
            else
            {
                MessageBox.Show("Please Insert Fields");
            }
            //clear Text Boxes
            TextBoxCleaner();
            // TODO: This line of code loads data into the 'itemsGirdView.ItemsT' table. You can move, or remove it, as needed.
            this.itemsTTableAdapter.Fill(this.itemsGridView.ItemsT);

            //refersh items combox in Main form
            if (main.CbItemInv.InvokeRequired)
            {
                main.Invoke(new MethodInvoker(delegate { main.ItemsTTableAdapter.Fill(main.ItemsNameCB.ItemsT); }));
                
            }
        }

        //textbox cleaner method
        private void TextBoxCleaner()
        {
            txtName.Text = txtDescription.Text = txtUnitPrice.Text = txtQuantity.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtUnitPrice.Text.Trim() != "" && txtQuantity.Text.Trim() != "")
            {
                if (Regex.IsMatch(txtUnitPrice.Text, @"^[0-9]\d{0,9}(\.\d{1,2})?%?$") && Regex.IsMatch(txtQuantity.Text, @"^[0-9]\d{0,9}(\.\d{1,2})?%?$"))
                {
                    if (Convert.ToDecimal(txtUnitPrice.Text) > 0 && Convert.ToDecimal(txtQuantity.Text) > 0)
                    {
                        if (dataGridView1.Rows[SelectedRow].Cells[1].Value.ToString() == txtUnitPrice.Text)
                        {
                            //get data from fields
                            ItemsT item = new ItemsT() { ItemID = id, Name = txtName.Text, Quantity = Convert.ToDecimal(txtQuantity.Text), UnitPrice = Convert.ToDecimal(txtUnitPrice.Text), Date = DatePickerItems.Value, Description = txtDescription.Text };

                            //insert store procedure 
                            MessageBox.Show(new ItemsModel().UpdateItem(item));

                            //refill gridview with new data
                            this.itemsTTableAdapter.Fill(this.itemsGridView.ItemsT);

                            TextBoxCleaner();
                            btnEdit.Enabled = false;
                            btnSave.Enabled = true;

                            SelectedRow = -1;
                        }
                        else
                        {
                            //get data from fields
                            ItemsT item = new ItemsT() { ItemID = id, Name = txtName.Text, Quantity = Convert.ToDecimal(txtQuantity.Text), UnitPrice = Convert.ToDecimal(txtUnitPrice.Text), Date = DatePickerItems.Value, Description = txtDescription.Text };

                            //insert store procedure 
                            new ItemsModel().UpdateItem(item);

                            //Get new Price
                            ItemPriceUpdateT itemPrice = new ItemPriceUpdateT() { ItemID = id, ModifyDate = DateTime.Now, OldUnitPrice = (decimal)dataGridView1.Rows[SelectedRow].Cells[1].Value, NewUnitPrice = Convert.ToDecimal(txtUnitPrice.Text) };

                            //Update With New Price
                            MessageBox.Show(new ItemPriceUpdateModel().InsertUpdatedPrice(itemPrice));

                            //refill gridview with new data
                            this.itemsTTableAdapter.Fill(this.itemsGridView.ItemsT);
                            SelectedRow = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unit Price and Quantity Must Be More Than Zero");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a Number Into Unit Price and Quantity Fields");
                }
            }
            else
            {
                MessageBox.Show("Please Insert Fields");
            }
            //refersh items combox in Main form
            if (main.CbItemInv.InvokeRequired)
            {
                main.Invoke(new MethodInvoker(delegate { main.ItemsTTableAdapter.Fill(main.ItemsNameCB.ItemsT); }));

            }

        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
        //    if (confirmResult == DialogResult.Yes)
        //    {
        //        //get data from fields
        //        ItemsT item = new ItemsT() { ItemID = id, Name = txtName.Text };

        //        //delete store procedure
        //        MessageBox.Show(new ItemsModel().DeleteItem(item));

        //        //refill gridview with new data
        //        this.itemsTTableAdapter.Fill(this.itemsGridView.ItemsT);

        //        TextBoxCleaner();
        //        btnEdit.Enabled = false;
        //        btnSave.Enabled = true;
        //    }
        //    //refersh items combox in Main form
        //    if (main.CbItemInv.InvokeRequired)
        //    {
        //        main.Invoke(new MethodInvoker(delegate { main.ItemsTTableAdapter.Fill(main.ItemsNameCB.ItemsT); }));

        //    }

        //}

        //reset all fields and quit edit mode
        private void btnReset_Click(object sender, EventArgs e)
        {
            TextBoxCleaner();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count <= 1) //to make sure that user atleast choosed a row
            {
                //get the columns values 
                string Name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string UnitPrice = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Quantity = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime Date = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                string description = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

                SelectedRow = e.RowIndex;

                //fill fields
                txtName.Text = Name;
                txtQuantity.Text = Quantity;
                txtUnitPrice.Text = UnitPrice;
                DatePickerItems.Value = Date;
                txtDescription.Text = description;

                //open edit mode and close insert
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                btnReset.Enabled = true;
            }
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {
                    var query = db.ItemsTs.Where(i => i.Name.Contains(txtSearch.Text));
                    dataGridView1.DataSource = query.ToList();
                    
                }
                
            }
            else
            {
                using(CaseCostEntities db = new CaseCostEntities())
                {
                    var query = db.ItemsTs;
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AuditForm"] as AuditForm != null)
            {
                Application.OpenForms["AuditForm"].Focus();

            }
            else
            {
                AuditForm audit = new AuditForm();
                audit.Show();
            }
        }
    }
}
