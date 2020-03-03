using AmiamStore.App_BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.App_DAL
{
    public class CustomersRepository
    {
        private readonly DBHelper _dbHeloer = new DBHelper();
        public void GetCustomers() { }

        public void Insert(Customer customer)
        {
            var query = string.Format("INSERT INTO Customers (CustomerName, CustomerCompanyName, CustomerID, CustomerEmailAdress, CustomerPhone, UserID) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}');",
                customer.CustomerName,
                customer.CustomerCompanyName,
                customer.CustomerID,
                customer.CustomerEmailAdress,
                customer.CustomerPhone,
                customer.UserID
                );
            _dbHeloer.ExecuteNonQuery(query);
        }
    }
}