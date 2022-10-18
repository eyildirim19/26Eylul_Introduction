namespace _5_Loops_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n adet sayıyın en büyüğünü bulan prog. 
            Console.WriteLine("Kaç adet sayı gireceksiniz?");
            int n = Convert.ToInt32(Console.ReadLine());

            int enb = int.MinValue; // int'in minimum değerini atıyoruz...
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı gir");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > enb)
                    enb = sayi;
            }
            Console.WriteLine($"girmiş olduğunuz sayıların en büyüğü {enb}");

            #region "while ile"
            int k = 0;
            enb = int.MinValue; // yukarıdaki döngüde enb değişitği için tekrar minimum inti veriyoruz
            while (k < n)
            {
                Console.WriteLine($"{k + 1}. sayıyı gir");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > enb)
                    enb = sayi;
                k++;
            }
            Console.WriteLine($"girilen sayılardan en büyüğü {enb}");
            #endregion
        }
    }
}