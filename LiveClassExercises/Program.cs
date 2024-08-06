using System;
namespace LiveClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1 - Aşağıdaki çıktıyı yazan bir program.
            Merhaba
            Nasılsın ?
            İyiyim
            Sen nasılsın ?
            */
            Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");
                                  

            // 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
            Console.WriteLine("\nMetinsel değişken için değer giriniz!");
            string text = Console.ReadLine();
            Console.WriteLine("Tam sayı değişken için değer giriniz!");
            int number;
            bool result = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine($"\nGirilen metinsel değişken = {text}\nGirilen tam sayı değişken = {number}");

            // 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            Console.WriteLine($"\nRastgele üretilen sayı = {random}");

            // 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            Random rnd1 = new Random();
            double resultRandom = rnd1.Next(10,21);
            Console.WriteLine($"\nRastgele oluşturulan sayı = {resultRandom}\nOluşturulan sayının 3'e bölümünden kalan = {resultRandom % 3}");

            // 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            Console.WriteLine("\nLütfen yaşınızı giriniz!");
            int age;
            result = int.TryParse(Console.ReadLine(), out age);
            if (result && age > 18)
                Console.WriteLine("+");
            else if (result && age < 18)
                Console.WriteLine("-");
            else
                Console.WriteLine("Lütfen yaşınızı doğru giriniz!");

            // 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            int i = 1;
            Console.WriteLine("--------------------------------");
            while (i <= 10)
            {
                Console.WriteLine($"{i}-Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
                i++;
            }

            // 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            Console.WriteLine("\nBirinci ismi giriniz!");
            string name1 = Console.ReadLine();
            Console.WriteLine("İkinci ismi giriniz!");
            string name2 = Console.ReadLine();
            Console.WriteLine($"\nGirilen birinci isim -> {name1}");
            Console.WriteLine($"Girilen ikinci isim -> {name2}");
            string temp = name1;
            name1 = name2;
            name2 = temp;
            Console.WriteLine("\nYerleri değiştikten sonraki değerler");
            Console.WriteLine($"Girilen birinci isim -> {name1}");
            Console.WriteLine($"Girilen ikinci isim -> {name2}");

            // 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            void BenDegerDondurmem()
            {
                Console.WriteLine("\nBen değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
            }
            BenDegerDondurmem();

            // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            int ToplamDeger(int a,int b)
            {
                return a + b;
            }
            Console.WriteLine("\nİki sayıyıda giriniz!!!");
            Console.WriteLine(ToplamDeger(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())));

            Console.WriteLine("---------------------");

            // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            string StringDegerDonen(bool a)
            {
                if (a)
                    return "Geriye dönen değer true";
                else
                    return "Geriye dönen değer false";
            }
            Console.WriteLine(StringDegerDonen(true));

            // 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

            int TurnAge(int a ,int b,int c)
            {
                int maxAge = a;
                if (maxAge < b)
                    maxAge = b;
                if (maxAge < c) 
                    maxAge = c;
                return maxAge;
            }
            Console.WriteLine("Birinci kişinin yaşını giriniz?");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci kişinin yaşını giriniz?");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü kişinin yaşını giriniz?");
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"En yaşlı kişinin yaşı {TurnAge(age1, age2, age3)}");

                       
            // 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

            void EnBuyukDeger()
            {
                int max = 0;
                while (true)
                {
                    Console.WriteLine("Bir sayı giriniz");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    if (max < userNumber)
                        max = userNumber;
                    Console.WriteLine($"Şu ana kadar girilen maximum sayı {max}");
                }
            }

            EnBuyukDeger();


            // 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

            static void ChangeName(ref string a,ref string b)
            {
                string temp = a;
                a = b;
                b = temp;
                
            }

            Console.WriteLine("Birinci ismi giriniz.");
            string name3 = Console.ReadLine();
            Console.WriteLine("İkinci ismi giriniz.");
            string name4 = Console.ReadLine();            
            ChangeName(ref name3, ref name4);
            Console.WriteLine($"Değiştirildikten sonraki birinci isim = {name3}");
            Console.WriteLine($"Değiştirildikten sonraki ikinci isim = {name4}");

             

            // 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

            bool ReturnEvenOrOdd(int a)
            {
                if (a % 2 == 0)
                    return true;
                return false;
            }
            Console.WriteLine("Bir sayı giriniz girilen sayı çiftse true ; tekse false dönecek");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ReturnEvenOrOdd(number3));
        

            

            // 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

            double ReturnPath(int a, int b)
            {
                return a * b;
            }
            Console.WriteLine("Hızınızı giriniz.");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç saat boyunca devam ediyorsunuz?");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Gidilen yol = {ReturnPath(speed,time)} km");

                       

            // 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

            double AreaOfCircle(double a)
            {
                return Math.PI*a*a;
            }
            Console.WriteLine("Yarıçap giriniz.");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{AreaOfCircle(r)}");

            // 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

            string str = "\nZaman bir GeRi SayIm";
            Console.WriteLine($"Hepsi büyük harfle ->{str.ToUpper()}");
            Console.WriteLine($"Hepsi küçük harfle ->{str.ToLower()}");

            // 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            str = "    Selamlar   ";
            Console.WriteLine($"\nBaşı ve sonundaki boşlukların silinmiş hali -> '{str.Trim()}'");
        }
    }
}