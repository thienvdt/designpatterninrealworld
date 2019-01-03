using StaticObj;
using System;
namespace Factory
{
    class HandleSQLSever : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine(CommonObj.SQLEnum.SQLServer.GetEnumDescription());
        }
    }
}
