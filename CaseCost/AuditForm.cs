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
    public partial class AuditForm : MetroFramework.Forms.MetroForm
    {
        public AuditForm()
        {
            InitializeComponent();
        }

        private void AuditForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            // TODO: This line of code loads data into the 'itemsNameCB.ItemsT' table. You can move, or remove it, as needed.
            this.itemsTTableAdapter.Fill(this.itemsNameCB.ItemsT);

            //load cbYears with years
            using (CaseCostEntities db = new CaseCostEntities())
            {
                var cbYearsData = db.ItemPriceUpdateTs.Select(p => p.ModifyDate.Year).Distinct().OrderByDescending(p => p).ToList();
               
                foreach (var item in cbYearsData)
                {
                    cbYears1.Items.Add((object)item);

                }
                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbYears1.Text != "")
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {
                    var query = db.ItemPriceUpdateTs.AsEnumerable().Where(i => i.ItemID == (int)cbItemChart.SelectedValue).Where(i => i.ModifyDate.Year == int.Parse(cbYears1.Text))
                        .Join(db.ItemsTs, p => p.ItemID, i => i.ItemID, (p, i) => new { i.Name, p.OldUnitPrice, p.NewUnitPrice, p.ModifyDate });
                    GridViewAudit.DataSource = query.ToList();
                }
                for (int i = 0; i < GridViewAudit.Rows.Count; i++)
                {
                    GridViewAudit.Rows[i].Cells[0].Value = (object)(Convert.ToDecimal(GridViewAudit.Rows[i].Cells[3].Value) - Convert.ToDecimal(GridViewAudit.Rows[i].Cells[2].Value));
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Year");
            }

        }
        
    }
}
