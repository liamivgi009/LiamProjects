using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
namespace AmiamStore.App_DAL
{
    public class DBHelper
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader dataReader;

        public DBHelper()
        {
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            connString += HttpContext.Current.Server.MapPath(@"~/App_Data/AmiamStore.accdb"); 
        
            connection = new OleDbConnection(connString);  
            command = new OleDbCommand();
            command.Connection = connection;
             
        }

        public DataTable GetData(string sql)
        {
            command.CommandText = sql;
            var dataTable = new DataTable();
            String output = "";
            try
            {
                connection.Open();
                dataReader = command.ExecuteReader();

                dataTable.Load(dataReader);              
            }
            catch (Exception e)
            {
                string exception = e.Message;
                return null;
            }
            finally
            {
                this.connection.Close();
            }

            return dataTable;
        }
    }
}
