
namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        /* public string Introduction(string value, Func<string, string, string> callback)
         {
             var upperName = value.ToUpper();
             return callback(upperName, "Test");
         }

         public string Hello(string firstname, string lastname)
         {
             return $"Hello, {firstname} {lastname}";
         }
        */
       public float DoOperation(Func<int,int,float> callback, int x, int y){
           
            return callback(x,y);
        }
        public float Add(int x, int y)
        {
            return x+y;
        }

        public float Substract(int x, int y)
        {
            return x - y;
        }

        public float Multiply(int x, int y)
        {
            float rez = x * y;
            return x * y;
        }

        public float Divide(int x, int y)
        {
            try {
                return x / y;
            }
            catch
            {
                return 0;  //am facut o conventie cu mine asa incat ceva impartit la 0 sa dea tot 0, chiar daca nu are sens
            }
        }

      

       
    }
}
