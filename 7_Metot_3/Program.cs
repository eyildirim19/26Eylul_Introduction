namespace _7_Metot_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metot Overload (metot aşırı yükleme) => bir sınıf içerisinde aynı isme sahip birden fazla metot tanımlanmasıdır....
            // metot overload => ismi aynı parametre sayıları ve tipleri farklı metotlara denir (metot imzası farkı metotlar tanımlama şeklidir) metot imzası metodun adı ve parametrelerini ifade eder..
            int r = Topla(3, 5, 1);
            int r1 = Topla(3, 3);
            int r2 = Topla(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        // 2. adet int parametre alan Topla metodu tanımlandığı için başka bu şekilde tanımlanamaz...
        static private int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static private int Topla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }
        static private int Topla(params int[] nums)
        {
            return nums.Sum();
        }
    }
}