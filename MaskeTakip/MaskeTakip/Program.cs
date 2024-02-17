using Business.Concrete;
using Entities.Concrete;
using MaskeTakip;
using System;

namespace Odev // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SelamVer("ayşe");
            SelamVer("fatma");
            SelamVer("zehra");
            SelamVer();

            int sonuc = Topla(3,5);

            //Diziler / Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "engin";
            ogrenciler[1] = "yunus";
            ogrenciler[2] = "hasan";

            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            //deneme
            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Bursa", "Denizli", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            
            Person person = new Person();
            person.FirstName = "yunus";
            person.LastName = "kaya";
            person.DateOfBirthYear = 1995;
            person.NationalIdentity = 123;

            MyList list = new MyList();
            string[] array = list.NewArray(sehirler1,"Samsun");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            List<string> yeniSehirler = new List<string> { "ankara 1", "istanbul 2", "izmir 1" };
            yeniSehirler.Add("adana 1");

            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }
            Person person1 = new Person();
            person1.DateOfBirthYear = 24;
            person1.FirstName = "fatih";

            PersonManager personManager = new PersonManager();
            personManager.ApplyForMask(person1);
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz") // default parametre
        {

            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5, int sayi2 = 10) // default parametreler sona verilir
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    }
}