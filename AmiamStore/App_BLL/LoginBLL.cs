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
        public List<User> GetUsers()
        {
            LoginDAL dal = new LoginDAL();
            DataTable dt = dal.GetUsersData();

            // converting from a DataTable to a Product Object!
            List<User> listUsers = new List<User>();
            foreach (DataRow dr in dt.Rows)
            {
                User d = new User();
                d.UserName = dr["UserName"].ToString();
                d.Password = dr["Password"].ToString();
                d.UserType = (int)dr["UserType"];
                listUsers.Add(d);
            }
            return listUsers;
        }

        public User GetSingleUser(string userName, string password)
        {
            var users = GetUsers();
            try
            {
                return users.Single(u => u.UserName == userName && u.Password == password);
            }
            catch
            {
                throw new Exception("Error on getting user. Error Number: 57853");
            }

        }

    }
}