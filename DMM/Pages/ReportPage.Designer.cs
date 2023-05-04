namespace DMM.Pages
{
    partial class ReportPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.btn_suplierReport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_customerReport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_suplierReport
            // 
            this.btn_suplierReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_suplierReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_suplierReport.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suplierReport.Appearance.Options.UseBackColor = true;
            this.btn_suplierReport.Appearance.Options.UseFont = true;
            this.btn_suplierReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suplierReport.ImageOptions.Image")));
            this.btn_suplierReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_suplierReport.Location = new System.Drawing.Point(268, 16);
            this.btn_suplierReport.Name = "btn_suplierReport";
            this.btn_suplierReport.Size = new System.Drawing.Size(174, 68);
            this.btn_suplierReport.TabIndex = 5;
            this.btn_suplierReport.Text = "تقرير ديون الموردين";
            this.btn_suplierReport.Click += new System.EventHandler(this.btn_suplierReport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_customerReport);
            this.panel1.Controls.Add(this.btn_suplierReport);
            this.panel1.Location = new System.Drawing.Point(250, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 99);
            this.panel1.TabIndex = 6;
            // 
            // btn_customerReport
            // 
            this.btn_customerReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_customerReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btn_customerReport.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerReport.Appearance.Options.UseBackColor = true;
            this.btn_customerReport.Appearance.Options.UseFont = true;
            this.btn_customerReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_customerReport.ImageOptions.Image")));
            this.btn_customerReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_customerReport.Location = new System.Drawing.Point(29, 16);
            this.btn_customerReport.Name = "btn_customerReport";
            this.btn_customerReport.Size = new System.Drawing.Size(174, 68);
            this.btn_customerReport.TabIndex = 6;
            this.btn_customerReport.Text = "تقرير ديون العملاء";
            this.btn_customerReport.Click += new System.EventHandler(this.btn_customerReport_Click);
            // 
            // ReportPage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReportPage";
            this.Size = new System.Drawing.Size(964, 646);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_suplierReport;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_customerReport;
    }
}
