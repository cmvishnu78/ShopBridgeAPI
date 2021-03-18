using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge_API_Core
{
    public class DapperCrud
    {
        string Connection = "";
        public DapperCrud(string _connection)
        {
            Connection = _connection; 
        }

        //for calling SP
        public IEnumerable<T> ExecuteSPAsync<T>(string procedurename, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                return con.Query<T>(procedurename, param,
                    commandType: System.Data.CommandType.StoredProcedure);

            }

        }
        //For Inline Query 
        public T ExecuteScalarQuery<T>(string Query)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                return (T)Convert.ChangeType(con.ExecuteScalar(Query), typeof(T));

            }

        }
    }
}
