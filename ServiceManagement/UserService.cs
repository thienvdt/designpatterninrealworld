using System;
using DatabaseManagement;
using StaticObj;

namespace ServiceManagement
{
    public class UserService : IUserService
    {
        //Inject by get set
        public int Databasekey { get; set; }
        private IDatabaseManagement databaseManagement;
        //Inject by contractor
        public UserService(int databaseManagement) 
        {
            this.Databasekey = databaseManagement;
            
        }
        //Inject by method
        public void SetDataBase(int databaseManagement)
        {
            this.Databasekey = databaseManagement;

        }
        public UserService()
        {
            this.Databasekey = (int)CommonObj.SQLEnum.SQLServer;
        }

        public void StartConnect()
        {
            switch (Databasekey)
            {
                case (int)CommonObj.SQLEnum.MySQL: databaseManagement = new MySQLDatabaseManagement(); break;
                case (int)CommonObj.SQLEnum.SQLServer: databaseManagement = new SQLServerDatabaseManagement(); break;
                default:
                    break;
            }

            Console.WriteLine($"Connection status:  {databaseManagement.Connect()}");
        }

       
    }
}