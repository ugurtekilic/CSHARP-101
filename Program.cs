using System;


namespace  degisken
{

    class Program
    {

        static void Main(string[] args)
        {           

            byte b = 5; // byte sadece 0-255 olan karakterleri alır ve hafızada 1 byte yer kaplar
            sbyte c = 5; // sbyte sadece -128-127 olan karakterleri alabilir ve hafızada 1 byte yer kaplar
           
            short s = 5; // (-32678)-(32678) bellekte 2 byte yer kaplar
            ushort u = 5; // 0-65365 bellekte 2 byte yer kaplar 
            
            Int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte (-2m)-(2m)
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 2; // 8 byte
            ulong ul = 2; // 8 byte +değerler alan hali
           
           // Reel Sayılar
            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2'; // 2 byte 
            string str = "uğur"; // Sınırsız yer kaplar

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine("Tarih "+ dt);

            object o1 = "i";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 5.4;

            //String ifadeler
            string str1 = string.Empty;
            str1 = "Uğur Tekkılıç";
            string ad = "Uğur";
            string soyad = "Tekkılıç";
            string tamisim = ad + " " + soyad;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yenideger = str20 + " " + int20.ToString();
            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //DateTime
            string datetime = DateTime.Now.ToString("dd.MM.yyy");
            Console.WriteLine(datetime);
            
            int degisken1 = 1;
            string degisken1 = "merhaba";
            Console.WriteLine(degisken1);
        }
    }
}