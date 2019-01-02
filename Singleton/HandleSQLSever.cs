using StaticObj;
using System;
using System.Collections.Generic;
using System.Text;

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
