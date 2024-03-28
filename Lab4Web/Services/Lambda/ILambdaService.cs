namespace Lab4Web.Services.Lambda
{
    public interface ILambdaService
    {
        string Test1();
        string Test2(string value);

        float Test3(int a, int b);
        double Test4(double x, string a);
        double Test5(double a);
        public string Test6(Tuple<int, int> tuple);
        public Task<string> asyncMethod(string s, int x);

    }
}
