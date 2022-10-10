namespace _2_TypeConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Convert");
            /*
                Convert=> tür dönüşümleri => değerlerin farklı türlere dönüşümleridir...
             */
            string numstr = "100";
            byte num = Convert.ToByte(numstr); // numstr'Nin değerini byte'a dönüştür...


            //Dönüşüm işlemlerinde değer tipe format olarak uygun olmalıdır
            //int val = 260;
            //num = Convert.ToByte(val); // değer eğer byte için büyük veya küçük ise runtime'da hata verir..

            //int sayi = Convert.ToInt32("bt akademi"); // bt akademi değer olarak numeric bir değer değildir. bu yüzden dönüşüm işlemi yapılamaz...

            int a, b, c;
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine($"{a} sayisi ile {b} sayısının toplamı {c}");

            //Convert sınıfının metotları
            // ToByte => byte dönüştürü
            // ToSByte => sbyte dönüştür
            // ToInt16 => short'a dönüştür
            // ToInt32 => int'e dönüştür
            // ToInt64 => long'a dönüştür
            // ToSingle => flot'a dönüştür
            // ToDouble => double'a dönüştür
            // ToDecimal => decimal'a dönüştür
            // ToBoolean => bool'a dönüştür
            // ToString => string'e dönüştür
            // ToChar  => char'a dönüştürür
        }
    }
}