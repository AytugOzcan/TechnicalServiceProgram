using System;
using System.Data.SqlClient;

namespace TechnicalService.Managers
{
    public class SqlManager
    {
        public string connectionString { get; set; }
        public SqlConnection connection;
        public SqlManager()
        {
            connectionString = @"Server=AYTUGOZCAN;Database=TechnicalService;Trusted_Connection=True;";
        }
        public SqlConnection CreateConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public string ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, CreateConnection());
            try
            {
                cmd.ExecuteNonQuery();
                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                connection.Close();
                return ex.Message;
            }
        }
        public string ExecuteGetData(string query)
        {
            string result = "";
            SqlCommand cmd = new SqlCommand(query, CreateConnection());
            try
            {
                result = cmd.ExecuteScalar().ToString();
                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                connection.Close();
                return ex.Message;
            }
        }

        public SqlDataReader GetList(string query)
        {
            SqlDataReader drResult;
            SqlCommand cmd = new SqlCommand(query, CreateConnection());
            drResult = cmd.ExecuteReader();           
            return drResult;
        }
    }
}