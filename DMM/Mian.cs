using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMM.Pages;
using System.Threading.Tasks;
using System.IO;

namespace DMM
{
    public partial class Mian : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Mian()
        {
            InitializeComponent();
            LoadHomePage();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            ReportPage page = new ReportPage();
            LoadPage(page);
        }

        private void pn_container_Click(object sender, EventArgs e)
        {

        }
        // void for load home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadHomePage();

        }
        // load page

        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                pn_container.Controls.Clear();
                Page.Dock=DockStyle.Fill;
                pn_container.Controls.Add(Page);    
            }
            catch
            {

            }
        }

        private void LoadHomePage()
        {
            Page_Home page = new Page_Home();
            LoadPage(page);
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            Page_Suppliers page = new Page_Suppliers();
            LoadPage(page);
        }

        private async void Mian_Activated(object sender, EventArgs e)
        {
            BL.Updata Update = new BL.Updata();
           await Task.Run(()=> Update.SuppliersDataUpdate()); 
            await Task.Run(() => Update.CustomerDataUpdate());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Page_Customer page = new Page_Customer();
            LoadPage(page);
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {

            AnaylisisPage page = new AnaylisisPage();
            LoadPage(page);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {

            Page_User page = new Page_User();
            LoadPage(page);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FRM_Setting fRM_Setting = new FRM_Setting();
            fRM_Setting.ShowDialog();
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
           AddPages.FRM_UserLogin fRM_User=new AddPages.FRM_UserLogin();
            fRM_User.Show();
          this.Hide();
        }

        private void Mian_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {

            FRM_About fRM_about = new FRM_About();
            fRM_about.ShowDialog();
        }
      
    }
}
