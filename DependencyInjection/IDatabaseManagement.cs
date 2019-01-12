using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
   public interface IDatabaseManagement
    {
         string ConnectionString { get; set; }
         string Connect();
         string Close();

    }
}
