using System;
using jschweda.luisDemo.client;

namespace jschweda.luisDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            Uri baseUri = ReadBaseUri();
            Guid appId = ReadAppId();

            var client = new LuisCognitiveServiceAPI(baseUri);
            while (true)
            {
                var input = Console.ReadLine();
                var response = client.LuisV20AppsByAppIdGet(appId, input, verbose: true);

                System.Console.WriteLine($"Top Scoring intent: {response.TopScoringIntent.Intent}.");
                foreach (var intent in response.Intents)
                {
                    Console.WriteLine($"{intent.Intent}:{intent.Score}");
                }
            }
        }

        private static Guid ReadAppId()
        {
            Guid appId = Guid.Empty;
            while (appId == Guid.Empty)
            {
                Console.WriteLine("Please enter the appid of your luis app.");
                var input = Console.ReadLine();

                if (!Guid.TryParse(input, out appId))
                {
                    Console.WriteLine("The entered appid was not valid.");

                }
            }

            return appId;
        }

        private static Uri ReadBaseUri()
        {
            Uri baseUri = null;

            while (baseUri == null)
            {
                Console.WriteLine("Please enter the baseuri for your luis app.");
                var input = Console.ReadLine();

                if (!Uri.TryCreate(input, UriKind.Absolute, out baseUri))
                {
                    Console.WriteLine("The entered uri was not valid.");

                }
            }

            return baseUri;
        }
    }
}
