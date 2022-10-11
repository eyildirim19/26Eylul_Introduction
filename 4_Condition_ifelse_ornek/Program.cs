namespace _4_Condition_ifelse_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen 2 farklı sayıyı karşılaştırıp büyük sayıyı ekrana yazdıran prog.");

            int sayi1, sayi2; // Variables projesini inceleyiniz..
            Console.WriteLine("1. Sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            // 1.çözüm
            if (sayi1 > sayi2) // sayi1 büyükse sayı2 den
            {
                Console.WriteLine($"büyük sayı {sayi1}"); // sayi1'i yazdır
            }
            else // değilse
            {
                Console.WriteLine($"büyük sayı {sayi2}"); // sayi2'yi yazdır..
            }

            // 2.çözüm
            int enb;
            if (sayi1 > sayi2) // sayi1 büyükse sayi2den
            {
                enb = sayi1; // enb sayı sayi1
            }
            else // değilse
            {
                enb = sayi2; // enb sayı sayi2
            }
            Console.WriteLine($"en büyük sayı {enb}");

            // 3.çözüm
            int enbuyuk = sayi1; // sayi1'i enbüyük sayı kabul ediyoruz...
            if (sayi2 > enbuyuk) // 2. sayı büyükse enbüyüksayıdan 
            {
                enbuyuk = sayi2; // enbüyük sayı 2. sayıdır...
            }
            Console.WriteLine($"en büyük sayı {enbuyuk}"); // en büyük sayıyı ekrana yazdır


        }
    }
}