namespace _5_Loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While ve Do while");


            /*
             * döngüler => koşul doğrultusunda kod(lar)'ın tekrar çalışmasını sağlayan bloklardır...
             * döngünün içerisindeki kodun çalışması öncelikle koşulun sağlanması gerekir. 
             * while ve do while  for ve while döngüleri bu şekilde çalışır...
                koşullu döngülerdir
            while(<kosul>)
            {
                <kosullukod>
            }

            do while => ilk çalıştığında önce kodu sonra koşulu çalışıtırır. daha sonra aşamada koşul ve kodu çalıştırır.eğer koşul gerçekleşirse kodu çalıştır. yani koşula bakmaksızın ilk çalışmada koşullu kodu çalıştırır...
            // çok tercih edilen bir döngü değildir...
            do
            {
                <kosullukod>
            }
            while(<kosul>);
             */
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"{i}");
                i++;
            }
            Console.WriteLine("*********************************");
            while (i > 0)
            {
                Console.WriteLine($"{i}");
                i--;
            }
            Console.WriteLine("****************************"); 
            int j = 10;
            do
            {
                Console.WriteLine($"{j}");
                j++;
            }
            while (j < 10);
            Console.WriteLine("****************************");
            do
            {
                Console.WriteLine($"{j}");
                j--;
            }
            while (j > 0);


            Console.ReadKey();
        }
    }
}