using System;
using Factory;
using StaticObj;

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
            //middleware = middlewareFactory.GetMiddleware((int)CommonObj.SQLEnum.MySQL);s
            //middleware.DoAction();

            Console.Read();
        }
    }
}
