using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.Models
{
    public class LoginUser
    {
        public int UserID { get; set; }
        public string UserType { get; set; }
        public int UserTypeID { get; set; }
    }
}