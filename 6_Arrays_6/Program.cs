namespace _6_Arrays_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcından benzersiz 5 adet sayı alalım.  daha sonra sayıların toplamını ve ortalamasını ekrana yazdıralım...
            int[] sayilar = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}. sayıyı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    // sayı dizide var mı ?
            //    if (Array.IndexOf(sayilar, sayi) == -1) // dönüş değeri -1 ise eleman yoktur
            //        sayilar[i] = sayi;
            //    else
            //        i--;
            //}
            int j = 0;
            while (j<sayilar.Length)
            {
                Console.WriteLine($"{j + 1}. sayıyı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (Array.IndexOf(sayilar, sayi) == -1) // dönüş değeri -1 ise eleman yoktur
                    sayilar[j++] = sayi;
            }
            //int sum = 0;
            //foreach (var item in sayilar)
            //    sum += item;
            int toplam = sayilar.Sum();
            double ortalama = sayilar.Average();
            Console.WriteLine($"girilen sayıların toplamı {toplam} ortalaması {ortalama}");
        }
    }
}