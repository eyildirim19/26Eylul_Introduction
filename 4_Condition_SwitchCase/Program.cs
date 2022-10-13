namespace _4_Condition_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                switch case => bu yapıda if karar mekanizmaları gibi koşullu kod durumlarında kullanılır..

                Duruma göre daha sade if veya if else if yapılarının yerine için tercih edilir...

                // switch yapısında kontroldegiskeninin degeri caselerde verilir...switch case'de eşitlik kontrolü yapılır. eğer caselerden birisi sağlanmazsa  default yapısı çalışır. default'u else gibi düşünebilirsiniz..
                break => bu komut switch'i sonlandırmak için kullanılır. ayrıca break yazılması zorunludur..
                switch(kontroldegisken)
                 {
                        case kosul1:
                        break;  
                        case kosul2
                        break;
                        default:
                        break;
                 }

            Not : case'ler sabit olmalıdır. yani değişken olamazlar..

            Not : switch ifadesindeki tip ile case sabitlerinin tipi eşit olmalıdır..
             */

            Console.WriteLine("Lütfen 1 ile 4 arasında bir değer giriniz");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value) // kontrol edilecek değişken value. koşullar case'lerde tanımlanır
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                case 4:
                    Console.WriteLine("Dört");
                    break;
                default:
                    Console.WriteLine("Geçersiz değer");
                    break;
            }

            Console.WriteLine("lütfen bir sayı giriniz");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num > 0)
            {
                case true:
                    Console.WriteLine("Pozitif");
                    break;
                default:
                    Console.WriteLine("Negatif");
                    break;
            }
        }
    }
}