namespace _3_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatörler");

            /*
                progralama dillerindeki özel karakterlerdir. bu karakterler program içerisinde işlem yapmamızı sağlarlar.. değer veya değişkenler ile kullanularlar..örn;
                a+b => + operatörü metinsel ifadelerde birleştirme, sayılasal ifadelerde toplama işlemi yapar.buradaki a ve b ise + operatörünün operandlarıdır..

        aritmatik operatörler => iki değeri hesaplamak için kullanılır

        karşılaştırma operatörler => iki değeri karşılaştırmak için kullanılır
        mantıksal operatörler => ikiden fazla değeri karşılaştırmak için kullanılır

            karşılaştırma operatörleri ve mantıksal opeatörler geriye işlem yaptıktan sonra true veya false dönerler. bu değerler c# dilinde bool tipinin değerleridir. 

             */

            // aritmatik operatörler
            int result;
            result = 3 + 1;// topla
            result = 3 * 1; // çarp
            result = 3 / 1; // böl
            result = 3 - 1; // çıkar
            result = 3 % 1; // mod al (bölümden kalanı verir)

            result += 1; // result ile 1'i topla result'a ata..
            int k = 3;
            k += result; // k ile result'I topla k'ya ata..
            k *= result;
            k -= result;
            k /= result;

            int j = 1;
            j = j + 1;
            j += 1;
            // Not : 1 artımlarda veya azalımlar ++ veya -- operatörleride kullanılır
            j++;//'yi 1 attır
            j--;// j'yi 1 azalt
            ++j; // j'yi 1 arttır
            --j; // j'yi bir azalt

            int m = 1;
            int r = ++m; // m'yi arttır r'ya ata.
            Console.WriteLine($"r'nin değeri {r} m'nin değeri {m}"); // r= 2 m= 2
            r = 1;
            m = 1;
            r = m++; // m'yi ata sonra m'yi arttır

            Console.WriteLine($"r'nin değeri {r} m'nin değeri {m}"); // r = 1 m=2


            // Karşışaltırma operatöleri
            bool result1;
            result1 = 3 > 1; //true;
            result1 = 3 >= 3; // true // büyük eşit
            result1 = r < 1000; // true
            result1 = 3 <= 4;// true // küçük eşit
            result1 = 3 == 3; // true // == eşitlik operatörüdür
            result1 = result1 == false; //  false 
            result1 = result1 == false; //  true
            result1 = "a" != "b"; // eşit değil //true
            result1 = "a" != "a"; //false

            // mantıklal operatörler
            // karşılaştırma operaötrleirni birleştirmek için kullanılır...
            // mantıksal and (ve) && (shift + 6)
            // mantıksal or (veya) || (altgr + - )
            // mantıksal operatörlere kısa devre operatörlerde denir. eğer ilk karşılşatırma false ise diğerine bakmaz...

            // ve'de her iki karşılaştırmanın doğru olması gerekir.
            bool sonuc = 3 > 1 && 3 > 2; // true
            sonuc = 3 < 1 && 3 > 1; // false
            sonuc = 3 > 1 && 3 == 10; // false
            sonuc = 3 == 100 && 4 == 8; // false


            //mantısal veya karışlaştırmalardan birisinin true olması yeterlidir
            sonuc = 3 > 1 || 3 > 2; // true
            sonuc =  3 < 1 || 3 > 1; //true
            sonuc = 3 > 1 || 3 == 10;// true
            sonuc = 3 == 100 || 4 == 8; // false

            Console.WriteLine("test");

        }
    }
}