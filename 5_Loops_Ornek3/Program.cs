namespace _5_Loops_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // console'dan alınan n adet pozitif sayının toplamını bulan prog...
            int toplam = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > 0)
                    // toplam = toplam + sayi
                    toplam += sayi;
                else
                    i--;
            }

            Console.WriteLine($"Sayıların Toplamı = {toplam}");
            Console.WriteLine("**********************");
            int j = 0;
            toplam = 0;
            while (j < 3)
            {
                Console.WriteLine($"{j + 1}. sayıyı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    toplam += sayi;
                    j++;
                }
            }
            Console.WriteLine($"Sayıların Toplamı = {toplam}");
        }
    }
}