namespace _5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Döngü Nedir");



            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("********************");
            /*
                    
             kodların belirli bir koşul doğrultusan tekrar çalışmasını sağlayan program yapılarıdır..

            döngüler;
            1)for
            2)while
            3)do while

            dizilerden sonra işlenecek;
            4)foreach
             */

            /*
                for döngüsü => koşul doğrultusunda gövdesindeki kodları tekrar çalıştaran bloktur
            for(<baslangic_deger>; <kosul>;<baslangicdeger_manipulasyon>)
            {
                <koşullu kod>
            } 

             1 önce başlangıç değer (bir kere çalışır);
             2 koşul
             3 koşullu kod
             4 artım veya azalım
            // sonraki süreçler 
            4 2 3
            */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            Console.WriteLine("********************");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            Console.WriteLine("********************");
            for (int i = 10; i < 100; i += 10)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            Console.WriteLine("********************");
            // i' kod birkere çalıştıktan sonra z  olduğu için  mesaj bir kere gösterilir...
            for (string i = "a"; i != "z"; i = "z")
            {
                Console.WriteLine("Merhaba Dünya");
            }

            // 
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{i + 1} ");
            }

            // 2022 2021 2020 ............2000
            for (int i = 2022; i >= 2000; i--)
                Console.Write($"{i}");
            Console.WriteLine("***************");
            for (int i = 2022; i >= 2000;)
                Console.Write($"{i--}"); // 2022 ......2000

            Console.ReadKey();
        }
    }
}