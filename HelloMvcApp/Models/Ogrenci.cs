using System;

namespace HelloMvcApp.Models
{
    public class Ogrenci
    {
        public static int count = 0; // Oluşturulan obje sayısı 
        public Ogrenci()
        {
            count++;
        }
        
        public int Ogrenciid { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }


        public override string ToString()
        {
            return $"Ad: {this.Ad} Soyad: {this.Soyad} Numara: {this.Numara}";
        }
    }
}

// Entitiy
// ToString() : virtual bir object oldugu icin polimorpishm yani, Base class için override edilebilir. 