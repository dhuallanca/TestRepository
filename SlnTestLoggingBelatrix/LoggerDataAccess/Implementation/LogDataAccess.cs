using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LoggerDataAccess.Interface;

namespace LoggerDataAccess.Implementation
{
    public class LogDataAccess : ILogDataAccess
    {
        private readonly string _connectionString;

        public LogDataAccess()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public void InsertMessage(string message, int logType)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                using (var sqlCommand = new SqlCommand("InsertLogs", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@message", SqlDbType.VarChar, 600).Value = message;

                    sqlCommand.Parameters.Add("@logType", SqlDbType.Int, 0).Value = logType;

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}