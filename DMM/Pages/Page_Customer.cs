using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DMM.AddPages;

namespace DMM.Pages
{
    public partial class Page_Customer : DevExpress.XtraEditors.XtraUserControl
    {// DataBase and Tables
        DBDMMEntities db;
        TB_Customer tbAdd;
        int id;
        public Page_Customer()
        {
            InitializeComponent();
            loadData();


       
        }
        // LOAD data 
        public void loadData()
        {
            DMM.DBDMMEntities dbContext = new DMM.DBDMMEntities();
           
            dbContext.TB_Customer.Load();
           
            gridControl1.DataSource = dbContext.TB_Customer.Local.ToBindingList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DMM.AddPages.Add_Customer add = new AddPages.Add_Customer();
            add.id = 0;
            add.btn_add.Text = "اضافة";
            add.btn_addClose.Text = "غلق +اضافة";
            add.page = this;
            add.Show();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if(id> 0)
                {
                    db = new DMM.DBDMMEntities();
                    tbAdd=db.TB_Customer.Where(x=>x.ID==id).FirstOrDefault();
                    DMM.AddPages.Add_Customer add = new AddPages.Add_Customer();
                    add.id = id;
                    add.btn_add.Text = "تعديل";
                    add.btn_addClose.Text = "غلق +تعديل";
                    add.edt_name.Text = tbAdd.FullName;
                    add.edt_address.Text = tbAdd.Address;
                    add.edt_phone.Text = tbAdd.Phone;
                    add.page = this;
                    add.Show();

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }
            catch
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DMM.DBDMMEntities();
                        tbAdd = db.TB_Customer.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = EntityState.Deleted;
                        db.SaveChanges();
                       loadData();
                       
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
         
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DMM.DBDMMEntities();
                    tbAdd = db.TB_Customer.Where(x => x.ID == id).FirstOrDefault();
                    DMM.AddPages.Log_Customer add = new AddPages.Log_Customer();
                   add.txt_id.Text=id.ToString();
                    add.txt_name.Text = tbAdd.FullName.ToString();
                    add.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }
            catch
            {

            }
        }
    }
}
