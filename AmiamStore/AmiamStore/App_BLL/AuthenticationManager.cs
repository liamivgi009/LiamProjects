using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace AmiamStore.App_BLL
{
    public class AuthenticationManager
    {
        public void SaveUser(string userName,string password, UserType userType,string name)
        {
            var currentUser = new CurrentUser(userName, userType,name);
            SetSession("currentUser",currentUser);
        }
        public void SaveUser(string userName, string password , int userType,string name)
        {
            SaveUser(userName,password, (UserType)userType , name);
        }

        public CurrentUser GetUser()
        {
            return GetSession("currentUser") as CurrentUser;
        }

        public void LogOut()
        {
            HttpContext.Current.Session.Abandon();
        }

        private void SetSession(string key, object value)
        {
            HttpContext.Current.Session[key] = value;
        }

        private object GetSession(string key)
        {
            return HttpContext.Current.Session[key];
        }


    }

    public class CurrentUser
    {
        public string UserName { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public CurrentUser(string userName, UserType userType,string name)
        {
            UserName = userName;
            UserType = userType;
            this.Name = name;
        }
    }

    public enum UserType
    {
        Manager =1,
        Client = 2,
        Guest = 3
    }
}