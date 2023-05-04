using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.AddPages
{
    public partial class FRM_UserLogin : DevExpress.XtraEditors.XtraForm
    {

        // DataBase and Tables
        DBDMMEntities db;
        TB_Users tbAdd;
        public DMM.Pages.Page_User page;

        // other var
        public int id;
        public FRM_UserLogin()
        {
            InitializeComponent();
        }

        // add function

        private void add()
        {//check empty value
            if ( edt_username.Text == "" || edt_password.Text == "" )
            {
                MessageBox.Show("بعض الحقول مطلوبة", "بعض الحقول مطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Login();
            }
        }

        // add data
        private void Login()
        {
            Mian main = new Mian();
            try
            {
                db = new DBDMMEntities();
                tbAdd = db.TB_Users.Where(x => x.UserName == edt_username.Text && x.Password == edt_password.Text).FirstOrDefault();
                if (tbAdd!=null)
                {
                    if (tbAdd.Role == "مستخدم")
                    {
                        main.btn_report.Visible = false;
                        main.btn_settings.Visible = false;
                        main.btn_users.Visible = false;
                    }

                    main.txt_username.Caption = tbAdd.FullName;
                    main.txt_role.Caption = tbAdd.Role;

                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("هناك خطأ في معلومات تسجيل الدخول");
                }
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        // Add void


        private void btn_add_Click(object sender, EventArgs e)
        {
            add();
           
        }
        // add and close

        private void btn_addClose_Click(object sender, EventArgs e)
        {
            add();
            this.Close();

        }

        // clear value
        private void ClearData()
        {
            edt_password.Text = edt_username.Text = "";
        }

        private void FRM_UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}