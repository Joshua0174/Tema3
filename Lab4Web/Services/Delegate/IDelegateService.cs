using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;

namespace Lab4Web.Services.Delegate
{
    public interface IDelegateService
    {
        float DoOperation(Func<int, int, float>callback, int x, int y);
        float Add(int x,int y);
        float Substract(int x, int y);
        float Multiply(int x, int y);
        float Divide(int x, int y);
    }
}
