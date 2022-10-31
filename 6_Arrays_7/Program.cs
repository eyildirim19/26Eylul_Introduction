namespace _6_Arrays_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region "2 boyoutlu ve çok boyutlu diziler"


            // 2 boyutlu dizi
            int[,] nots = new int[3,3];
            // 0. dizinin elemanlarını set ettik...
            nots[0, 0] = 50;
            nots[0, 1] = 100;
            nots[0, 2] = 150;
            // 2. dizinin elemanları
            nots[1, 0] = 200;
            nots[1, 1] = 250;
            nots[1, 2] = 300;
            // 2. dizinin elemanları
            nots[2, 0] = 350;
            nots[2, 1] = 400;
            nots[2, 2] = 450;

            //Console.WriteLine($"{nots.Length}  {nots.LongLength}");
            Console.WriteLine(nots.Length + " " + nots.LongLength);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{nots[i, j]} ");
                }
                Console.WriteLine();
            }

            // çok boyutlu jagged diziler
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];
            // 1. dizi
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 2;
            jaggedArray[0][2] = 3;

            // 2. dizi
            jaggedArray[1][0] = 1;
            jaggedArray[1][1] = 2;

            //Console.WriteLine($"{nots.Length}  {nots.LongLength}");
            Console.WriteLine(jaggedArray.Length + " " + jaggedArray.LongLength);

            #endregion


            //string cevap = "evet";
            //while (cevap == "evet")
            //{
            //    // bilgiler alınır
            //    Console.WriteLine("Başka öğrencin var mı???");
            //    cevap = Console.ReadLine();
            //}

            //string result;
            //do
            //{
            //    // bilgiler alınır
            //    Console.WriteLine("Başka öğrencin var mı???");
            //    result = Console.ReadLine();
            //}
            //while (result == "evet");

            //for (string elcevap = "evet"; elcevap == "evet";)
            //{
            //    // Bilgiler alınır
            //    Console.WriteLine("Başka öğrencin var mı?");
            //    elcevap = Console.ReadLine();
            //}

            int value = 300;
            byte b;

            b = (byte)value; // veri kaybı yaşanır..
            //b = (byte)"10"; //casting ile dönüşüm ortak tipler yapılabilir

            //b = Convert.ToByte(value); // overflow exception fırlatır
            //b = Convert.ToByte("deneme"); // format exception fırlatır

            //b = Convert.ToByte("45");
            //b = Convert.ToByte(Console.ReadLine());

            int ic = 'e'; // bu atama'da e'nin ascii codu atanır..
            int jc = 'E';

            Console.WriteLine(ic);
            Console.WriteLine(jc);

            for (var i = 'a'; i < 'z'; i++)
                Console.Write($"{i} ");


            // Kullanıcıdan öğrencinin vize, final ve ornolarını alalım..
            string[] ogrNos = new string[0];
            float[] vizes = new float[0];
            float[] finals = new float[0];
            float[] ortalama = new float[0];
            int index = 0;
            string r;
            do
            {
                Array.Resize(ref ogrNos, ogrNos.Length + 1);
                Array.Resize(ref vizes, vizes.Length + 1);
                Array.Resize(ref finals, finals.Length + 1);
                Array.Resize(ref ortalama, ortalama.Length + 1);

                Console.WriteLine($"{index + 1}.öğrenci no giriniz");
                ogrNos[index] = Console.ReadLine();

                Console.WriteLine($"{index + 1}. öğrenci vize giriniz");
                vizes[index] = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{index + 1}. öğrenci final giriniz");
                finals[index] = Convert.ToSingle(Console.ReadLine());

                ortalama[index] = vizes[index] * 0.4f + finals[index] * 0.6f;

                // ortalama
                Console.WriteLine("Başka Öğrenci Var mı???");
                r = Console.ReadLine();
                index++;
            } while (r == "evet");


            float sinifOrtalama = ortalama.Average(); // ortalamayı hesapla...


            for(int i=0; i< ortalama.Length; i++)
            {
                string durum="geçti";
                if (ortalama[i] < sinifOrtalama)
                {
                    durum = "kaldi";
                }
                Console.WriteLine($"{ogrNos[i]} {ortalama[i]} {durum}");
            }

            // OgrNo Ort Kaldı/Geçti
        }
    }
}