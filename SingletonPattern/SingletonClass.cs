using System;
using StaticObj;
using static StaticObj.CommonObj;

namespace SingletonPattern
{
    public sealed class UserLogin : IUserLoging
    {
        private static UserLogin _userLogin = null;
        UserLogin(string userName)
        {
            this.UserName = userName;
            Console.WriteLine($"User {this.UserName} has sucessfully registered!");
        }
        public static UserLogin LogingSingleInstance
        {
            get
            {
                if (_userLogin == null)
                {
                    var rd = new Random();
                    var randNumber = rd.Next(2).ToString();
                    _userLogin = new UserLogin($"User {randNumber}");
                }
                else
                {
                    Console.WriteLine("Cannot log 2 users in at the same time");
                }
                return _userLogin;
            }
        }

        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public void ShowCurrentLogin()
        {
            Console.WriteLine($"Welcome...{this.UserName}");
        }
    }
    /* with thread safe*/
    //public sealed class UserLogin : IUserLoging
    //{
    //    private static UserLogin _userLogin;
    //    private static readonly object _lock = new object();
    //    UserLogin(string userName)
    //    {
    //        this.UserName = userName;
    //        Console.WriteLine($"User {this.UserName} has sucessfully registered!");
    //    }
    //    public static UserLogin /*LogingSingleInstance*/
    //    {

    //        get
    //        {
    //            lock (_lock)
    //            {
    //                if (_userLogin == null)
    //                {
    //                    var rd = new Random();
    //                    var randNumber = rd.Next(1).ToString();
    //                    _userLogin = new UserLogin($"User {randNumber}");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Cannot log 2 users in at the same time");
    //                }
    //                return _userLogin;
    //            }
    //        }
    //    }
    //    public string UserName { get; set; }
    //    public string UserPassword { get; set; }

    //    public void ShowCurrentLogin()
    //    {
    //        Console.WriteLine($"Welcome  {this.UserName}");
    //    }
    //}
}
