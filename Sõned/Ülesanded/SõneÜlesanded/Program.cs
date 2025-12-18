namespace SõneÜlesanded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm mis
            //küsib kasutajalt tsüklis, millised mängud talle meeldivad
            //küsimiste tulemus hoia järjendis
            List<string> mängud = new List<string>();
            Console.WriteLine("Tere kasutaja, millised mängud sule meeldivad?");
            string mäng = "";
            while (mäng != "ei ole")
            {
                Console.WriteLine("Palun sisesta järgmine mäng, kui ei ole kirjuta \"ei ole\"");
                mäng = Console.ReadLine();
                if (mäng != "ei ole")
                {
                    mängud.Add(mäng);
                }
            }
            //kui järjend sisaldab (.Contains()) "mario kart", siis küsi kui vana ta on, sarkastiliselt.
            if (mängud.Contains("mario kart"))
            {
                Console.WriteLine("Kui vana sa oled? mingi 5 või?"); //sarkasm, allegedly
            }
            //kui järjend sisaldab "gta 6", siis küsi kust ta ajamasina sai, et rockstar lõpuks asjaga valmis sai
            if (mängud.Contains("gta 6"))
            {
                Console.WriteLine("Kust sa ajamasina said, et rockstar lõpuks asjaga valmis sai");
            }
            //kui järjend sisaldab "pong", siis ütle "80ndad tahavad vanureid tagasi, toimub boomerite recall"
            if (mängud.Contains("pong"))
            {
                Console.WriteLine("80ndad tahavad vanureid tagasi, toimub boomerite recall");
            }
            //kui järjend on tühi, siis programm läheb edasi ->
            //küsi kasutajalt kas talle ei meeldi mängud, ning lase tal vastata sõnaga jah või ei, kontrolli kasutaja sisestust ToUpper() või .ToLower()iga
            if (!mängud.Any())
            {
                Console.WriteLine("Kas sulle ei meeldi mängud? vasta kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("jah"))
                {
                    //kui ta vastab jah, siis ütle, "aga miks siis ei sisestanud?"
                    Console.WriteLine("aga miks sa ei sisestanud?");
                }
                else if (jahvõiei.Contains("ei"))
                {
                    //kui talle ei meeldi, siis ütle, kahju
                    Console.WriteLine("kahju :(");
                }
                else
                {
                    //kui vastus on midagi muud, siis ütle "ei saa aru :/".
                    Console.WriteLine("Ei saa aru :/");
                }
            }
            //kui talle ei meeldi, siis ütle, kahju
            //kui ta vastab jah, siis ütle, "aga miks siis ei sisestanud?"
            //kui vastus on midagi muud, siis ütle "ei saa aru :/".
        }
    }
}
