using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
    public class SQLServerDatabaseManagement : IDatabaseManagement
    {
        public string ConnectionString { get; set; }

        public string Close()
        {
            return $"Disconnected to SQL server";
        }
        public string Connect()
        {
            return $"Connected to SQL server";
        }
    }
}
