using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace AmiamStore.App_DAL
{
    public class LoginDAL
    {
        public DataTable GetUsersData()
        {
            DBHelper dbh = new DBHelper();
            String sql =
               @" SELECT Users.UserName, Users.Password, Users.UserID, Users.UserType
                   FROM  Users;";
            DataTable dt = dbh.GetData(sql);
            return dt;
        }
    }
}