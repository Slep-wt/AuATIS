using System.IO;
using System.Runtime;
using AuATIS.Client;

namespace AuATIS.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string Profile = "Australia";

            Frequencies Freqs = new Frequencies(Profile);
            Translator Trans = new Translator(Profile);
            foreach (KeyValuePair<string, string> x in Freqs.Table)
            {
                Console.WriteLine(x.Key + " | " + x.Value);
            }

            Console.WriteLine(Freqs.Find("ZZZZ"));
            Console.WriteLine(Freqs.Find("NTAA"));

            Console.WriteLine("---------------------------------");

            foreach (KeyValuePair<string, Translation> x in Trans.Table)
            {
                Console.WriteLine(x.Key + " | " + x.Value.Spoken + " | " + x.Value.Phonetic + " | " + x.Value.Regex + " | " + x.Value.Fallback);
            }

            Console.ReadLine();
        }
    } 
}