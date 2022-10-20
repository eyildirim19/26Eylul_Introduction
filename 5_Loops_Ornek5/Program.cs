namespace _5_Loops_Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jump deyimleri => bu üç ifadeninde ortak noktası alt satırlarındaki komutları çalıştırmaz...
            // contiune => döngülerde kullanılna bir jump deyimidir. alt satırındaki hiç bir ifadeyi çalıştırmaz. döngünün sonraki aşamasına geçer... 
            // break    => döngüyü sonlandırır.  (döngü ve switch case yapılarında kullanılır)
            // return   => metodu sonlandırır (daha sonra detaylı konuşacağız)
            // continue kullanımı döngü içerisinde gereksiz if - else gibi yapılardan kurtmamızı sağlar...
            float vize, final, ort, enbOrt = 0, enkOrt = 100,ortToplam=0;
            string ogrAd, ogrAdEnb = "", ogrAdEnk = "";
            Console.WriteLine("Öğrenci sayısını giriniz");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

            #region "for ile"


            //for (int i = 0; i < ogrenciSayisi; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. vize notunuzu giriniz");
            //    vize = Convert.ToSingle(Console.ReadLine());
            //    //if (vize < 0 || vize > 100)
            //    //{
            //    //    i--;
            //    //    continue;
            //    //}

            //    Console.WriteLine($"Lütfen {i + 1} final notunuzu giriniz");
            //    final = Convert.ToSingle(Console.ReadLine());
            //    //if (final < 0 || final > 100)
            //    //{
            //    //    i--;
            //    //    continue;
            //    //}

            //    #region "ifelse ile"
            //    //if ((vize < 0 || vize > 100) || (final < 0 || final > 100))
            //    //{
            //    //    i--;
            //    //}
            //    //else
            //    //{
            //    //    ort = vize * 0.4f + final * 0.6f;
            //    //    // işlemlerimizi yapacağız...
            //    //}
            //    #endregion
            //    if ((vize < 0 || vize > 100) || (final < 0 || final > 100))
            //    {
            //        i--;
            //        continue;
            //    }

            //    ort = vize * 0.4f + final * 0.6f;
            //}
            #endregion
            int n = 0;
            while (n < ogrenciSayisi)
            {
                Console.WriteLine($"Lütfen {n + 1}. öğrencinin adını giriniz");
                ogrAd = Console.ReadLine();

                Console.WriteLine($"Lütfen {n + 1}. vize notunuzu giriniz");
                vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"Lütfen {n + 1} final notunuzu giriniz");
                final = Convert.ToSingle(Console.ReadLine());

                if ((vize < 0 || vize > 100) || (final < 0 || final > 100))
                    continue;

                ort = vize * 0.4f + final * 0.6f;
                ortToplam += ort;
                if (ort > enbOrt)
                {
                    enbOrt = ort;
                    ogrAdEnb = ogrAd;
                }
                if (ort < enkOrt)
                {
                    enkOrt = ort;
                    ogrAdEnk = ogrAd;
                }
                n++;
            }
            Console.WriteLine($"Sınıf Geçme Notu {ortToplam / ogrenciSayisi}");
            Console.WriteLine($"En Büyük Ortalama {enbOrt}. Öğrenci Adı ={ogrAdEnb}");
            Console.WriteLine($"En Küçük Ortalama {enkOrt}. Öğrenci Adı ={ogrAdEnk}");
        }
    }
}