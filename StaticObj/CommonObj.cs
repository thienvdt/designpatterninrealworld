using System;
using System.ComponentModel;

namespace StaticObj
{
    public static class CommonObj
    {
       public enum SQLEnum
        {
            [Description("This is handle for SQLServer")]
            SQLServer,
            [Description("This is handle for MySQL")]
            MySQL
        }
    }
   
}
