
namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {
        /* public Tuple<int, int,int> Test1(int value)
         {
             var lambdaExp = (int num) => new Tuple<int, int, int>(num % 10, (num /= 10) % 10, (num /= 10) % 10);
             return lambdaExp(value);
         }

         public bool Test2(string value)
         {
             return int.TryParse(value, out _);
         }

         public async Task<string> Test3Async(string value)
         {
             var lambaExp = async (string v) =>
             {
                 await Delay();
                 return value.ToLower();
             };

             return await lambaExp(value);
         }


         public Task Delay()
         {
             return Task.Delay(10000);
         }
     }*/
        public string Test1() //fara parametri 
        {
            var lamba_exp = () => "Salut!";
            return lamba_exp();
        }

        public string Test2(string value) //un parametru
        {
            var lambda_exp = (string a) => "Bine ai venit, " + a;
            return lambda_exp(value);
        }

        public float Test3(int a, int b) //cu doi parametrii
        {
            var lambda_exp = (int x, int y) => Math.Acos(x * y) * Math.Sin(5);
            return (float)lambda_exp(a, b);
        }

        public double Test4(double x,string a) { //cu o variabila nefolosita
            var lambda_exp = (double l,string s) => x * x;
            return lambda_exp(x,a);
        }

        public double Test5(double a) //cu param care au valori defeault
        {
            var lambda_exp=(int x, int b=6)=> x+b*x;
            return lambda_exp(4);
        }
        public string Test6(Tuple<int, int> tuple) //care primeste ca parametru un tuplu
        {
            var lambda_exp = (Tuple<int, int> x) =>
            {
                if (tuple.Item1 == tuple.Item2)
                    return "Toate elementele tuplului sunt egale";
                else
                    return "Elementele tuplului sunt diferite";
            };
            return lambda_exp(tuple);
        }  
        
        public async Task<string> asyncMethod(string s, int x)
        {
            var lambda_exp = async (string a) =>
            {
                if (x >= 100)
                {
                    await Wait();
                    return a+"waited";
                }
                return a + " something"; 
            };
            return await lambda_exp(s);
        }
        public Task Wait()
        {
            return Task.Delay(5000);
        }
    }
}
