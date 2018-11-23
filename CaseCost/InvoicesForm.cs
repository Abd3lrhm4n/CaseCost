using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseCost
{
    public partial class InvoicesForm : MetroFramework.Forms.MetroForm
    {
        public static DateTime SDate;
        public static DateTime EDate;

        public object CbSelectInv { get; internal set; }

        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cbSelectInvDataSet.CostT' table. You can move, or remove it, as needed.
            this.costTTableAdapter.Fill(this.cbSelectInvDataSet.CostT);

        }

        private void btnLoadInv_Click(object sender, EventArgs e)
        {

            reportViewer2.LocalReport.DataSources.Clear();
            string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string reportPath = System.IO.Path.Combine(exeFolder, @"..\..\rdlcReportInvoice.rdlc");

            this.QueryInvoiceTableAdapter.Fill(this.rdlcDataSet.QueryInvoice, Convert.ToInt32(cbSelectInv.Text));


            reportViewer2.LocalReport.ReportPath = reportPath;
            this.reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.ReportEmbeddedResource = reportPath;
            ReportDataSource rds = new ReportDataSource("rdlcDataSet", rdlcDataSet.Tables[0]);
            reportViewer2.LocalReport.DataSources.Add(rds);


            reportViewer2.LocalReport.Refresh();
            reportViewer2.RefreshReport();
        }

        private void btnInvDataLoad_Click(object sender, EventArgs e)
        {

            SDate = DataPicker_InvBeganData.Value.Date;
            EDate = DataPicker_InvEndData.Value.Date;

            //open only one instance of form
            if (Application.OpenForms["InvDatesForm"] as InvDatesForm != null)
            {
                ((InvDatesForm)Application.OpenForms["InvDatesForm"]).Close();
                InvDatesForm frmInv = new InvDatesForm(EDate, SDate);
                frmInv.Show();
            }
            else
            {
                InvDatesForm frmInv = new InvDatesForm(EDate, SDate);
                frmInv.Show();
            }
        }
    }
}
