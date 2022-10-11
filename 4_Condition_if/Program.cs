namespace _4_Condition_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koşul Yapıları");
            /*
             * 
                belirli bir koşul doğrultusunda programın akışını değiştiren bloklardır... 
            1 ) koşul
            2 ) koşullu kod =>  bellirbir koşul sağlandığında çalışan koda denir..
             */
            Console.WriteLine("Lütfen sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            // sayı 0 ile karşılaştırılır. sayı 0'dan büyükse sayı pozitif mesajını ekrana yazdırır..
            if (sayi > 0) // koşul // eğer sayı 0'dan büyükse
            {
                Console.WriteLine("Girilen sayı pozitif"); // koşullu kod
            }

            Console.ReadKey();
        }
    }
}