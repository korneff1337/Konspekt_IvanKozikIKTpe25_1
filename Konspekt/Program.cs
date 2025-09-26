

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?");
string nimi = Console.ReadLine();

if (nimi== "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 🙁");
}
else if (nimi != "")
{
    Console.WriteLine("Tere "+nimi+"! happyface ^o^");
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2 - vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus?:");
int kasutajavanus = int.Parse(Console.ReadLine());

////2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma O.O ");
//    }
//}
//else
//{
//    Console.WriteLine("Yippie! saad monsut osta ^_^");
//}
//2.2 mitu tingimust kasutades loogilist tehet "and"
if (kasutajavanus > 0 && kasutajavanus < 18)
{
    Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma U_U");
}
else
{
    Console.WriteLine("Yippie! saad monsut osta ;D");
}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());


if (kasutajavanus  < 1.00d)
{
    Console.WriteLine("Oled Juntsu");
}
else if (kasutajaPikkus < 1.25 && kasutajaPikkus >= 1.00)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
if (kasutajavanus < 1.50d && kasutajaPikkus >= 1.25d)
{
    Console.WriteLine("Nüüd ei ole nii väike, "+nimi);
}
else if (kasutajaPikkus < 1.75 && kasutajaPikkus >= 1.5d)
{
    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
}
else if (kasutajavanus < 2.00d && kasutajaPikkus >= 1.75)
{
    Console.WriteLine(nimi+", oled kipp kolge, vaata et sa pead vastu uksepiita ära ei löö ^.^'");
}
else
{
    Console.WriteLine("Täelik tulnukas! Kuidas pilved välja näevad lähedalt?");
}

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
int liidetav1 = 0;
int liidetav2 = 0;
Console.WriteLine("Tere, palun sisesta esimene liidetav");
liidetav1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta teine liidetav: ");
liidetav2 = int.Parse(Console.ReadLine());
int liitmine = liidetav1 + liidetav2;
Console.WriteLine($"Tehte tulemus: {liitmine}");
//Сonsole.WriteLine("Tehte tulemus: "+liitmine);

int lahutatav3 = 0;
int lahutatav4 = 0;
Console.WriteLine("Tere, palun sisesta esimene liidetav");
lahutatav3 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta teine liidetav: ");
lahutatav4 = int.Parse(Console.ReadLine());
int lahutamine = lahutatav3 - lahutatav4;
Console.WriteLine($"Tehte tulemus: {lahutamine}");
Console.WriteLine("Tehte tulemus: " + lahutamine);


int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+"  /*tingimus siia*/)
{
    tehe = arv1 + arv2;
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


if (tehtetüüp == "-" /*tingimus siia*/)
{
    tehe = arv1 - arv2;
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


if (tehtetüüp == "*" /*tingimus siia*/)
{
    tehe = arv1 * arv2;
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


if (tehtetüüp == "/"  /*tingimus siia*/)
{
    tehe = arv1 / arv2;
}

if (tehtetüüp == "^" /* tingimus siia */)
{
    tehe = (int)Math.Pow(arv1, arv2);
}
 Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");

//4 parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("YES, parool on õige, oled sisse lubatud");
}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5 värvituvastus: punane oranž kollane roheline
// helesinine tumesinine lilla roosa pruun must ja valge
Console.WriteLine("Mis on sinu lemmikvärv");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "helesinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "oranž")
{
    Console.WriteLine("Seda värvi pole, don't give up!");
}
else if (favColour == "roosa")
{
    Console.WriteLine("Seda värvi pole, don't give up!");
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "pruun")
{
    Console.WriteLine("Seda värvi pole, don't give up!");
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favColour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favColour == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favColour == "lilla")
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
}
else
{
    Console.WriteLine("ei tea seda värvi!");
}
    Console.WriteLine("The colour has maybe changed!!!!!");

/* ISESEISEV ÜLESANNE */

Console.WriteLine("Kas sa tahad ära mõõta pappkasti või õlitünni?");
string valik = Console.ReadLine();
if (valik == "pappkast")
{

    Console.WriteLine("Kas kast on kuubiku kujuline või risttahuka kujuline?");
    int r =
        int.Parse(Console.ReadLine());

}
else if (valik == "õlitünni")
{

    Console.WriteLine("Kas sa tead põhja raadiust (r) või põhja läbimõõtu (d)");
    int r =
        int.Parse(Console.ReadLine());


}

