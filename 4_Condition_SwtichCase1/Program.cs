namespace _4_Condition_SwtichCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir değer giriniz");
            char c = Convert.ToChar(Console.ReadLine());

            // ToUpper => karakteri büyük  yapar
            // ToLower => karakteri küçük yapar

            Console.WriteLine($"girdiğiniz değer {char.ToUpper(c)}-{char.ToLower(c)}");
            //if(c=='A' || c=='a')
            if (char.ToUpper(c) == 'A' || char.ToUpper(c) == 'E' || char.ToUpper(c) == 'U' || char.ToUpper(c) == 'Ü' || char.ToUpper(c) == 'I' || char.ToUpper(c) == 'İ' || char.ToUpper(c) == 'O' || char.ToUpper(c) == 'Ö')
            {
                Console.WriteLine("Sesli");
            }
            else
            {
                Console.WriteLine("Sessiz");
            }

            switch (char.ToUpper(c))
            {
                case 'A':
                case 'E':
                case 'U':
                case 'Ü':
                case 'I':
                case 'İ':
                case 'O':
                case 'Ö':
                    Console.WriteLine("Sesli");
                    break;
                //case 'E':
                //    Console.WriteLine("Sesli");
                //    break;
                default:
                    Console.WriteLine("Sessiz");
                    break;
            }


            // when yapısı bu özellik 7.0 ile gelmiştir
            switch (char.ToUpper(c))
            {
                case char k when k > 10 || k == 'E' || k == 'I' || k == 'İ' || k == 'O' || k == 'Ö' || k == 'U' || k == 'Ü':
                    Console.WriteLine("Sesli");
                    break;
                default:
                    break;
            }


            float ortalama = 50;
            string harfNo = "";
            switch (ortalama)
            {
                case float n when n > 80 && n <= 100:
                    harfNo = "AA";
                    break;
                case float n when n > 70 && n <= 80:
                    harfNo = "BA";
                    break;
                case float n when n > 50 && n <= 70:
                    harfNo = "CC";
                    break;
                default:
                    harfNo = "FF";
                    break;
            }

            Console.WriteLine(harfNo);
            int gun = 3;
            // swtich expression 9.0 ile birtlikte gelmiştir...
            string test = gun switch
            {
                1 => "Pazartesi",
                2 => "Salı",
                3 => "Çarşamba"
            };


            Console.WriteLine("Test");



            string ay = "ŞUbAt";
            string mevsim = "";
            int aaa;
            switch (ay.ToUpper())
            {
                case "OCAK" or "ŞUBAT" or "MART":
                    mevsim = "KIŞ";

                    if (ay == "OCAK")
                        aaa = 1;
                    else if (ay == "ŞUBAT")
                        aaa = 2;
                    else
                        aaa = 3;

                    break;
                case "HAZİRAN":
                case "NİSAN":
                case "MAYIS":
                    mevsim = "İLK BAHAR";
                    aaa = 4; // geçici değer atadım. bunu silersiniz...
                    break;
                default:
                    mevsim = "BULUNAMADI";
                    aaa = -1;
                    break;
            }

            Console.WriteLine($"MEVSİMLERDEN {mevsim}. AYLARDAN {aaa}. AY");


            if (ay.ToUpper() == "OCAK" || ay.ToUpper() == "ŞUBAT" || ay.ToUpper() == "MART")
            {
                //Console.WriteLine("KIŞ");
                mevsim = "KIŞ";
            }
            else if (ay.ToUpper() == "NİSAN" || ay.ToUpper() == "MAYIS" || ay.ToUpper() == "HAZİRAN")
            {
                //Console.WriteLine("İLK BAHAR");
                mevsim = "İLK BAHAR";
            }
            else
            {
                mevsim = "BULUNAMADI";
            }
            Console.WriteLine($"MEVSİM {mevsim}");





            float vize = 50, final = 30, ort;

            //vize = Convert.ToSingle(Console.ReadLine());
            //final = Convert.ToSingle(Console.ReadLine());

            ort = vize * 0.4f + final * 0.6f;


            string harfNot = "";

            if (ort > 85 && ort < 100)
            {
                harfNo = "AA";
            }

            
            // when yapısı
            switch (ort)
            {
                case float f when f >= 85 && f <= 100:
                    harfNo = "AA";
                    break;
                case float f when f >= 70 && f <= 84:
                    harfNo = "BB";
                    break;
                default:
                    break;
            }
            // veya...

            // relational yapısı
            switch (ort)
            {
                case > 85 and < 100:
                    harfNo = "AA";
                    break;
                case > 70 and < 84:
                    harfNo = "AA";
                    break;
            }
            // veya
            
            Console.WriteLine($"ortalamınız {ort} harf notunuz  {harfNot}");



            Console.WriteLine("Hello, World!");
        }
    }
}