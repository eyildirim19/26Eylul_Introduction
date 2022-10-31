namespace _7_Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "metot tanım..."


            /*            
            Metot => metot yazılımı meydana getiren kodlardır...örnek kullandığımız metotlar;
            Array.Sort
            Array.Indexof
            Convert.ToInt32
            Convert.ToByte
            vb

            metotlar belli bir işi yapmak için bir araya getirelen kod bloklarıdır..yani metot alt programdır..metot yazmaktaki amaç modül bazlı uygulama geliştirmektir bu sayede kodlar metotlar içerisine bir kere yazılır daha sonra kullanılır...

            <erisim_seviyesi> <donusTipi> <MetotIsmi>(<parametre> opsiyonel)
            {
                <metotGovdesi>
            }

            <erisim_seviyesi> => nereden erişilir. (access_modifiers=> private,protected,internal,public)

            <donusTipi> metodun dönüş değerini ifade eder. yani metot çalıştıktan sonra değer olarak ne dönecek dönüş tipi ile bu belirlenir.geri değer döne bilirler veya değer dönmezler.  Geriye değer dönmeyen metotlara örnek olarak. Array.Sort veya Array.Reverse metotları örnek gösterilebilir..geri değer dönen metotlar ToInt32,IndexOf,ToUpper vb. metotlardır..

            <metotIsmi> metodun tanımlandığı ve çağrıldığı isim

            <parametre> => scope'dan scope'a değer geçirmek için kullanılır..yani metodun gövdesine değer gönderimidir...parametre değerlerine argüman denir..

            Parametre
             */

            #endregion
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("*****************");
            // metot çağırma...
            MesajVer();
            MesajVer();
            MesajVer();
            //Mesaj(); // Mesaj metodu parametre aldığı için parametresinin verilmesi gerekir. paremetre değerlerine argüman denir...
            Mesaj("Selam");
            // argümanların tipleri parametre tipleri ile eşit olmalıdır...
            //Mesaj(2);
            //Mesaj(false);
            Mesaj("Hello");
            string arg = "Hi";
            Mesaj(arg);
            Console.WriteLine("Test");
        }
        // örnek metot tanımı
        // void=> geriye değer dönmeyen metot tanımlamak için kullanılır

        // Not : static keywordünü Main metodu static olduğu için yazdık..
        static private void MesajVer()
        {
            Console.WriteLine("Merhaba");
        }
        // parametre alan metot
        // string parametre alan metot
        static private void Mesaj(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}