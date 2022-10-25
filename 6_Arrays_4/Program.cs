namespace _6_Arrays_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bubble Sort algoritmasını araştırınız. ve elemanları 4,1,9,5,19,2 olan diziyi bu yöntem ile sıralayınız...
            int[] nums = { 3, 5, 2, 1, 8 };
            string[] kisiler = { "İsmail", "Berat", "Ekrem", "Ayşenur", "Ramazan" };
            Array.Sort(nums); // Diziyi sıralar
            Array.Sort(kisiler); // Diziyi sıralar

            foreach (string item in kisiler)
                Console.WriteLine(item);

            Console.WriteLine("*****");

            foreach (int item in nums)
                Console.WriteLine(item);

            Console.WriteLine("*****");

            int[] nums1 = { 5, 4, 2, 6, 3, 8, 1 };
            Array.Reverse(nums1); // Diziyi ters çevirir..
            foreach (int item in nums1)
                Console.WriteLine(item);

            Console.WriteLine("*****");

            Array.Sort(nums1); // diziyi sırala
            Array.Reverse(nums1); // diziyi ters çevir
            foreach (int item in nums1)
                Console.WriteLine(item);




            // Dizilerden bağımsız bir konu;
            // var değer atandığında tip oluşan tiplerdir...
            var a = 1;
            var b = false;
            var arr = new int[] { 3, 5, 2, 1 };
            var arr1 = new string[] { "a", "b", "c", "d" };
            Console.WriteLine($"a nın değeri {a} tipi {a.GetType()}");
            Console.WriteLine($"b nın değeri {b} tipi {b.GetType()}");
            var isim = "bt akademi";
            var c = 'A';
            var pi = 3.1;
            Console.WriteLine($"isim nın değeri {isim} tipi {isim.GetType()}");
            Console.WriteLine($"c nın değeri {c} tipi {c.GetType()}");
            Console.WriteLine($"pi nın değeri {pi} tipi {pi.GetType()}");
            // a = "a"; // var tipli değişkenlere başlangıçtahangi tipte değer atandıysa o tipte değer atanabilir...
            //var i; // var değişkenlerde başlangıçta değer ataması zorunludur çünkü tip o esnada oluşacaktır...
            // eğer başlangıçta değer atanamıyorsa o zaman default(tip) ifadesi kullanılır
            var j = default(int); // j'nin tipi int olarak ayarlanır
            var k = default(string); // k'nin tipi string olarak ayarlanır
            // neden kullanırım ? forach gibi yapılarda bir kısa yol olarak düşünülebilir
            foreach (var item in nums)
                Console.Write(item);
            // anonim tiplerde (anonymous tpye) daha anlamlı hale gelecektir..
            // anonim tiplere kısa bir örnek. ilerleyen zamanlarda daha detaylı konuşuruz...
            // (anonymous tpye) new { } ifadelerine denir...
            var kisi = new
            {
                adi = "bural",
                soyadi = "öz",
                yas = 30,
                notlar = new int[] { 60, 89 }
            };
        }
    }
}