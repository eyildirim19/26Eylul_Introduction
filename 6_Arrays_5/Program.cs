namespace _6_Arrays_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizideki elemanlarının adetlerini bulma...
            char[] chars = { 'z', 'a', 'b', 'a', 'a', 'd', 'e', 'e', 'c' };
            char[] charunique = new char[0]; // dizinin elemanlarını benszersiz tutabilmek için
            int[] items = new int[0]; // eleman adetlerini tutmak için

            for (int i = 0; i < chars.Length; i++) // dizinin elemanlarında dönüdülür..
            {
                char aranan = chars[i]; // sıradaki eleman alınır 
                int arananIndex = Array.IndexOf(chars, aranan); // dizide elemanı ara

                if (arananIndex > -1) // aranan eleman unique dizinsinde varsa işlemler yapılmıştır döngünün sonraki adımına geç
                    continue;

                int adet = 0;  // 1 adet dizide vardır... 
                while (arananIndex != -1) // eleman var ise
                {
                    adet++; // adeti artrır..
                    arananIndex = Array.IndexOf(chars, aranan, arananIndex + 1); // tekrar bak dizide başka eleman var mı?. eleman dizinin bulunan indexinden sonra tekrar aranır...
                }

                //for (int k = 0; k < chars.Length; k++) // arama yapılır
                //    if (chars[i] == chars[k])
                //        adet++;
                Array.Resize(ref charunique, charunique.Length + 1); // dizide 1 elemanlık yer açıyoruz..
                Array.Resize(ref items, items.Length + 1); // dizide 1 elemanlık yer açıyoruz...

                // eleman ve adeti dizilere ekle...
                charunique[charunique.Length - 1] = chars[i];
                items[items.Length - 1] = adet;
            }
            // yazıyoruz....
            for (int i = 0; i < charunique.Length; i++)
                Console.WriteLine($"{charunique[i]} elemanından {items[i]} adet var");
        }
    }
}