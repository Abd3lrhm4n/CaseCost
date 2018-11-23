using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using Microsoft.Reporting.WinForms;

namespace CaseCost
{
    public partial class InvDatesForm : MetroFramework.Forms.MetroForm
    {
        InvoicesForm frm = new InvoicesForm();
        public DateTime SDate;
        public DateTime EDate;

        //passing Datetime values to InvDatesForms
        public InvDatesForm(DateTime ed , DateTime sd)
        {
            InitializeComponent();
            EDate = ed;
            SDate = sd;
        }

        private void InvDatesForm_Load(object sender, EventArgs e)
        {
            

            GridViewDataSource();
            
        }
       
        //load InvDatesforms GridView Data
        private void GridViewDataSource()
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                
                var query = db.CostTs.Where(d => d.Date >= InvoicesForm.SDate && d.Date <= InvoicesForm.EDate)
                    .Join(db.ProceduresTs, c => c.ProcedureID, p => p.ID, (c, p) => new { c.CostID, c.Date, p.ProcedureName });
               
                GridViewInvDates.DataSource = query.ToList();
                
               
            }
        }
        

        
        
        int selectedRow;
        private void GridViewInvDates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            frm = Application.OpenForms["InvoicesForm"] as InvoicesForm;
            new InvoicesForm().Invoke(new MethodInvoker(InvoicesInvokeMethod));
            
        }

        private void InvoicesInvokeMethod()
        {
            frm.CbSelectInv1.Text = GridViewInvDates.Rows[selectedRow].Cells[0].Value.ToString();
            frm.ReportViewer2.LocalReport.DataSources.Clear();
            string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string reportPath = System.IO.Path.Combine(exeFolder, @"..\..\rdlcReportInvoice.rdlc");

            frm.QueryInvoiceTableAdapter1.Fill(frm.RdlcDataSet.QueryInvoice, Convert.ToInt32(frm.CbSelectInv1.Text));


            frm.ReportViewer2.LocalReport.ReportPath = reportPath;
            frm.ReportViewer2.LocalReport.DataSources.Clear();
            frm.ReportViewer2.LocalReport.ReportEmbeddedResource = reportPath;
            ReportDataSource rds = new ReportDataSource("rdlcDataSet", frm.RdlcDataSet.Tables[0]);
            frm.ReportViewer2.LocalReport.DataSources.Add(rds);


            frm.ReportViewer2.LocalReport.Refresh();
            frm.ReportViewer2.RefreshReport();
        }
        
    }
}
