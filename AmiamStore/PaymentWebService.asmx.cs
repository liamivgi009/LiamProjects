using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using AmiamStore.App_DAL;
namespace AmiamStore
{
    /// <summary>
    /// Summary description for PaymentWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PaymentWebService : System.Web.Services.WebService
    {
        public static PaymentManager _paymentManager = new PaymentManager();

        [WebMethod]
        public bool Pay(string holderName, string creditCardNumber, string cvv, string expirityDate, double amountToCharge)
        {
            PaymentMethod o = new PaymentMethod(holderName,creditCardNumber,cvv,expirityDate);
            List<PaymentMethod> payments = new List<PaymentMethod>();
            payments = _paymentManager.LoadSavedPayments();
            if(payments.FindIndex(o))
                return true;
            return false;
        }
    }

    public class PaymentManager
    {
        private List<PaymentMethod> _paymentMethods = new List<PaymentMethod>();

        public List<PaymentMethod> LoadSavedPayments()
        {
            List<PaymentMethod> SavedPayments = new List<PaymentMethod>(); PaymentRepository c = new PaymentRepository();
            DataTable dt  = c.GetPayment();
            foreach(DataRow dr in dt.Rows)
            {
                PaymentMethod m = new PaymentMethod();
                m.CardHolder = dr["HolderName"].ToString();
                m.CreditCardNumber = dr["CreditCardNumber"].ToString();
                m.Cvv = dr["Cvv"].ToString();
                m.ExpiryDate = dr["ExpiryDate"].ToString();
                _paymentMethods.Add(m);
            }
            return SavedPayments;
        }
        public bool Charge(string holderName, string creditCardNumber, string cvv, string expirityDate, double amountToCharge)
        {
            lock (_paymentMethods)
            {
                try
                {
                    var paymentMethod = _paymentMethods.Where(p => p.CreditCardNumber == creditCardNumber).Single();
                    if (cvv == paymentMethod.Cvv)
                    {
                        paymentMethod.Balance -= amountToCharge;
                        return true;
                    }
                }
                catch
                { }
                return false;
            }

        }
    }
    public class PaymentMethod
    {
      
        public string CardHolder { get; set; }
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiryDate { get; set; }


        public PaymentMethod() { }
        public PaymentMethod(string cardHolder, string creditCardNumber, string cvv, string expiryDate)
        {
            CardHolder = cardHolder;
            CreditCardNumber = creditCardNumber;
            Cvv = cvv;
            ExpiryDate = expiryDate;
        }
    }
}
