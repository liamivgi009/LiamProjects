using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.App_BLL.Entities
{
    public class Payment
    {
        public string CardHolder { get; set; }
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiryDate { get; set; }
    }
}