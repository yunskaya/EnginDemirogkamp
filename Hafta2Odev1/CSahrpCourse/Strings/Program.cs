using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";

            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            //Console.WriteLine(string.Format("{0} {1}", city, city2));// bellekte 3. bir değişken tanımlamamak için kullanılır.

            string sentence = "My name is Yunus Kaya";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            var result3 = sentence.EndsWith("a");
            var result4 = sentence.StartsWith("my");
            var result5 = sentence.IndexOf("name"); // BULDUĞU İLK DEĞERİ DÖNER 
            var result6 = sentence.LastIndexOf("name");
            var result7 = sentence.Insert(0, "Hello, ");
            var result8 = sentence.Substring(3);
            var result9 = sentence.Substring(3, 5);
            var result10 = sentence.ToLower(); // ToUpper()
            var result11 = sentence.Replace(" ", "-");
            var result12 = sentence.Remove(0, 1);



        }
    }
}