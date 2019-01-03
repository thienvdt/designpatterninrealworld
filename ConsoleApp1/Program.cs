using SingletonPattern;
using System;

namespace TestFactory
{
    class Program
    {
        public static string Helper { get; private set; }

        static void Main(string[] args)
        {
            //Console.WriteLine("Test Factory!");
            //var middlewareFactory = new MiddlewareFactory();
            //IMiddleware middleware = middlewareFactory.GetMiddleware((int)CommonObj.SQLEnum.SQLServer);
            //middleware.DoAction();
            //middleware = middlewareFactory.GetMiddleware((int)CommonObj.SQLEnum.MySQL);
            //middleware.DoAction();
            Console.WriteLine("Test Singleton!");
            UserLogging user =  UserLogging.LoggingSingleInstance;
            user.UserName = "Thien";
            UserLogging user1 = UserLogging.LoggingSingleInstance;

            user.Logging();
            user1.Logging();
            Console.Read();
        }
    }
}
