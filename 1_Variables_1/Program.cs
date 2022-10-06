namespace _1_Variables_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break point...çalışma zamanında (runtime) proje'nin durması için bırakılır. proje durur ve ilertilerek devam ettirilir. runtime'da çalışan projenin değerlerini görmek için kullanılır
            Console.WriteLine("Variables 1");
            // c# dilinde tipler 2'ye ayrılırlar
            // 1 value type      (değer tipler)       = sadece değer tutan tiplerdir.(string hariç diğer değişkenler tiplerimiz value type grubuna girer).. (struct tipindekiler value type)

            // 2 references type (referanslar tipler) = string bir referans tiptir. birden fazla char'ın referansını tutar. Not:string özel bir tiptir. Bu konuya ileride detaylı değineceğiz.. (class tiptekiler referans type) 

            // struct ve class konularına ileride detaylı değineceğiz..
            // not : değişkenler 1'kere tanımlanır daha sonra tipleri değiştirilemez...
            int a = 1;
            int b;

            int c = 100;
            int d = c; // c'yi d'ye ata... // c'nin değerini (value) d'ye kopyala
            c = 105;
            Console.WriteLine($"c'nin değeri {c}"); // c'nin değerini ekrana yazdır
            Console.WriteLine($"d'nin değeri {d}"); // d'Nin değerini ekrana yazdır
            d = 200;
            Console.WriteLine($"d'nin değeri {d}");

            Console.WriteLine("BUndan sonra dersleri buradan takip ediyoruz...");

            Console.ReadKey(); // console penceresini kapanmaması için yazdık...
        }
    }
}
// Not : solution'da birden falza proje varsa, çalıştırmak istediğiniz projeyi toolbdardan projeyi seçerek veya projeye sağ click yaparak set as startup project diyebilirsiniz...