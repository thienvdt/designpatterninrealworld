﻿using Factory;
using SingletonPattern;
using StaticObj;
using System;
using System.Threading;

namespace TestProgram
{
    class Program
    {
        public static string Helper { get; private set; }

        static void Main(string[] args)
        {

            //TestFactory();
            TestSingleTon();
        }
        private static void TestSingleTon()
        {
            Console.WriteLine("Test Singleton!");
           
            ThreadStart childThread = new ThreadStart(() => { UserLogin usr = UserLogin.LogingSingleInstance;});
            ThreadStart childThread1 = new ThreadStart(() => { UserLogin usr = UserLogin.LogingSingleInstance;});
           
            Thread thread = new Thread(childThread);
            Thread thread1 = new Thread(childThread1);
            thread.Start();
            //Thread.Sleep((int)CommonObj.SleepTime.TwoSeconds);
            thread1.Start();

            UserLogin user = UserLogin.LogingSingleInstance;
            user.ShowCurrentLogin();
            // thread1.Start();

            // user.Login();
            Console.ReadKey();
        }
        private static void TestFactory()
        {
            Console.WriteLine("Test Factory!");
            var middlewareFactory = new MiddlewareFactory();
            IMiddleware middleware = middlewareFactory.GetMiddleware((int)CommonObj.SQLEnum.SQLServer);
            middleware.DoAction();
            middleware = middlewareFactory.GetMiddleware((int)CommonObj.SQLEnum.MySQL);
            middleware.DoAction();
        }
    }
}
