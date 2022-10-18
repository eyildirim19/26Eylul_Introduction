namespace _5_Loops_Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya evet dediği sürece tekrar sayı istenecek...

            #region "while ile"
            //string cevap = "evet";
            //while (cevap.ToLower() == "evet")
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Tekrar sayı girmek istermisiniz?");
            //    cevap = Console.ReadLine();
            //}
            #endregion

            string result;
            int toplam = 0;
            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                Console.WriteLine("Tekrar sayı girmek istermisiniz?");
                result = Console.ReadLine();
            } while (result.ToLower() == "evet");
            Console.WriteLine($"sayıların toplamı {toplam}");

            // kullanıcıdan alınan mesajı ekrana yazdıran daha sonra tekrar yazdırmak istermisin sorusuna evet cevabı verirse tekrar yazdıran.. 

            Console.WriteLine("Mesajın nedir?");
            string mesaj = Console.ReadLine();
            char durum;
            do
            {
                Console.WriteLine(mesaj);
                Console.WriteLine("Mesajınız tekrar gösterilsin mi? E/H");
                durum = Convert.ToChar(Console.ReadLine());
            }
            while (durum == 'e' || durum == 'E');




            // öDEV : n adet öğrecinin vize ve final bilgileri alınacak. eğer vize veya final belirtilen aralıkta değilse bu bilgiler tekrar istenecek;
            // n. öğrencinin ortalaması hesaplanacak...


            // ortalamalar hesaplandıktan sonra genel ortalama ekrana yazdıralacak (ortalamatoplam/n)
            // enyük ortalaması olan ve endüşük ortalaması olan öğrencilerin ad ve ortalaması ekrana yazdırılacak...

            // Ödevlerinizi Odev3 projesini github'daki projenize ekleyiniz. Hoca perşembe akşamına kadar kontrol eder..
        }
    }
}