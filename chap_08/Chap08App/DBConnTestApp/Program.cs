using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnTestApp
{
    class DBhelper
    {
        public IDbConnection GetDbConnection()
        {
            IDbConnection dbConn = null;
            string connstring = ConfigurationManager.AppSettinggs["Connection"];
            var DBType = ConfigurationManager.AppSettings["DbType"];
            switch(DBType)
            {
                case "SQLServer":
                    dbConn = new SqlConnection(connstring);
                    break;
                case "Oracle":
                    dbConn = new OracleConnection(connstring);
                    break;
                case "OleDB":
                    dbConn = new OleDbConnection(connstring); ;
                    break;
                default:
                    break;
            }
            return dbConn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
