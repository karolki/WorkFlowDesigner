using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowDesigner.ClassDatabase;

namespace WorkFlowDesigner.Forms
{
    class Connector
    {
        public List<string> GetListFromDataSource(Source source)
        {
            List<string> columns = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = GetConnectionString(source.Id_database);
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT "+source.ColumnName+" FROM "+source.TableName, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader[0].ToString());
                    }
                }
            }
            return columns;
        }
        public string GetConnectionString(DatabaseConnection pos)
        {
            string connection = @"Server = " + pos.Server + "; Database = " + pos.Database + "; User Id = " + pos.UserName + ";Password = " + pos.Password;
            return connection;
        }
    }
}
