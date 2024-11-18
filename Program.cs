using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MauiApp.CreateBuilder()
                   .UseMauiApp<App>()
                   .Build()
                   .Run();
        }
    }
}
