﻿namespace DMM
{
    partial class Mian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mian));
            this.pn_container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btn_home = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_suppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_customer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_report = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_analysis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_settings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_about = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.txt_username = new DevExpress.XtraBars.BarStaticItem();
            this.txt_role = new DevExpress.XtraBars.BarStaticItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_container
            // 
            this.pn_container.Appearance.BackColor = System.Drawing.Color.White;
            this.pn_container.Appearance.Options.UseBackColor = true;
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 39);
            this.pn_container.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1018, 680);
            this.pn_container.TabIndex = 0;
            this.pn_container.Click += new System.EventHandler(this.pn_container_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_home,
            this.btn_suppliers,
            this.btn_customer,
            this.btn_report,
            this.btn_analysis,
            this.btn_users,
            this.btn_settings,
            this.btn_about});
            this.accordionControl1.Location = new System.Drawing.Point(1018, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(60, 680);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.Default.Options.UseFont = true;
            this.btn_home.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.ImageOptions.Image")));
            this.btn_home.Name = "btn_home";
            this.btn_home.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_home.Text = "الرئيسة";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers.Appearance.Default.Options.UseFont = true;
            this.btn_suppliers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suppliers.ImageOptions.Image")));
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_suppliers.Text = "الموردين";
            this.btn_suppliers.Click += new System.EventHandler(this.btn_suppliers_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Appearance.Default.Options.UseFont = true;
            this.btn_customer.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_customer.ImageOptions.Image")));
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_customer.Text = "العملاء";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_report
            // 
            this.btn_report.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Appearance.Default.Options.UseFont = true;
            this.btn_report.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_report.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.ImageOptions.Image")));
            this.btn_report.Name = "btn_report";
            this.btn_report.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_report.Text = "التقارير";
            this.btn_report.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // btn_analysis
            // 
            this.btn_analysis.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.Appearance.Default.Options.UseFont = true;
            this.btn_analysis.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_analysis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_analysis.ImageOptions.Image")));
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_analysis.Text = "تحليل";
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Default.Options.UseFont = true;
            this.btn_users.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.ImageOptions.Image")));
            this.btn_users.Name = "btn_users";
            this.btn_users.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_users.Text = "المستخدمين";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Appearance.Default.Options.UseFont = true;
            this.btn_settings.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_settings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.ImageOptions.Image")));
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_settings.Text = "الاعدادات";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_about
            // 
            this.btn_about.Appearance.Default.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Appearance.Default.Options.UseFont = true;
            this.btn_about.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_about.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.ImageOptions.Image")));
            this.btn_about.Name = "btn_about";
            this.btn_about.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_about.Text = "حول";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txt_username,
            this.txt_role,
            this.btn_logout});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1078, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txt_username);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txt_role);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btn_logout);
            // 
            // txt_username
            // 
            this.txt_username.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_username.Caption = "رياض أبو غريس";
            this.txt_username.Id = 0;
            this.txt_username.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ItemAppearance.Normal.Options.UseFont = true;
            this.txt_username.Name = "txt_username";
            // 
            // txt_role
            // 
            this.txt_role.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_role.Caption = "مدير";
            this.txt_role.Id = 1;
            this.txt_role.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.ItemAppearance.Normal.Options.UseFont = true;
            this.txt_role.Name = "txt_role";
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "تسجيل الخروج";
            this.btn_logout.Id = 2;
            this.btn_logout.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_logout_ItemClick);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txt_username,
            this.txt_role,
            this.btn_logout});
            this.fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // Mian
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 719);
            this.ControlContainer = this.pn_container;
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Mian.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Mian";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Mian_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mian_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pn_container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_home;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_suppliers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_customer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_analysis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_about;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
        public DevExpress.XtraBars.BarStaticItem txt_username;
        public DevExpress.XtraBars.BarStaticItem txt_role;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btn_report;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btn_users;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btn_settings;
    }
}

