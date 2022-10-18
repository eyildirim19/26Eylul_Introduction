namespace _5_Loops_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello, World!");
            }
            #endregion
            Console.WriteLine("Hangi mesajı yazalım?");
            string mesaj = Console.ReadLine();

            Console.WriteLine("Kaç defa yazdırılsın??");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mesaj);
            }
            #region "while kullanımı"
            Console.WriteLine("***************");
            int j = 0;
            while (j < n)
            {
                Console.WriteLine(mesaj);
                j++;
            }
            #endregion
        }
    }
}