using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMM.BL
{
    public class Updata
    {
        // Database and  Tables
        DBDMMEntities db;
        TB_Suppliers tbSuppliers;
        PaymentSupplier tbpayment;
        Debit_Supplier tbdebit;

        //
        int id;
        double payment = 0, debit, paymentRs;
        public void SuppliersDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();
                var SupplierIDList=db.TB_Suppliers.Select(x=>x.ID).ToArray();
                for(int i = 0; i < SupplierIDList.Length; i++)
                {
                    id = SupplierIDList[i];
                        // get dbit
                        debit = (double)db.Debit_Supplier.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                        List<string> list = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToList();
                        payment = 0;
                        for (int j = 0; j < list.Count; j++)
                        {
                            payment = payment + Convert.ToInt16(list[j]);
                        }
                        paymentRs = debit - payment;
                    tbSuppliers = db.TB_Suppliers.Where(x => x.ID == id).FirstOrDefault();
                    tbSuppliers.Debit = paymentRs;
                    db.Entry(tbSuppliers ).State =System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                  
                }
            }
            catch
            {

            }
        }

        public void CustomerDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();
                var SupplierIDList = db.TB_Customer.Select(x => x.ID).ToArray();
                for (int i = 0; i < SupplierIDList.Length; i++)
                {
                    id = SupplierIDList[i];
                    // get dbit
                    debit = (double)db.Debit_Customer.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                    payment = (double)db.PaymentCustomers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToList().Sum();
                   
                    paymentRs = debit - payment;
                 var   tbCustomer = db.TB_Customer.Where(x => x.ID == id).FirstOrDefault();
                    tbCustomer.Debit = paymentRs;
                    db.Entry(tbCustomer).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch
            {

            }
        }
    }
}
