using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.App_BLL.Entities
{
    public class Customer
    {
        public string CustomerName { get; set; }

        public string CustomerCompanyName { get; set; }

        public string CustomerEmailAdress { get; set; }

        public string CustomerPhone { get; set; }

        public int CustomerID { get; set; }

        public int UserID { get; set; }

    }
}