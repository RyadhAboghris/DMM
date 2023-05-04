using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM
{
    public partial class FRM_START : SplashScreen
    {

        DBDMMEntities db;
        int state;
        public FRM_START()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2022-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private int CheckStartApp()
        {
            try {
                db = new DBDMMEntities();
                var usernameID = db.TB_Users.Select(x => x.ID).FirstOrDefault();
                if (usernameID > 1)
                {
                   
                    state = 1;
                }
                else
                {
                   
                    state =2;

                }


            } catch { state = 0; }
            return state;
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private async void FRM_START_Load(object sender, EventArgs e)
        {
         await Task.Run(() => Thread.Sleep(2000));
            var st =await Task.Run(() => CheckStartApp());
            if (st == 0)
            {
                MessageBox.Show("هناك خطأ في الاتصال  في السيرفر");
                Application.Exit();
            }else if(st == 1)
            {
                // show login
                AddPages.FRM_UserLogin fRM_User = new AddPages.FRM_UserLogin();
                fRM_User.Show();
                this.Hide();
            }
            else
            {
                Pages.Page_User userpage = new Pages.Page_User();

                DMM.AddPages.Add_Users add = new AddPages.Add_Users();
                add.id = 0;
                add.page=userpage;
                add.btn_add.Visible = false;
                add.btn_addClose.Text = "اعادة التشغيل +اضافة";
                add.Show();
            }
        }
    }
}