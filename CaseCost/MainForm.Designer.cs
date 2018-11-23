using System.Windows.Forms;
using CaseCost.CaseCostDataSet1TableAdapters;
using CaseCost.ItemsNameCBTableAdapters;
using MetroFramework.Controls;

namespace CaseCost
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.InvoiceDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbProcedureName = new MetroFramework.Controls.MetroComboBox();
            this.proceduresTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseCostDataSet1 = new CaseCost.CaseCostDataSet1();
            this.itemsTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsNameCB = new CaseCost.ItemsNameCB();
            this.proceduresTTableAdapter = new CaseCost.CaseCostDataSet1TableAdapters.ProceduresTTableAdapter();
            this.itemsTTableAdapter = new CaseCost.ItemsNameCBTableAdapters.ItemsTTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblname = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnDeleteInv = new MetroFramework.Controls.MetroButton();
            this.btnUpdateInv = new MetroFramework.Controls.MetroButton();
            this.btnAddInv = new MetroFramework.Controls.MetroButton();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantityInv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtUnitPriceInv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbItemInv = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnPreviewAll = new MetroFramework.Controls.MetroButton();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnMakeInv = new MetroFramework.Controls.MetroButton();
            this.btnNewInv = new MetroFramework.Controls.MetroButton();
            this.InvGridView = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseCostDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNameCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(728, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Date";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.WrapToLine = true;
            // 
            // InvoiceDatePicker
            // 
            this.InvoiceDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceDatePicker.CustomFormat = "dd/MM/yyyy";
            this.InvoiceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InvoiceDatePicker.Location = new System.Drawing.Point(781, 166);
            this.InvoiceDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.InvoiceDatePicker.Name = "InvoiceDatePicker";
            this.InvoiceDatePicker.Size = new System.Drawing.Size(131, 29);
            this.InvoiceDatePicker.TabIndex = 3;
            this.InvoiceDatePicker.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(98, 170);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Procedure";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.WrapToLine = true;
            // 
            // cmbProcedureName
            // 
            this.cmbProcedureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProcedureName.DataSource = this.proceduresTBindingSource;
            this.cmbProcedureName.DisplayMember = "ProcedureName";
            this.cmbProcedureName.FormattingEnabled = true;
            this.cmbProcedureName.ItemHeight = 23;
            this.cmbProcedureName.Location = new System.Drawing.Point(194, 168);
            this.cmbProcedureName.Name = "cmbProcedureName";
            this.cmbProcedureName.Size = new System.Drawing.Size(273, 29);
            this.cmbProcedureName.TabIndex = 1;
            this.cmbProcedureName.UseSelectable = true;
            this.cmbProcedureName.UseStyleColors = true;
            this.cmbProcedureName.ValueMember = "ID";
            // 
            // proceduresTBindingSource
            // 
            this.proceduresTBindingSource.DataMember = "ProceduresT";
            this.proceduresTBindingSource.DataSource = this.caseCostDataSet1;
            // 
            // caseCostDataSet1
            // 
            this.caseCostDataSet1.DataSetName = "CaseCostDataSet1";
            this.caseCostDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTBindingSource
            // 
            this.itemsTBindingSource.DataMember = "ItemsT";
            this.itemsTBindingSource.DataSource = this.itemsNameCB;
            // 
            // itemsNameCB
            // 
            this.itemsNameCB.DataSetName = "ItemsNameCB";
            this.itemsNameCB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proceduresTTableAdapter
            // 
            this.proceduresTTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTTableAdapter
            // 
            this.itemsTTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1069, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblname.Location = new System.Drawing.Point(107, 21);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(94, 25);
            this.lblname.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Welcome: ";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblname.UseStyleColors = true;
            this.lblname.WrapToLine = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1010, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(40, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Items";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.WrapToLine = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.btnDeleteInv);
            this.metroPanel4.Controls.Add(this.btnUpdateInv);
            this.metroPanel4.Controls.Add(this.btnAddInv);
            this.metroPanel4.Controls.Add(this.txtTotal);
            this.metroPanel4.Controls.Add(this.metroLabel7);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.txtQuantityInv);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.txtUnitPriceInv);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.cbItemInv);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(40, 271);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1079, 159);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.VerticalScrollbarBarColor = false;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnDeleteInv
            // 
            this.btnDeleteInv.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInv.DisplayFocus = true;
            this.btnDeleteInv.Enabled = false;
            this.btnDeleteInv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeleteInv.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDeleteInv.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteInv.Location = new System.Drawing.Point(958, 60);
            this.btnDeleteInv.Name = "btnDeleteInv";
            this.btnDeleteInv.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDeleteInv.TabIndex = 4;
            this.btnDeleteInv.Text = "Remove";
            this.btnDeleteInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeleteInv.UseCustomForeColor = true;
            this.btnDeleteInv.UseSelectable = true;
            this.btnDeleteInv.UseStyleColors = true;
            this.btnDeleteInv.Click += new System.EventHandler(this.btnDeleteInv_Click);
            // 
            // btnUpdateInv
            // 
            this.btnUpdateInv.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateInv.DisplayFocus = true;
            this.btnUpdateInv.Enabled = false;
            this.btnUpdateInv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdateInv.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnUpdateInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(219)))));
            this.btnUpdateInv.Location = new System.Drawing.Point(840, 60);
            this.btnUpdateInv.Name = "btnUpdateInv";
            this.btnUpdateInv.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdateInv.TabIndex = 3;
            this.btnUpdateInv.Text = "Edit";
            this.btnUpdateInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdateInv.UseCustomForeColor = true;
            this.btnUpdateInv.UseSelectable = true;
            this.btnUpdateInv.UseStyleColors = true;
            this.btnUpdateInv.Click += new System.EventHandler(this.btnUpdateInv_Click);
            // 
            // btnAddInv
            // 
            this.btnAddInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(219)))));
            this.btnAddInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddInv.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAddInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(209)))), ((int)(((byte)(48)))));
            this.btnAddInv.Location = new System.Drawing.Point(722, 60);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(75, 36);
            this.btnAddInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddInv.TabIndex = 2;
            this.btnAddInv.Text = "Add";
            this.btnAddInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddInv.UseCustomBackColor = true;
            this.btnAddInv.UseCustomForeColor = true;
            this.btnAddInv.UseSelectable = true;
            this.btnAddInv.UseStyleColors = true;
            this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(511, 64);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PromptText = "Price";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 30);
            this.txtTotal.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMark = "Price";
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(481, 67);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(24, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "=";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = true;
            this.metroLabel7.WrapToLine = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(274, 88);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Quantity";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = true;
            this.metroLabel6.WrapToLine = true;
            // 
            // txtQuantityInv
            // 
            // 
            // 
            // 
            this.txtQuantityInv.CustomButton.Image = null;
            this.txtQuantityInv.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtQuantityInv.CustomButton.Name = "";
            this.txtQuantityInv.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtQuantityInv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantityInv.CustomButton.TabIndex = 1;
            this.txtQuantityInv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantityInv.CustomButton.UseSelectable = true;
            this.txtQuantityInv.CustomButton.Visible = false;
            this.txtQuantityInv.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQuantityInv.Lines = new string[0];
            this.txtQuantityInv.Location = new System.Drawing.Point(365, 85);
            this.txtQuantityInv.MaxLength = 32767;
            this.txtQuantityInv.Name = "txtQuantityInv";
            this.txtQuantityInv.PasswordChar = '\0';
            this.txtQuantityInv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantityInv.SelectedText = "";
            this.txtQuantityInv.SelectionLength = 0;
            this.txtQuantityInv.SelectionStart = 0;
            this.txtQuantityInv.ShortcutsEnabled = true;
            this.txtQuantityInv.Size = new System.Drawing.Size(111, 30);
            this.txtQuantityInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantityInv.TabIndex = 1;
            this.txtQuantityInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantityInv.UseSelectable = true;
            this.txtQuantityInv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantityInv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantityInv.TextChanged += new System.EventHandler(this.txtQuantityInv_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(273, 47);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Unit Price";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.WrapToLine = true;
            // 
            // txtUnitPriceInv
            // 
            // 
            // 
            // 
            this.txtUnitPriceInv.CustomButton.Image = null;
            this.txtUnitPriceInv.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtUnitPriceInv.CustomButton.Name = "";
            this.txtUnitPriceInv.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUnitPriceInv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitPriceInv.CustomButton.TabIndex = 1;
            this.txtUnitPriceInv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitPriceInv.CustomButton.UseSelectable = true;
            this.txtUnitPriceInv.CustomButton.Visible = false;
            this.txtUnitPriceInv.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUnitPriceInv.Lines = new string[0];
            this.txtUnitPriceInv.Location = new System.Drawing.Point(364, 44);
            this.txtUnitPriceInv.MaxLength = 32767;
            this.txtUnitPriceInv.Name = "txtUnitPriceInv";
            this.txtUnitPriceInv.PasswordChar = '\0';
            this.txtUnitPriceInv.ReadOnly = true;
            this.txtUnitPriceInv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitPriceInv.SelectedText = "";
            this.txtUnitPriceInv.SelectionLength = 0;
            this.txtUnitPriceInv.SelectionStart = 0;
            this.txtUnitPriceInv.ShortcutsEnabled = true;
            this.txtUnitPriceInv.Size = new System.Drawing.Size(111, 30);
            this.txtUnitPriceInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitPriceInv.TabIndex = 7;
            this.txtUnitPriceInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitPriceInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitPriceInv.UseSelectable = true;
            this.txtUnitPriceInv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitPriceInv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Item";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.WrapToLine = true;
            // 
            // cbItemInv
            // 
            this.cbItemInv.DataSource = this.itemsTBindingSource;
            this.cbItemInv.DisplayMember = "Name";
            this.cbItemInv.FormattingEnabled = true;
            this.cbItemInv.ItemHeight = 23;
            this.cbItemInv.Location = new System.Drawing.Point(54, 9);
            this.cbItemInv.Name = "cbItemInv";
            this.cbItemInv.Size = new System.Drawing.Size(212, 29);
            this.cbItemInv.TabIndex = 1;
            this.cbItemInv.UseSelectable = true;
            this.cbItemInv.UseStyleColors = true;
            this.cbItemInv.ValueMember = "ItemID";
            this.cbItemInv.SelectionChangeCommitted += new System.EventHandler(this.cbItemInv_SelectionChangeCommitted);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.btnPreviewAll);
            this.metroPanel5.Controls.Add(this.btnPreview);
            this.metroPanel5.Controls.Add(this.btnMakeInv);
            this.metroPanel5.Controls.Add(this.btnNewInv);
            this.metroPanel5.Controls.Add(this.InvGridView);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(20, 508);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(1116, 217);
            this.metroPanel5.TabIndex = 5;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // btnPreviewAll
            // 
            this.btnPreviewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPreviewAll.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnPreviewAll.Location = new System.Drawing.Point(979, 163);
            this.btnPreviewAll.Name = "btnPreviewAll";
            this.btnPreviewAll.Size = new System.Drawing.Size(120, 34);
            this.btnPreviewAll.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPreviewAll.TabIndex = 4;
            this.btnPreviewAll.Text = "Preview All";
            this.btnPreviewAll.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPreviewAll.UseSelectable = true;
            this.btnPreviewAll.UseStyleColors = true;
            this.btnPreviewAll.Click += new System.EventHandler(this.btnPreviewAll_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Enabled = false;
            this.btnPreview.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPreview.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnPreview.Location = new System.Drawing.Point(979, 113);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(120, 34);
            this.btnPreview.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview Last";
            this.btnPreview.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPreview.UseSelectable = true;
            this.btnPreview.UseStyleColors = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnMakeInv
            // 
            this.btnMakeInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeInv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMakeInv.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMakeInv.Location = new System.Drawing.Point(979, 63);
            this.btnMakeInv.Name = "btnMakeInv";
            this.btnMakeInv.Size = new System.Drawing.Size(120, 34);
            this.btnMakeInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnMakeInv.TabIndex = 2;
            this.btnMakeInv.Text = "Make Invoice";
            this.btnMakeInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnMakeInv.UseSelectable = true;
            this.btnMakeInv.UseStyleColors = true;
            this.btnMakeInv.Click += new System.EventHandler(this.btnMakeInv_Click);
            // 
            // btnNewInv
            // 
            this.btnNewInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewInv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewInv.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewInv.Location = new System.Drawing.Point(979, 13);
            this.btnNewInv.Name = "btnNewInv";
            this.btnNewInv.Size = new System.Drawing.Size(120, 34);
            this.btnNewInv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNewInv.TabIndex = 0;
            this.btnNewInv.Text = "New";
            this.btnNewInv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNewInv.UseSelectable = true;
            this.btnNewInv.UseStyleColors = true;
            this.btnNewInv.Click += new System.EventHandler(this.btnNewInv_Click);
            // 
            // InvGridView
            // 
            this.InvGridView.AllowUserToDeleteRows = false;
            this.InvGridView.AllowUserToResizeRows = false;
            this.InvGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InvGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ItemID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.InvGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.InvGridView.EnableHeadersVisualStyles = false;
            this.InvGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InvGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvGridView.Location = new System.Drawing.Point(0, 0);
            this.InvGridView.Name = "InvGridView";
            this.InvGridView.ReadOnly = true;
            this.InvGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InvGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InvGridView.RowTemplate.Height = 30;
            this.InvGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvGridView.Size = new System.Drawing.Size(897, 217);
            this.InvGridView.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvGridView.TabIndex = 1;
            this.InvGridView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvGridView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "UnitPrice";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SubTotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1156, 745);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbProcedureName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.InvoiceDatePicker);
            this.Controls.Add(this.lblname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proceduresTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseCostDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNameCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbProcedureName;
        private MetroFramework.Controls.MetroDateTime InvoiceDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private CaseCostDataSet1 caseCostDataSet1;
        private System.Windows.Forms.BindingSource proceduresTBindingSource;
        private CaseCostDataSet1TableAdapters.ProceduresTTableAdapter proceduresTTableAdapter;
        private ItemsNameCB itemsNameCB;
        private System.Windows.Forms.BindingSource itemsTBindingSource;
        private ItemsNameCBTableAdapters.ItemsTTableAdapter itemsTTableAdapter;
        private PictureBox pictureBox1;
        private MetroLabel lblname;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MetroLabel metroLabel3;
        private MetroPanel metroPanel4;
        private MetroButton btnDeleteInv;
        private MetroButton btnUpdateInv;
        private MetroButton btnAddInv;
        private MetroTextBox txtTotal;
        private MetroLabel metroLabel7;
        private MetroLabel metroLabel6;
        private MetroTextBox txtQuantityInv;
        private MetroLabel metroLabel5;
        private MetroTextBox txtUnitPriceInv;
        private MetroLabel metroLabel4;
        private MetroComboBox cbItemInv;
        private MetroPanel metroPanel5;
        private MetroButton btnPreviewAll;
        private MetroButton btnPreview;
        private MetroButton btnMakeInv;
        private MetroButton btnNewInv;
        private MetroGrid InvGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn ItemID;

        public MetroComboBox CbItemInv { get => cbItemInv; set => cbItemInv = value; }
        public BindingSource ItemsTBindingSource { get => itemsTBindingSource; set => itemsTBindingSource = value; }
        public ItemsTTableAdapter ItemsTTableAdapter { get => itemsTTableAdapter; set => itemsTTableAdapter = value; }
        public ItemsNameCB ItemsNameCB { get => itemsNameCB; set => itemsNameCB = value; }
        public ProceduresTTableAdapter ProceduresTTableAdapter { get => proceduresTTableAdapter; set => proceduresTTableAdapter = value; }
        public MetroComboBox CmbProcedureName { get => cmbProcedureName; set => cmbProcedureName = value; }
        public CaseCostDataSet1 CaseCostDataSet1 { get => caseCostDataSet1; set => caseCostDataSet1 = value; }
    }
}