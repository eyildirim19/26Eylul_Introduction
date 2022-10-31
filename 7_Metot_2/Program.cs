namespace _7_Metot_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // metot dönüş tipi
            int n1 = 5, n2 = 1;
            int r1 = Topla(1, 1); // 2
            int r2 = Topla(n1, n2); // 6
            //n1 + n2 + 5 3 sayının toplamı s1'in argümanı, 1 s2'nin argümanı
            int r3 = Topla(n1 + n2 + 5, 1); // 12

            int num = Convert.ToInt32("1231"); // girilen stringi inte dönüştür
            int n = Array.IndexOf(new int[] { 1, 2, 3, 4, 5 }, 10); // dizide değeri ara. aranan eleman varsa indexini yoksa -1 dön...
            Console.WriteLine("Bir Değer Giriniz");
            string deger = Console.ReadLine(); // ReadLine geriye string döner. console'den girilen değeri verir
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        static private int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc; // return scope sonlandırıcıdır... bulunduğu scope terkeder. ve programın çağrıldığı yere döner..
            // dönüş tipi ile dönüş değeri eşit olmalıdır..
            // return;         // boş dön
            // return deger;  // değerli dön
            Console.WriteLine("Test test test test"); // return ifadesi kullanıldığı için bu satır çalıştırılmaz..
        }


        static private void Test()
        {
            // metot dönüş tipi void (boş) olduğu için return; ifadesi bu metotta kullanılır..
            return;
            // return 1;
        }
    }
}