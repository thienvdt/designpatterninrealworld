using StaticObj;
using System;

namespace Factory
{
    class HandleMySQL : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine(CommonObj.SQLEnum.MySQL.GetEnumDescription());
        }
    }
}
