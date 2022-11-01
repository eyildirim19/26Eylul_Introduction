namespace _8_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string => özel bir tiptir. string tipi bir char dizisidir..
            string konu = "introduction";
            char[] konus = { 'i', 'n', 't', 'r', 'o', 'd', 'u', 'c', 't', 'i', 'o', 'n' };

            Console.WriteLine(konu.Length);

            char i = konu[0];
            char s = konu[konu.Length - 1];

            Console.WriteLine(konu[0]);
            Console.WriteLine(konu[konu.Length - 1]);

            for (int n = konu.Length - 1; n >= 0; n--)
                Console.Write(konu[n]);

            Console.WriteLine("*****************");
            foreach (char item in konu)
                Console.Write(item);
            //  konu[0] = 'I'; // stringlerin elemanlarına item bazlı erişebilir ve okuma yapabiliriz yukarıdaki örneklerimiz okuma örneğidir ancak item bazlı atama yapamayız. çünkü özel bir tiptir.

            konus[0] = 'I';

            char[] list = konu.ToCharArray(); // stringi char dizisine dönüştürür
            string buyuk = konu.ToUpper(); // karakterleri büyük harfe dönüştür
            string kucuk = konu.ToLower(); // karakterleri küçük harfe dönüştür
            string fuladd = "ekrem yıldırım";
            string ad = fuladd.Substring(0, 5); // ekrem
            string soyad = fuladd.Substring(6, 8); // yıldırım
            soyad = soyad.Replace("ı", "i"); // metin içerisindeki karakteri değiştirir
            string[] names =fuladd.Split(' '); // karaktre göre stringi parçalar
        }
    }
}