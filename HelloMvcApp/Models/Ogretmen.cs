namespace HelloMvcApp.Models
{
    public class Ogretmen
    {
        public Ogretmen()
        {

        }
        public Ogretmen(string ad, string soyad,string tckimlik)
        {
            this.Ad = ad;
            this.Soyad= soyad;
            this.Tckimlik = tckimlik;
        }
        public int Ogretmenid { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckimlik { get; set; }
        public override string ToString()
        {
            return $"Ad: {this.Ad} Soyad: {this.Soyad} Tc Kimlik: {this.Tckimlik}";

        }
    }
}
// Entitiy
// ToString() : virtual bir object oldugu icin polimorpishm yani, Base class için override edilebilir. 