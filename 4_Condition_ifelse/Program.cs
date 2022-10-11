namespace _4_Condition_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if else");
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            //int sayi = (int)Console.ReadLine(); // bu şekilde bir dönüşüm ortak tipler arasında olabilir...string ve int ortak tip değildir...
            int sayi = Convert.ToInt32(Console.ReadLine()); // bakınız Type Convert projesi...
            // else bloğu if'in (koşulun) sağlanmadığı durumda çalışır..
            if (sayi > 0)  // eğer sayı 0 dan büyükse
            {
                Console.WriteLine("Sayı pozitif");
            }
            else // değilse
            {
                Console.WriteLine("Sayı negatif");
            }

            Console.WriteLine("Selam");
        }
    }
}