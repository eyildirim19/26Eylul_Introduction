namespace _4_Condition_ifelseif2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());

            n = 1;

            if (n > 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (n < 0)
            {
                Console.WriteLine("Sayı Negatif");
            }
            else
            {
                Console.Write("Sayı nötr");
            }
            Console.WriteLine("*****************************************");

            Console.WriteLine("Lütfen 1 ile 7 arasında bir değer giriniz");
            int value = Convert.ToInt32(Console.ReadLine());

            // && => ve
            // || => veya
            if (value >= 1 && value <= 7)
            {
                if (value == 1)
                    Console.WriteLine("Pazartesi"); // koşullu kodnuz tek satır ise if veya elseif veya else kısacası blok yapılarda scope açmaya gerek yoktur....
                else if (value == 2)
                    Console.WriteLine("Salı");
                else if (value == 3)
                    Console.WriteLine("Çarşamba");
                else if (value == 4)
                    Console.WriteLine("Perşembe");
                else if (value == 5)
                    Console.WriteLine("Cuma");
                else if (value == 6)
                    Console.WriteLine("Cumartesi");
                else
                    Console.WriteLine("Pazar");
            }
            else
            {
                Console.WriteLine("Eyvah geçersiz değer girdiniz");
            }
        }
    }
}