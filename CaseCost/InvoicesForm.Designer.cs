using CaseCost.rdlcDataSetTableAdapters;
using MetroFramework.Controls;
using Microsoft.Reporting.WinForms;

namespace CaseCost
{
    partial class InvoicesForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.QueryInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdlcDataSet = new CaseCost.rdlcDataSet();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataPicker_InvBeganData = new MetroFramework.Controls.MetroDateTime();
            this.cbSelectInv = new MetroFramework.Controls.MetroComboBox();
            this.costTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSelectInvDataSet = new CaseCost.cbSelectInvDataSet();
            this.costTTableAdapter = new CaseCost.cbSelectInvDataSetTableAdapters.CostTTableAdapter();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DataPicker_InvEndData = new MetroFramework.Controls.MetroDateTime();
            this.btnLoadInv = new MetroFramework.Controls.MetroButton();
            this.btnInvDataLoad = new MetroFramework.Controls.MetroButton();
            this.QueryInvoiceTableAdapter = new CaseCost.rdlcDataSetTableAdapters.QueryInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QueryInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdlcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectInvDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryInvoiceBindingSource
            // 
            this.QueryInvoiceBindingSource.DataMember = "QueryInvoice";
            this.QueryInvoiceBindingSource.DataSource = this.rdlcDataSet;
            // 
            // rdlcDataSet
            // 
            this.rdlcDataSet.DataSetName = "rdlcDataSet";
            this.rdlcDataSet.EnforceConstraints = false;
            this.rdlcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "rdlcDataSet";
            reportDataSource1.Value = this.QueryInvoiceBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CaseCost.rdlcReportInvoice.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(20, 141);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.ShowBackButton = false;
            this.reportViewer2.ShowFindControls = false;
            this.reportViewer2.ShowPageNavigationControls = false;
            this.reportViewer2.Size = new System.Drawing.Size(862, 500);
            this.reportViewer2.TabIndex = 8;
            // 
            // DataPicker_InvBeganData
            // 
            this.DataPicker_InvBeganData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPicker_InvBeganData.CustomFormat = "dd/MM/yyyy";
            this.DataPicker_InvBeganData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataPicker_InvBeganData.Location = new System.Drawing.Point(465, 83);
            this.DataPicker_InvBeganData.MinimumSize = new System.Drawing.Size(0, 29);
            this.DataPicker_InvBeganData.Name = "DataPicker_InvBeganData";
            this.DataPicker_InvBeganData.Size = new System.Drawing.Size(143, 29);
            this.DataPicker_InvBeganData.TabIndex = 4;
            this.DataPicker_InvBeganData.UseStyleColors = true;
            // 
            // cbSelectInv
            // 
            this.cbSelectInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectInv.DataSource = this.costTBindingSource;
            this.cbSelectInv.DisplayMember = "CostID";
            this.cbSelectInv.FormattingEnabled = true;
            this.cbSelectInv.ItemHeight = 23;
            this.cbSelectInv.Location = new System.Drawing.Point(170, 83);
            this.cbSelectInv.Name = "cbSelectInv";
            this.cbSelectInv.Size = new System.Drawing.Size(114, 29);
            this.cbSelectInv.TabIndex = 1;
            this.cbSelectInv.UseSelectable = true;
            this.cbSelectInv.UseStyleColors = true;
            this.cbSelectInv.ValueMember = "CostID";
            // 
            // costTBindingSource
            // 
            this.costTBindingSource.DataMember = "CostT";
            this.costTBindingSource.DataSource = this.cbSelectInvDataSet;
            // 
            // cbSelectInvDataSet
            // 
            this.cbSelectInvDataSet.DataSetName = "cbSelectInvDataSet";
            this.cbSelectInvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costTTableAdapter
            // 
            this.costTTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(32, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(138, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Invoice Number";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.WrapToLine = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(613, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "To";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(405, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "From";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.WrapToLine = true;
            // 
            // DataPicker_InvEndData
            // 
            this.DataPicker_InvEndData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPicker_InvEndData.CustomFormat = "dd/MM/yyyy";
            this.DataPicker_InvEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataPicker_InvEndData.Location = new System.Drawing.Point(649, 83);
            this.DataPicker_InvEndData.MinimumSize = new System.Drawing.Size(0, 29);
            this.DataPicker_InvEndData.Name = "DataPicker_InvEndData";
            this.DataPicker_InvEndData.Size = new System.Drawing.Size(143, 29);
            this.DataPicker_InvEndData.TabIndex = 6;
            this.DataPicker_InvEndData.UseStyleColors = true;
            // 
            // btnLoadInv
            // 
            this.btnLoadInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(219)))));
            this.btnLoadInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadInv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLoadInv.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLoadInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(209)))), ((int)(((byte)(48)))));
            this.btnLoadInv.Location = new System.Drawing.Point(290, 83);
            this.btnLoadInv.Name = "btnLoadInv";
            this.btnLoadInv.Size = new System.Drawing.Size(75, 29);
            this.btnLoadInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLoadInv.TabIndex = 2;
            this.btnLoadInv.Text = "Load";
            this.btnLoadInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLoadInv.UseCustomBackColor = true;
            this.btnLoadInv.UseCustomForeColor = true;
            this.btnLoadInv.UseSelectable = true;
            this.btnLoadInv.UseStyleColors = true;
            this.btnLoadInv.Click += new System.EventHandler(this.btnLoadInv_Click);
            // 
            // btnInvDataLoad
            // 
            this.btnInvDataLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(219)))));
            this.btnInvDataLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvDataLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnInvDataLoad.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnInvDataLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(209)))), ((int)(((byte)(48)))));
            this.btnInvDataLoad.Location = new System.Drawing.Point(804, 83);
            this.btnInvDataLoad.Name = "btnInvDataLoad";
            this.btnInvDataLoad.Size = new System.Drawing.Size(75, 29);
            this.btnInvDataLoad.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnInvDataLoad.TabIndex = 7;
            this.btnInvDataLoad.Text = "Show";
            this.btnInvDataLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnInvDataLoad.UseCustomBackColor = true;
            this.btnInvDataLoad.UseCustomForeColor = true;
            this.btnInvDataLoad.UseSelectable = true;
            this.btnInvDataLoad.UseStyleColors = true;
            this.btnInvDataLoad.Click += new System.EventHandler(this.btnInvDataLoad_Click);
            // 
            // QueryInvoiceTableAdapter
            // 
            this.QueryInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 661);
            this.Controls.Add(this.btnInvDataLoad);
            this.Controls.Add(this.btnLoadInv);
            this.Controls.Add(this.DataPicker_InvEndData);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.DataPicker_InvBeganData);
            this.Controls.Add(this.cbSelectInv);
            this.Controls.Add(this.reportViewer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InvoicesForm";
            this.Resizable = false;
            this.Text = "InvoicesForm";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueryInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdlcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectInvDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private MetroFramework.Controls.MetroDateTime DataPicker_InvBeganData;
        private MetroFramework.Controls.MetroComboBox cbSelectInv;
        private cbSelectInvDataSet cbSelectInvDataSet;
        private System.Windows.Forms.BindingSource costTBindingSource;
        private cbSelectInvDataSetTableAdapters.CostTTableAdapter costTTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime DataPicker_InvEndData;
        private MetroFramework.Controls.MetroButton btnLoadInv;
        private MetroFramework.Controls.MetroButton btnInvDataLoad;
        private System.Windows.Forms.BindingSource QueryInvoiceBindingSource;
        private rdlcDataSet rdlcDataSet;
        private rdlcDataSetTableAdapters.QueryInvoiceTableAdapter QueryInvoiceTableAdapter;

        public rdlcDataSet RdlcDataSet { get => rdlcDataSet; set => rdlcDataSet = value; }
        public QueryInvoiceTableAdapter QueryInvoiceTableAdapter1 { get => QueryInvoiceTableAdapter; set => QueryInvoiceTableAdapter = value; }
        public MetroComboBox CbSelectInv1 { get => cbSelectInv; set => cbSelectInv = value; }
        public ReportViewer ReportViewer2 { get => reportViewer2; set => reportViewer2 = value; }
    }
}