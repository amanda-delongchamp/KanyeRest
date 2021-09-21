using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeRest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.KanyeQuote();

                QuoteGenerator.RonQuote();
            }
            
            

        }
    }
}
