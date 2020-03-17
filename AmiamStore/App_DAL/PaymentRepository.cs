using AmiamStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AmiamStore.App_DAL
{
    public class PaymentRepository
    {
        private readonly DBHelper _dbHelper = new DBHelper();
       
        public DataTable GetPayment(CartViewModel Order)
        {
            string sql =
             @" SELECT Payment.CreditCardNumber, Payment.CVV, Payment.OrderID, Payment.ID
                   FROM  Payment;";
            DataTable dt = _dbHelper.GetData(sql);
            return dt;
        }
    }
}