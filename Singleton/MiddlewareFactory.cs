using StaticObj;

namespace Factory
{
   public class MiddlewareFactory
    {
        public IMiddleware GetMiddleware(int whichValue)
        {
            switch (whichValue)
            {             
                case (int)CommonObj.SQLEnum.SQLServer: return new HandleSQLSever();
                case (int)CommonObj.SQLEnum.MySQL: return new HandleMySQL();
                default: return new HandleMySQL();
            }
        }
    }
}
