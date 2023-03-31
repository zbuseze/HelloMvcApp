using HelloMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApp.Controllers
{
    public class OgrenciController : Controller
    {
        //public string Index()
        //{
        //    return "Buse";
        //}(
        public ViewResult Index()
        {

            return View();
        }
        public ViewResult OgrenciBilgi(int id)
        {
            var ogr = new Ogrenci();   // var yerine dynamic yazılabilir. 

            if (id == 1)
            {
                ogr.Ad = "Ali";
                ogr.Soyad = "Veli";
                ogr.Numara = 123;
            }
            else if (id == 2)
            {
                ogr.Ad = "Ahmet";
                ogr.Soyad = "Mehmet";
                ogr.Numara = 456;
            }
            else
                ogr = null;

            ViewData["Student"] = ogr;

            var ogretmen = new Ogretmen { Ad = "Buse", Soyad = "Zengin", Tckimlik = "49990837483" };

            ViewBag.Teacher = ogretmen;

            var infodto = new InfoDTO(ogr, ogretmen);
            // MODEL İÇİN
            return View(infodto);
        }

        public ViewResult OgrenciListe()
        {
            var ogr1 = new Ogrenci { Ad = "Buse", Soyad = "Zengin", Numara = 9876 };
            var ogr2 = new Ogrenci { Ad = "Burak", Soyad = "Zengin", Numara=567 };
            Ogrenci[] ogrenciler = new Ogrenci[Ogrenci.count];

            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;

            return View(ogrenciler);
        }
    }
}

// Action içerisinde parametrede yer alan variable, url'deki id'dir.
// Contollerdan datayı view'e atamak : ViewData[""]= variable;
// ViewData: Collection - Key Value Pair
// Keyler tekil olmalıdır.
// Collection: A list is a group of items −
// Dictionary: Dictionary is a set of key-value pairs.


//Dictionary<string, int> d = new Dictionary<string, int>();

//d.Add("squash", 1);
//d.Add("football", 2);
//d.Add("rugby", 3);

// ViewBag arka planda ViewData Koleksiyonunu kullanılır. ViewData'da kullanılan bir key değeri, ViewBag'de kullanılmamalıdır.
// ViewBag object tipinde veri taşır ancak kendisi dynamic'tir.
// Dynamic yapıların içindeki verilerin tipi, runtime sırasında tespit edilir.