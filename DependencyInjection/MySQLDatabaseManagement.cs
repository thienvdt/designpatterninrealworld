using System;

namespace DatabaseManagement
{
    public class MySQLDatabaseManagement : IDatabaseManagement
    {
        public string ConnectionString { get; set;}

        public string Close()
        {
            return $"Disconnected to MySQL";
        }
        public string Connect()
        {
            return $"Connected to MySQL";
        }
    }
}
