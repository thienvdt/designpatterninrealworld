using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    interface IUserLogging
    {
         string UserName { get; set; }
         string UserPassword { get; set; }
         void Logging();
    }
}
