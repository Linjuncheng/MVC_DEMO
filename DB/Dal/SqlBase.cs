using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DB.Dal
{
    public class SqlBase
    {
        public static SqlConnection CreatConn()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        }
    }
}