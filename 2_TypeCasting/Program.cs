namespace _2_TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Casting");
            /*
             * 
             * 
             Type Casting => büyük tipin küçük tipe dönüşümüdür. büyük tipten küçük tipe dönüşüm yaparken veri kaybı yaşanağı ihtimali olduğu için bu dönüşümü developer'a bırakmaktadır. 


                tip degisken = (donusecektip)buyukdegisken

             */

            int i = 100;
            int j = i;

            // = operatörlerinde kural sağdaki değer ile soldaki değişken tip olarak eşit olmalıdır
            string str = "a";
            //int c = str; // tipler eşit olmadığı için bu atama mümkün değildir..
            // küçük tipler atama'da büyük tipe dönüştürülür...bu dönüşüm otomatik yapılır. bu tür dönüşümlere kapalı (implicit) dönüşüm denir...

            byte b = 100;
            short s = 500;
            int k = b;
            int l = s;
            long lng = l;
            i = 100;
            //b = i; // atama yapılamaz. çünkü int byte'tan büyüktür, atama yapabilmek için type casting yapmak gerekir
            b = (byte)i; // int'i byte'a dönüştür..
            l = (int)lng; // long'u int'e dönüştür..

            //string str1 = (string)i; // bu dönüşüm yapılamaz. çünkü cast işlemi sadece ortak değerli tiplerde yapılır

            // dikkat => type casting'de dönüşüm sırasında veri kaybı yaşanabilir. bu durumda ciddi mantık hataları ortaya çıkarabilir. değer'den emin olduğumuz sürece tercih etmeliyiz...
            byte num;
            int sayi = 260;
            num = (byte)sayi;
            short val = (short)sayi; // explicity convert (açık dönüşüm)

            Console.WriteLine($"sayinin değeri {sayi} num'ın değeri {num} val'in değeri {val}");
            Console.ReadKey();

            // object tipi c# dilinde bütün tiplerin atasıdır. yani bütün tiplerden büyük

            // tiplerden object'e dönüşüme boxing işlemi denir
            object o = 1;
            object v = "bt akademi";
            object m = 3.1f;
            object n = 3.1;


            // object'ten tiplere dönüşüme unboxing işlemi denir..
            float fl = (float)m;

            // 1 00000100
        }
    }
}