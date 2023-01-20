using System;
using System.Text.RegularExpressions;

namespace CrawlerApp
{
    public class Program
    {
        private static List<string> emailsFound = new List<string>();

        public static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentNullException("Brak adresu emal");
            }

            string urlToCheck = args[0];
            Console.WriteLine("Wyszukiwanie adresów email na stronie: " + urlToCheck);
            if (!Uri.IsWellFormedUriString(urlToCheck, UriKind.RelativeOrAbsolute))

            {
                throw new ArgumentException("Incorrect URL format");
            }

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(urlToCheck);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Błąd w czasie pobierania strony");
            }

            var content = response.Content.ReadAsStringAsync().Result;
            ExtractEmails(content);

            if (client != null)
            {
                client.Dispose();
                Console.WriteLine("\nHTTP client disposed");
            }
        }

        public static void ExtractEmails(string content)
        {
            string pattern = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

            Regex regExpr = new Regex(pattern, RegexOptions.IgnoreCase);
            Match match = regExpr.Match(content);

            while (match.Success)
            {
                emailsFound.Add(match.Groups[0].Value);
                Console.WriteLine("...................Email found: " + match.Groups[0].Value);
                match = match.NextMatch();
            }

            if (emailsFound.Count <= 0)
            {
                Console.WriteLine("Nie znaleziono adresów email");
            }
            else
            {
                Console.WriteLine("\nLista adresów na stronie - bez duplikatów: ");
                List<string> uniqueEmails = emailsFound.Distinct().ToList();
                uniqueEmails.ForEach(Console.WriteLine);
            }

        }

    }

}
