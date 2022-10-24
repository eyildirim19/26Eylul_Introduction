namespace _6_Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gun = "Pazartesi";
            string[] gunler = new string[7];
            //gunler = gun;
            gunler[0] = gun;
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            Console.WriteLine($"dizinin eleman sayısı {gunler.Length}");
            int j = gunler.Length - 1;
            while (j > -1)
                Console.WriteLine(gunler[j--]); // 

            for (int i = 0; i < gunler.Length; i++)
                Console.WriteLine(gunler[i]);

            foreach (string gn in gunler)
                Console.WriteLine(gn);

            // s değişkeni dizinin içerisinden okunan elemanı tutar.in ifadesi dizin içerisinden sıradaki elemanı alır.. ve değişkenene aktarır.
            // foreach döngüsü ileri yönlü okuma yapar
            //foreach (string s in gunler)
            //{
            //    string temp = s; // s'nin değerini oku
            //    //s = "deneme"; // s'ye değer ata... // buradaki s değişkenine atama işlemi yapılamaz..
            //}
            // dizi tanımla 2
            string[] guns = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
            int a = 4, b = 2, c = 8, d = 10;
            int[] nums = { a, b, c, d };

            int enb = nums[0]; // dizinin 0. elemanı en büyük kabul edilir
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] > enb)
                    enb = nums[i];

            enb = nums[0];
            foreach (int n in nums)
                if (n > enb)
                    enb = n;

            Console.WriteLine($"en büyük eleman {enb}");

            Console.WriteLine("**************************************");

            char[] chars = { 'a', 'b', 'a', 'a', 'd', 'e', 'e', 'c' };
            char[] charunique = new char[0];

            for (int i = 0; i < chars.Length; i++)
            {
                int adet = 0;
                for (int k = 0; k < chars.Length; k++)
                {
                    if (chars[i] == chars[k])
                        adet++;
                }
                Console.WriteLine($"{chars[i]} elemanından {adet} var");
            }



        }
    }
}