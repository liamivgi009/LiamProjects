using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AmiamStore.App_DAL
{
    public class AmiamDB
    {
        DBHelper amram;

        public AmiamDB()
        {
            this.amram = new DBHelper();
        }
        public DataTable GetNewBooks()
        {
            string sql = @"";
            return this.amram.GetData(sql);
        }
    }
}
