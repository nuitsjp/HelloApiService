using System;
using System.Linq;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloApiService = 
                new HelloApiService(
                    new Uri("http://helloapiservice.azurewebsites.net"), 
                    new AnonymousServiceClientCredentials());
            var values = helloApiService.GetAll();

            values.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}