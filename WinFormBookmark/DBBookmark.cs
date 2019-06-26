using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBookmark
{
    class DBBookmark : IDisposable
    {
        private string connectionName = "BookmarkConnectionString";
        private string connectionString;

        private SqlConnection connection;

        private SqlCommand command;

        private SqlDataAdapter adapter;

        public DBBookmark()
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public void Connect()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public void Dispose()
        {
            command.Dispose();
            connection.Dispose();
            adapter.Dispose();
        }

        public bool IsConnected
        {
            get
            {
                if (connection != null)
                {
                    return connection.State == System.Data.ConnectionState.Open;
                }
                return false;
            }
        }

        public int ExecuteQuery(string query)
        {
            Connect();
            using (command = connection.CreateCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = query;
                return command.ExecuteNonQuery();
            }
        }

        public int AddData(string table)
        {
            return 0;
        }

        public DataSet GetQueryResult(string query)
        {
            DataSet data = new DataSet();
            adapter = new SqlDataAdapter(query, connectionString);
            adapter.Fill(data);
            return data;
        }
    }
}
