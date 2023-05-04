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

namespace DMM.Pages
{
    public partial class AnaylisisPage : DevExpress.XtraEditors.XtraUserControl
    {
        DBDMMEntities db;
        public AnaylisisPage()
        {
            InitializeComponent();
            SupplierGetData();
            CustomerGetData();
            TotalDebitGetData();
        }
        private void SupplierGetData()
        {
            try
            {
                db = new DBDMMEntities();
                var data = db.TB_Suppliers.Select(x => x.Debit).ToArray().Sum();
            txt_supplier.Text = data.ToString();
            
            }
            catch
            {

            }
        }

        private void CustomerGetData()
        {
            try
            {
                db = new DBDMMEntities();
                var data = db.TB_Customer.Select(x => x.Debit).ToArray().Sum();
                txt_customer.Text = data.ToString();

            }
            catch
            {

            }
        }

        private void TotalDebitGetData()
        {
            try
            {
                db = new DBDMMEntities();
                var data1 = db.TB_Suppliers.Select(x => x.Debit).ToArray().Sum();
                var data2= db.TB_Customer.Select(x => x.Debit).ToArray().Sum();
                txt_toteldebit.Text = (data1+data2).ToString();

            }
            catch
            {

            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
