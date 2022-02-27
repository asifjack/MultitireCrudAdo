using System;
using CommonLayer.Models;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    
    public class DbConnection
    {
        public SqlConnection Cnn;
        public DbConnection()
        {
            Cnn = new SqlConnection(Connection.ConnectionStr);
        }
    }
}
