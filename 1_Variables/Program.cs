namespace _1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veri (data) =>elektronik ortamda bilginin işlenmemiş halidir. 
            // veriler ram'da saklarız..
            // veriler uygulama içerisinde geçici olarak değişkenlerde saklanır..

            // değişken (variable) nedir ? değişkenler verileri bellekte adreslemek için kullanılır...veriler uygulama içierisinde veritipleri ile işaretlenir

            // c# dilinde veritiplerini üç ana başlıkta inceleriz
            // metinsel tipler (string, char)
            // sayılar tipler = tam sayılar (byte,sbyte,short,ushort,int,uint,long,ulong) ondalık sayı tipleri (float,decimal, double)
            // mantıksal tip (bool)

            // değişken;
            // <veriTipi> degiskenAdi;
            // <veriTipi> degiskenAdi = deger
            // Not: deger ile veritipi aynı olmalıdır..
            // =  (atama operatörüdür). sağındaki değeri solundakine atar...

            byte sayi = 1;
            sayi = 20; // değer değiştir...

            //Console.WriteLine("Değişkenin değeri " + sayi);
            Console.WriteLine($"Değişkenin değeri {sayi}"); // çıktısı    =>  Değişkenin değeri 1
            Console.WriteLine($"{sayi} Değişkenin değeridir"); // çıktısı =>  1 Değişkenin değeridir...

            //byte b1 = 300; // 300 değeri byte için büyük bir değerdir. bu yüzden bu değer byte atanamaz..

            // tip sadece tanımlama yapılırken yazılır
            int i = 2; // değişken tanımı yapılır ve ilk değer atanır
            int k; // değişken tanımı yapılır


            i = 4; // değişkenin değeri atanır.


            // Kural;
            // 1. değişken isimleri bulundukları scope içerisinde unique olmalıdır
            //int i = 4; // i isimli değişken yukarıda tanımlı olduğu için hata alırız..

            // 2. değişken isimleri rakam veya özel karakter ile başlamaz...
            short value = 4;
            int value1 = 44;

            // 3. değişken isimleri arasında boşluk olamaz...iki kelimeli bir değişken ismi varsa _ ile ayrılabilir
            // int ogr no // bu şekilde bir tanım yapılamaz...
            int ogrno = 12313;
            int ogr_num = 12313;

            // 4. aynı tipte değişkenkenler tek satırda tanımlanabilir;
            int num1, num2, num3 = 4;


            // 5. değişkenlere değer atarken tip ile değer aralığı uyumlu olmalıdır
            // byte b1 = 300; // 300 byte için büyük bir değerdir. byte'ın değer aralığı 0-255 arasıdır...


            // 6. değişken isimlerinde ön tanımlı (c# tarafından kullanılan isimler) kullanılamaz.

            //int short = 5; // short c# dilinde kullanılan bir name(isim) olduğu için değişken ismi olarak kullanılamaz...
            short snum = 5;
            ushort usnum = 5;

            int num = -1;
            uint unum = 1;
            // kod editöründe...
            // 3 (int)tamsayı olarak yorumlanır
            // 3.1 double olarak yorumlanır
            // value'nın sonuna f eklersek float, m eklersek decimal olarak yorumlar
            // false veya true bool olarak yorumlanır
            // 'E' char olarak yorumlanır
            // "E" string olarak yorumlanır
            double dnum = 3.1;
            decimal money = 44.1m;
            decimal val = 35.1m;
            float fl = 3.1f;

            char c = 'e';
            //char c1 = 'ee'; // char değerler tek karakter olabilir. eğer birden fazla karakterlik veri varsa o zaman string kullanılır
            string str = "ee";
            string ismi = "bt akademi";
            string kitap_ismi = "Her Yönüyle C#";

        }
    }
}