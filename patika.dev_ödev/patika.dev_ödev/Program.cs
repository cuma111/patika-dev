using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika.dev_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değişken Tanımlama
            string deger = null;
            //string System = Degisken; //Program içerisinde kullanılan isimler degişken olarak kullanılmaz.
            // rakamla degısken adına baslanmaz
            // degısken tanımlanırken bosluk kullanılamaz
            // _ kullanılabılır ama + -  gıbı operoterler degısken tanımlarken kullanılamaz.
            Console.WriteLine(deger);

            //Veri Tipleri
            byte b = 5; //0-255 1byte
            sbyte a = 5; //-128 - +127 1byte
            short s = 5; //-32.000 - +32.000 2byte
            ushort u = 5;//0 -  65365 2byte

            Int16 i16 = 2; // 2byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4byte
            Int64 i64 = 2; //8 byte
            uint ui = 2; //4byte
            long l = 2; //8byte
            ulong r = 2; //8byte

            float f = 5; //4byte
            double d = 5.4; //8byte

            char c = 'a'; //2byte
            string str1 = "Cuma"; //sınırsız

            bool bl = false;

            DateTime dt = DateTime.Now; // şu anki tarih ve saat karşılığını getirir.
            Console.WriteLine(dt);

            object o1 = "x";//string
            object o2 = 'y';//char
            object o3 = 4.5;
            object o4 = 6;
            //Objelere her türden veri atanabilir.

            //String Tanımlama Şekilleri
            string str = string.Empty;//stringe boş değer atar.
            str = "Cuma Aslaner";
            string ad = "Cuma";
            string soyad = "Aslaner";
            string tam_ad = ad + " " + soyad;

            //Integer Tanımlama Şekilleri
            int int1 = 5;
            int int2 = 3;
            int in3 = int1 * int2;

            //Bool
            bool b1 = 10 > 2;//True değer döndürür.

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string str3 = str20 + int20.ToString();
            Console.WriteLine(str3);//2020 şeklinde string olarak birleştirir.

            int int3 = int20 + Convert.ToInt32(str20);//Bu sefer string int e çevrilerek toplamları yazdırılır.
            //Covert.To() metodu ile string birçok veri tipine çevrilebilir ama int e çevirmek için daha çok int.Parse() kullanılır.
            Console.WriteLine(int3);//Çıktısı 40 olur.

            int int4 = int20 + int.Parse(str20);//String int e çevrilir ve 40 döndürülür.
            // Parse kullanılırsa stringten çevrilmek zorundadır.
            Console.WriteLine(int4);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyyy");//şu anki zaman string veritipinde gün.ay.yıl olarak gelir. 
            Console.WriteLine(datetime1);
            string hour = DateTime.Now.ToString("HH.mm");//Saati string olara saat ve dakika olarak getirilir.
            Console.WriteLine(hour);
        }
    }
}
