using System;

namespace SingletonPattern
{
    public sealed class UserLogging: IUserLogging
    {
        private static UserLogging _instance = null;
        private UserLogging() {}
        public static UserLogging LoggingSingleInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserLogging();
                }
                else
                {
                    Console.WriteLine("Cannot log 2 users in at the same time");
                }
                return _instance;
            }
        }

        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public void Logging()
        {
            Console.WriteLine("Welcome..."+this.UserName);
        }
    }
}
