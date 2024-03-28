namespace Lab4Web.Services.Linq
{
    public interface ILinqService
    {
        string Test1(int a);
        List<Car> Test2(string brand);
        List<String> Test3();
        List<object> Test4();
    }
}
