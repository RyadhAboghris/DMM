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
using System.Data.Entity.Migrations;
using DevExpress.XtraGrid;
using System.Threading;

namespace DMM.AddPages
{
    public partial class Log_Supplier : DevExpress.XtraEditors.XtraForm
    { // DataBase and Tables
        DBDMMEntities db;
        Debit_Supplier tbAdd;
        PaymentSupplier tbPayment;
        int id;
        int supplierID;
        string paymentvalue;

        double payment=0, debit, paymentRs;
        public Log_Supplier()
        {
            InitializeComponent();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        // load Debit Data
        public void loadDebitData()
        {

            try
            {
                id = Convert.ToInt16(txt_id.Text);
                db = new DBDMMEntities();
                gridControl1.DataSource = db.Debit_Supplier.Where(x => x.ID_Supplier == id).ToList();

            }
            catch
            {

            }





        }
        // load payment data

        private void loadPaymentData()
        {

            try
            {
                id = Convert.ToInt16(txt_id.Text);
                db = new DBDMMEntities();
                gridControl2.DataSource = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).ToList();

            }
            catch
            {

            }

        }

        private void Log_Supplier_Load(object sender, EventArgs e)
        {
            loadPaymentData();
            loadDebitData();
        }

        private void btn_adddebit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(txt_id.Text);
            var SupplierName = txt_name.Text;
            DMM.AddPages.Add_DebitSupplier add = new AddPages.Add_DebitSupplier();
            add.id = 0;
            add.btn_add.Text = "اضافة";
            add.btn_addClose.Text = "غلق +اضافة";
            add.page = this;
            add.SupplierId = id;
            add.SupplierName = SupplierName;
            add.Show();
        }

        private void btn_editdebit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DMM.DBDMMEntities();
                    var supplierid = Convert.ToInt16(txt_id.Text);
                    var SupplierName = txt_name.Text;
                    DMM.AddPages.Add_DebitSupplier add = new AddPages.Add_DebitSupplier();
                    add.id = id;
                    add.btn_add.Text = "تعديل";
                    add.btn_addClose.Text = "غلق +تعديل";
                    add.page = this;
                    add.SupplierId = supplierid;
                    add.SupplierName = SupplierName;
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("FullName"));
                    add.edt_debit.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Debit"));
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
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DMM.DBDMMEntities();
                        tbAdd = db.Debit_Supplier.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = EntityState.Deleted;
                        db.SaveChanges();
                        loadDebitData();
                        DebitPaymentCal();

                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            paymentvalue = XtraInputBox.Show("اكتب المبلغ المراد دفعه","عمل دفعة","0");
            if(paymentvalue != "0" && paymentvalue != "")
            {
                // make paument
                AddPayment();
                loadPaymentData();
                MessageBox.Show("تم عمل الدفعة بنجاح");
            }
            else
            {
                MessageBox.Show("اكتب المبلغ المراد دفعه اولا");
            }
        }
        private void AddPayment()
        {
            try
            {

                
                db = new DBDMMEntities();
                supplierID=Convert.ToInt32(txt_id.Text);
                var SupplierTime = txt_name.Text;              
                var tbpayment = new PaymentSupplier
                {
                   
                    Payment = paymentvalue,
                SupplierName = SupplierTime,
                ID_Supplier= supplierID,
                    DateT = DateTime.Now
                };
                db.Entry(tbpayment).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pymentedit_Click(object sender, EventArgs e)
        {
            string currValue = Convert.ToString(gridView2.GetFocusedRowCellValue("Payment"));
            paymentvalue = XtraInputBox.Show("اكتب المبلغ المراد دفعه", "عمل دفعة", currValue);
            if (paymentvalue != "0" && paymentvalue != "")
            {
                // Edit paument
                EditPayment();
                loadPaymentData();
                MessageBox.Show("تم عمل الدفعة بنجاح");
            }
            else
            {
                MessageBox.Show("اكتب المبلغ المراد دفعه اولا");
            }
        }

        private void EditPayment()
        {
            try
            {
                id = Convert.ToInt16(gridView2.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    supplierID = Convert.ToInt32(txt_id.Text);
                    var SupplierTime = txt_name.Text;
                    var tbpayment = new PaymentSupplier
                    {
                        ID = id,

                        Payment = paymentvalue,
                        SupplierName = SupplierTime,
                        ID_Supplier = supplierID,
                        DateT = DateTime.Now
                    };
                    db.Set<PaymentSupplier>().AddOrUpdate(tbpayment);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_paymentdelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt16(gridView2.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DMM.DBDMMEntities();
                        tbPayment = db.PaymentSuppliers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbPayment).State = EntityState.Deleted;
                        db.SaveChanges();
                        loadPaymentData();
                        DebitPaymentCal();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Log_Supplier_Activated(object sender, EventArgs e)
        {
            DebitPaymentCal();
        }

        private async void btn_logclear_Click(object sender, EventArgs e)
        {

            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {      // loading ...
                this.Text = "الرجاء الانتظار بينما يتم تنظيف السجل";
                Thread.Sleep(500);
                // clear debit
                this.Text = "تنظيف سجل الديون .....";

                await Task.Run(() => logDebitClearData());
                //clear payment
                this.Text = "تنظيف سجل الدفعات .....";

                await Task.Run(() => logpaymentClearData());
                MessageBox.Show("تم تنظيف السجل بنجاح");
                this.Text = "سجل الموردين";
                loadPaymentData();
                loadDebitData();
            }
           

        }
        // clear debit data
        private void logDebitClearData()
        {
           
            try
            {
                id = Convert.ToInt16(txt_id.Text); 
                db = new DBDMMEntities();
                var debit_list = db.Debit_Supplier.Select(x => x.ID).ToArray();
            for(int i = 0; i < debit_list.Length; i++)
                {
                    tbAdd = db.Debit_Supplier.Where(x => x.ID_Supplier == id).FirstOrDefault();
                    db.Entry(tbAdd).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            
            
            
            }
            catch
            {

            }
        }
        // clear payment data
        private void logpaymentClearData()
        {

            try
            {
                id = Convert.ToInt16(txt_id.Text);
                db = new DBDMMEntities();
                var debit_list = db.PaymentSuppliers.Select(x => x.ID).ToArray();
                for (int i = 0; i < debit_list.Length; i++)
                {
                    tbPayment = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).FirstOrDefault();
                    db.Entry(tbPayment).State = EntityState.Deleted;
                    db.SaveChanges();
                }



            }
            catch
            {

            }
        }

        private void btn_paymentprint_Click(object sender, EventArgs e)
        {
            gridControl2.ShowPrintPreview();
        }

        // cal debit and payment
        private void DebitPaymentCal()
        {
            
            try
            {
                id = Convert.ToInt16(txt_id.Text);
                db = new DBDMMEntities();
                // get dbit
                debit =(double) db.Debit_Supplier.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                List<string> list = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToList();
                payment = 0;
                for(int i = 0; i < list.Count; i++)
                {
                    payment = payment + Convert.ToInt16(list[i]);
                }
                paymentRs = debit - payment;
                // set data
                txt_debit.Text = "الديون :"+debit.ToString();
                txt_payment.Text = "المدفوع :"+payment.ToString();
                txt_paymentrs.Text = "المتبقي :" + paymentRs.ToString();
            }
            catch
            {

            }
        }
    }
    }