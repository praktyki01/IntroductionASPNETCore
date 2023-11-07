using IntroductionASPNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntroductionASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Aby wysłać dane z kontrolera do widoku, możemy użyć ViewBag
        //Po słowie ViewBag i kropce,
        //dajemy nazwe aby przesyłana treść wyświetliła się w widoku,
        //musimy w widoku wywołać ViewBag
        public IActionResult Form1()
        {
            ViewBag.info1 = "Pozdrowienia z kontrolera!";
            ViewBag.info2 = "Ładna dziś pogoda!";
            ViewBag.info3 = "Pozdrowienia dla Patryka Porzeczki PDW!";
            ViewBag.info3 = "Kocham Unibet!";
            return View();
        }

        //Aby odebrać w kontrolerze treść przesłaną przez QUERY String,
        //metoda w kontrolerze musi mieć parametr odpowiadający danym,
        //wysyłanym w QUERY Stringu.
        public IActionResult Form2(string parametr1)
        {
            return View();
        }

        public IActionResult Quiz1(string odpowiedz)
        {
            if(odpowiedz=="warszawa"){
                ViewBag.odpowiedz = "Odpowiedź jest poprawna!";
            }
            else if(odpowiedz!=null)
            {
                ViewBag.odpowiedz = "Odpowiedź niepoprawna!";
            }
            return View();
        }


        //Aby wysłać dane za pomocą formularza w widoku musimy stworzyć znacznik form,
        //formularz musi wskazywać odpowiednią metode w kontrolerze,
        //odczytanie danych to parametry odpowiadające znacznikom name.
        public IActionResult Form3(string email, string password)
        {
            if (email == "admin@admin.pl" && password == "admin1")
            {
                ViewBag.zalogowany = "Zostałeś zalogowany " + email; 
            }
            else if(email!=null)
            {
                ViewBag.zalogowany = "Niepoprawne dane!";
            }
            return View();
        }

        public IActionResult Form4(string imie, string nazwisko, string klasa, string szkola, int rok)
        {
           ViewBag.dane = imie + " " + nazwisko + " " + klasa + " " + szkola + " " + rok + "";
           return View();
        }

        public IActionResult Form5()
        {
            List<string> miesiace = new List<string>();
            miesiace.Add("Styczeń");
            miesiace.Add("Luty");
            miesiace.Add("Marzec");
            miesiace.Add("Kwiecień");
            miesiace.Add("Maj");
            miesiace.Add("Czerwiec");
            miesiace.Add("Lipiec");
            miesiace.Add("Sierpień");
            miesiace.Add("Wrzesień");
            miesiace.Add("Październik");
            miesiace.Add("Listopad");
            miesiace.Add("Grudzień");
            ViewBag.miesiace = miesiace;
            return View();
        }

        public IActionResult Form6()
        {
            List<string> poryroku = new List<string>();
            poryroku.Add("Wiosna");
            poryroku.Add("Lato");
            poryroku.Add("Jesień");
            poryroku.Add("Zima");
            ViewBag.poryroku = poryroku;
            return View();
        }

        public IActionResult Form7()
        {
            List<string> dnitygodnia = new List<string>();
            dnitygodnia.Add("Poniedzialek");
            dnitygodnia.Add("Wtorek");
            dnitygodnia.Add("Środa");
            dnitygodnia.Add("Czwartek");
            dnitygodnia.Add("Piątek");
            dnitygodnia.Add("Sobota");
            dnitygodnia.Add("Niedziela");
            ViewBag.dnitygodnia = dnitygodnia;
            return View();
        }

        public IActionResult PoryRokuJezyki(string jezyk)
        {
            ViewBag.poryroku = new List<string>();
            if (jezyk == "polski")
            {
                List<string> poryroku = new List<string>();
                poryroku.Add("Wiosna");
                poryroku.Add("Lato");
                poryroku.Add("Jesień");
                poryroku.Add("Zima");
                ViewBag.poryroku = poryroku;
            }
            else if (jezyk == "angielski")
            {
                List<string> poryroku = new List<string>();
                poryroku.Add("Winter ");
                poryroku.Add("Spring ");
                poryroku.Add("Summer ");
                poryroku.Add("Autumn ");
                ViewBag.poryroku = poryroku;

            }else if (jezyk == "niemiecki")
            {
                List<string> poryroku = new List<string>();
                poryroku.Add("der Frühling");
                poryroku.Add("der Sommer");
                poryroku.Add("der Herbst");
                poryroku.Add(" der Winter");
                ViewBag.poryroku = poryroku;
            }
            return View();
        }

        public IActionResult Form8(string BronieFortnite)
        {
            ViewBag.BronieFortnite = BronieFortnite;
            return View();
        }

        public IActionResult Form9()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}