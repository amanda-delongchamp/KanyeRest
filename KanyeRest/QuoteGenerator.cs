using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeRest
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            string kanyeURL = "https://api.kanye.rest";

            string kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            string kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"----------------------");
            Console.WriteLine($"Kane:  '{kanyeQuote}'");
            Console.WriteLine($"----------------------");
        }


        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            string ronResponse = client.GetStringAsync(ronURL).Result;

            string ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"--------------------");
            Console.WriteLine($"Ron:  {ronQuote}");
            Console.WriteLine($"--------------------");
        }
    }
}
