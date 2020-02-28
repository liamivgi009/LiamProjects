using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AmiamStore.App_DAL;
using AmiamStore.Models;

namespace AmiamStore.App_BLL
{
    public class LoginBLL
    {
        public List<Login> GetProductsByCata()
        {
            LoginDAL dal = new LoginDAL();
            DataTable dt = dal.GetUsersData();

            // converting from a DataTable to a Product Object!
            List<Login> Users = new List<Login>();
            foreach (DataRow dr in dt.Rows)
            {
                Login d = new Login();
                d.UserName = dr["UserName"].ToString();
                d.Password = dr["Password"].ToString();
                Users.Add(d);
            }
            return Users;
        }
    }
}