namespace _7_Metot_4
{
    internal class Program
    {
        // metotların default (varsayılan) erişim seviyesi private'dir...
        // <erisimSevisi> <void> metotName()
        // {
        // }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32("44");
            int result = Topla(4, 3);
            Console.WriteLine(result);
            //Console.WriteLine(Topla(4)); // tek parametreli topla void olduğu iiçn yazdıralamaz...çünkü void bir değer değildir...
            // eleman yok
            Console.WriteLine(Topla(4, 4)); // tek parametreli topla void olduğu iiçn yazdıralamaz...

            // metotlar geriye her zaman tek bir değer dönerler...
            // ref ve out parameter => her iki parametrede metot gövdesinden değer çıkartmak için kullanılır..teknik olarak her ikisiyle bu işlemi yaparız. ancak dorğusu out parametre bu yönde kullanılır

            int snc;
            float r = Islem(4, 2, out snc);
            Console.WriteLine($"İşlem = {r} - {snc}");

            string[] kisi = { "Ekrem Yıldırım", "E", "34" };
            string _ad;
            char _cinsiyet;
            int yas;
            Bilgiler(kisi, out _ad, out _cinsiyet, out yas);
            Console.WriteLine($"{_ad} {_cinsiyet} {yas}");


            // ref out mantığınada kullanılır..bu mantıkta kullanılır ama tanımı farklıdır. metoda argümanın değeri yerine referansını gönderir
            int val = 5, val1 = 5;

            Demo(ref val);
            Demo(val1);

            Console.WriteLine(val);
            Console.WriteLine(val1);

            // her iki keyword ile metot gövdesinden değer çıkartırız..
            // refte parametreye verilen değişkenin ilk değeri olmalıdır
            // out'ta ilk değer verilmesi zorunlu değildir

            // refte metot gövdesinde değer ataması zorunlu değildir..
            // out ta metot gövdesinde değer ataması zorunludur...
            int mi, ma;
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Bul(ints, out mi, out ma);
            Console.WriteLine($"Dizinin en küçük elemanı {mi}, Dizinin en büyük elemanı {ma}");
        }

        static void Bul(int[] nums, out int min, out int max)
        {
            min = nums.Min(); // dizinin minimum elemanını döner
            max = nums.Max(); // dizinin maximum elemanını döner
        }

        static void Demo(ref int a)
        {
            a = 10;
        }
        static void Demo(int a)
        {
            a = 10;
        }

        static void Bilgiler(string[] kisi, out string adsoyad, out char cinsiyet, out int yas)
        {
            adsoyad = kisi[0];
            cinsiyet = Convert.ToChar(kisi[1]);
            yas = Convert.ToInt32(kisi[2]);
        }
        static float Islem(int s1, int s2, out int kalan)
        {
            int sonuc = 0;
            kalan = s1 % s2;  // % mod operatörüdür. bölümden kalanı verir...
            return s1 / s2;
        }

        // VOİD BİR DEĞER DEĞİLDİR..
        static void Topla(int n)
        {
            int r = n + 5;
            return;
        }
        static int Topla(int n1, int n2)
        {
            return n1 + n2;
        }

    }
}