namespace _6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array (Diziler) => birden fazla değişkeni bir arada tutma yöntemidir.. çünkü değişken sayıları arttıkça yönetmesi zorlaşır. daha fazla kod yazmamız gerekir. bi noktadan sonra bu yönetilemez hale gelir. diziler bu nokta birden değişken veya verirnin bir arada tutulmasıyla yönetimsel anlamda bize kolaylık sağlar..
            // diziler aynı tipten veri veya değişkenlerin bir arada tutulduğu yapılardır
            // örnek;
            // <diziTipi>[] <diziAdi> = new <diziTipi>[elemansayisi];
            // new => bellekte yeni bir referans açar
            // diziler referans tiplerdir. birden fazla değişkenin referansını tutarlar...
            // dizinin elemanlarına erişmek için index operatörü kullanılır;
            // [n.eleman]
            int a = 4, b = 1, c = 5, d = 10;
            int enb;
            #region "enbuyuk"
            if (a > b && a > c && a > d)
                enb = a;
            else if (b > a && b > c && b > c)
                enb = b;
            else if (d > a && d > b && d > c)
                enb = d;
            else
                enb = c;
            #endregion

            int k; // tek bir değer tutar
            int[] j; // birden fazla değer tutar...
            // örnek 2 elemanlı int dizi...
            int[] nums = new int[2];
            nums[0] = 1; // nums dizinin 0. elemanı 1'dir.
            nums[1] = 99;// nums dizisinin 1. elemanı 99'dur.

            // değişkenlerin değerlerini tutan 4 elemanlı sayilar dizisi...
            #region MyRegion
            int[] sayilar = new int[4];
            sayilar[0] = a;
            sayilar[1] = b;
            sayilar[2] = c;
            sayilar[3] = d;
            #endregion
            char[] chars = new char[5];
            chars[0] = 'A';
            chars[1] = 'B';
            chars[2] = 'C';
            chars[3] = 'D';

            string[] kisiler = new string[13];
            kisiler[10] = "Ebubekir";
            kisiler[0] = "Umut";
            kisiler[1] = "İsmail";
            kisiler[2] = "Merve";
            kisiler[3] = "Cemre";
            kisiler[4] = "Gökhan";
            // dizilerde elemanlara döngüler ile erişilir. bu yüzde c# dilinde diziler için özel bir döngü vardr bu döngünün foreach döngüsüdür...foreach döngüsü dizinin elemanlarına sıralı şekilde erişmek için kullanılan özel bir döngüdür. 
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(kisiler[i]);
            }
            Console.WriteLine("***************");
            // in komutu kisiler dizisinin içerisindeki elemanları sırası ile item değişkenine atar..
            foreach(string item in kisiler)
            {
                Console.WriteLine(item);
            }
        }
    }
}