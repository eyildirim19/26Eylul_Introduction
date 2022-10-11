namespace _4_Condition_if_elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayılar büyük mü küçük mi eşit mi?!");


            Console.WriteLine("1. Sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 >= sayi2)
            //{
            //    if(sayi1 > sayi2)
            //    {
            //        Console.WriteLine($"büyük sayı {sayi1}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayılar eşit");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"büyük sayı {sayi2}");
            //}

            // else if yapısı.. birbirine bağlı koşullar oluşturmak için kullanılır... yukarıdaki kod örneğini else if bloklaları ile daha sade çözebiliriz...

            if (sayi1 > sayi2)
            {
                Console.WriteLine($"büyük sayı {sayi1}");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine($"büyük sayı {sayi2}");
            }
            else
            {
                Console.WriteLine("sayılar eşit");
            }
        }
    }
}