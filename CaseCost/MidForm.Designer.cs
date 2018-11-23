namespace CaseCost
{
    partial class MidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MidForm));
            this.picItems = new System.Windows.Forms.PictureBox();
            this.picProcedures = new System.Windows.Forms.PictureBox();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.lblItems = new MetroFramework.Controls.MetroLabel();
            this.lblProcedures = new MetroFramework.Controls.MetroLabel();
            this.lblUsers = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // picItems
            // 
            this.picItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picItems.Image = ((System.Drawing.Image)(resources.GetObject("picItems.Image")));
            this.picItems.Location = new System.Drawing.Point(55, 104);
            this.picItems.Name = "picItems";
            this.picItems.Size = new System.Drawing.Size(100, 93);
            this.picItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItems.TabIndex = 0;
            this.picItems.TabStop = false;
            this.picItems.Click += new System.EventHandler(this.picItems_Click);
            this.picItems.MouseLeave += new System.EventHandler(this.picItems_MouseLeave);
            this.picItems.MouseHover += new System.EventHandler(this.picItems_MouseHover);
            // 
            // picProcedures
            // 
            this.picProcedures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProcedures.Image = ((System.Drawing.Image)(resources.GetObject("picProcedures.Image")));
            this.picProcedures.Location = new System.Drawing.Point(236, 104);
            this.picProcedures.Name = "picProcedures";
            this.picProcedures.Size = new System.Drawing.Size(100, 93);
            this.picProcedures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcedures.TabIndex = 1;
            this.picProcedures.TabStop = false;
            this.picProcedures.Click += new System.EventHandler(this.picProcedures_Click);
            this.picProcedures.MouseLeave += new System.EventHandler(this.picProcedures_MouseLeave);
            this.picProcedures.MouseHover += new System.EventHandler(this.picProcedures_MouseHover);
            // 
            // picUsers
            // 
            this.picUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUsers.Image = ((System.Drawing.Image)(resources.GetObject("picUsers.Image")));
            this.picUsers.Location = new System.Drawing.Point(416, 104);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(100, 93);
            this.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsers.TabIndex = 2;
            this.picUsers.TabStop = false;
            this.picUsers.Click += new System.EventHandler(this.picUsers_Click);
            this.picUsers.MouseLeave += new System.EventHandler(this.picUsers_MouseLeave);
            this.picUsers.MouseHover += new System.EventHandler(this.picUsers_MouseHover);
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItems.AutoSize = true;
            this.lblItems.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblItems.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblItems.Location = new System.Drawing.Point(77, 201);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(56, 25);
            this.lblItems.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItems.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblItems.UseStyleColors = true;
            this.lblItems.WrapToLine = true;
            // 
            // lblProcedures
            // 
            this.lblProcedures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcedures.AutoSize = true;
            this.lblProcedures.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProcedures.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProcedures.Location = new System.Drawing.Point(236, 201);
            this.lblProcedures.Name = "lblProcedures";
            this.lblProcedures.Size = new System.Drawing.Size(100, 25);
            this.lblProcedures.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblProcedures.TabIndex = 1;
            this.lblProcedures.Text = "Procedures";
            this.lblProcedures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProcedures.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProcedures.UseStyleColors = true;
            this.lblProcedures.WrapToLine = true;
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsers.Location = new System.Drawing.Point(439, 201);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(55, 25);
            this.lblUsers.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Users";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsers.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblUsers.UseStyleColors = true;
            this.lblUsers.WrapToLine = true;
            // 
            // MidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 331);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblProcedures);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.picProcedures);
            this.Controls.Add(this.picItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MidForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picItems;
        private System.Windows.Forms.PictureBox picProcedures;
        private System.Windows.Forms.PictureBox picUsers;
        private MetroFramework.Controls.MetroLabel lblItems;
        private MetroFramework.Controls.MetroLabel lblProcedures;
        private MetroFramework.Controls.MetroLabel lblUsers;
    }
}