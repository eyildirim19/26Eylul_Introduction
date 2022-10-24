namespace _6_Arrays_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array sınıfı diziler üzerinde işlem yapmamızı sağlayan bir sınıftır. bu sınıfın metotları ile diziler üzerinde çeşitli işlemler yapabiliriz. 
            // Resize

            // new => bellekte yeni bir alan açar...
            int[] nums = new int[2]; // açılan  alanı nums değişkeninde tutulur
            nums[0] = 1;
            nums[1] = 2;

            //nums = new int[3]; // açılan alan nums değişkeninde tutulur..
            // new ifadesini kullandığımız için önceki elemanlar kaybolur 3 elemanlı yeni bir alan açılır.
            Array.Resize(ref nums, 3); // Resize metodu dizinin uzunluğunu değiştirmek için kullanılır. 2 parametre alır. ilk parametre uzunluğu değişik dizi, 2. paramre yeni uzunluk...
            nums[2] = 10;
            foreach (int i in nums)
                Console.Write(i); // 1 2 10

            Console.WriteLine("****");
            Array.Resize(ref nums, 1);// yeni uzunluk 1

            foreach (int j in nums)
                Console.Write(j);

            string[] kisiler = { "İsmail", "Gökhan", "Ekrem", "Cemre" };

            string isim = "Gökhan";
            foreach (string s in kisiler)
                if (s == isim)
                    Console.WriteLine("Dizide var..");

            for (int i = 0; i < kisiler.Length; i++)
                if (isim == kisiler[i])
                    Console.WriteLine($"Dizide var. İndex numarası {i}");

            // aranan elemanın indexini döner...eğer aranan eleman dizide varsa index'ini yoksa -1  döner. -1 dönmesinin nedeni -1 indexi yoktur..
            int index1 = Array.IndexOf(kisiler, isim);
            int index2 = Array.IndexOf(kisiler, "Cemre");
            int index3 = Array.IndexOf(kisiler, "Berat");
            int index4 = Array.IndexOf(kisiler, "İsmail");

            Console.WriteLine($"sonuc= {index1} {index2} {index3} {index4}"); // 1 3 -1 0
        }
    }
}