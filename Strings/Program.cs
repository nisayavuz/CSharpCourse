using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city = "Ankara";
            ////Console.WriteLine(city[0]);

            //foreach (var item in city) 
            //{
            //    Console.WriteLine(item);
            //}

            //string city2 = "İstanbul";
            ////string result = city + city2;
            ////Console.WriteLine(result);

            //Console.WriteLine(String.Format("{0} {1}" , city , city2)); // city1 ve 2yi yan yana yazdirir.
            

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length; // Cumlenin kac karakterden olustugunu verir.
            var result2 = sentence.Clone(); // Cumlenin bir referansini olusturmak icin kullanilir.
            sentence = "My name is Nisa Yavuz.";

            bool result3 = sentence.EndsWith("ğ"); // bu cumle ğ ile bitiyor mu?
            bool result4 = sentence.StartsWith("My name"); // cumle my name ile basliyor mu?

            var result5 = sentence.IndexOf("name"); // Bir stringte belli bir karakterin veya kelimenin kacıncı indexten basladigini bulmak icin kullanilir.
            var result6 = sentence.IndexOf(" "); // 2. index
            var result7 = sentence.LastIndexOf(" "); // 16. index
            var result8 = sentence.Insert(0, "Hello, "); // Cumlenin 0. karakterinden itibaren yaziyi ekler.
            var result9 = sentence.Substring(3); // Stringi bolmek icin kullanilir. 3. karakterden sonrasini alır.
            //  var result9 = sentence.Substring(3 , 4); bu sekilde kullanilirsa 3. karakterden itibaren 4 tane alir.
            var result10 = sentence.ToLower(); // tum karakterleri kucuk harfe cevirir.
            var result11 = sentence.ToUpper(); // tum karakterleri buyuk harfe cevirir
            var result12 = sentence.Replace(" ","-"); // boslukları kısa cizgiyle degistirir.
            var result13 = sentence.Remove(2, 5); // bir metinde belli bir indexten sonrasini atmak(cikarmak) icin kullanilir.


            Console.WriteLine(result13);
            Console.ReadLine();
        }
    }
}
