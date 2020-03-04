using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AmiamStore.App_BLL.Entities;

namespace AmiamStore.App_DAL
{
    public class UsersRepository
    {
       private readonly DBHelper _dbHeloer = new DBHelper();

        public DataTable GetUsers()
        {
            string sql =
               @" SELECT Users.UserName, Users.Password, Users.UserID, Users.UserType
                   FROM  Users;";
            DataTable dt = _dbHeloer.GetData(sql);
            return dt;
        }

        public void Insert(User user)
        {
            var query = string.Format(@"INSERT INTO Users (UserName, [Password], UserType) VALUES ('{0}','{1}',{2});",
                user.Username, user.Password, user.UserType
                );
            _dbHeloer.ExecuteNonQuery(query);
        }
    }
}