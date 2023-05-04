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
    public partial class Add_Customer : DevExpress.XtraEditors.XtraForm
    {

        // DataBase and Tables
        DBDMMEntities db;
        TB_Customer tbAdd;
        public DMM.Pages.Page_Customer page;

        // other var
        public int id;
        public Add_Customer()
        {
            InitializeComponent();
        }

        // add function

        private void add()
        {//check empty value
            if (edt_name.Text == "")
            {
                MessageBox.Show("بعض الحقول مطلوبة", "بعض الحقول مطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // check if add or edit
                if (id == 0)
                {//add
                    addData();
                    ClearData();
                }
                else
                {//edit
                    addEdit();
                }

                // update data
                page.loadData();
            }
        }

        // add data
        private void addData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_Customer { 
                    FullName = edt_name.Text,
                    Address = edt_address.Text,
                    Phone = edt_phone.Text,
                    DateT = DateTime.Now,
                    Debit=0
                };
                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("d718b50d-93f9-441b-b7b1-e3e62feac8e2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // edit data
        private void addEdit()
        {

            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_Customer
                {
                    ID = id,
                    FullName = edt_name.Text,
                    Address = edt_address.Text,
                    Phone = edt_phone.Text,
                    DateT = DateTime.Now
                };
                db.Set<TB_Customer>().AddOrUpdate(tbAdd);
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("b88fef89-fa32-4da2-818d-d715df3fecaa");

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
            edt_address.Text = edt_name.Text = edt_phone.Text = "";
        }
    }
}