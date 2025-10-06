
/*
//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?");
string nimi = Console.ReadLine();

if (nimi == "")
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

if (tehtetüüp == "+")
{
    tehe = arv1 + arv2;
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


if (tehtetüüp == "-")
{
    tehe = arv1 - arv2;
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


if (tehtetüüp == "*")
{
    tehe = arv1 * arv2;
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


if (tehtetüüp == "/")
{
    tehe = arv1 / arv2;
}

if (tehtetüüp == "^")
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
/*
/* ISESEISEV ÜLESANNE */

Console.WriteLine("Kas sa tahad ära mõõta pappkasti või õlitünni?");
string valik = Console.ReadLine();
if (valik == "tünn")
{

    Console.WriteLine("Kas sa tead tünni raadiust(r) või põhja läbimõõtu(d)");
    string rvõid = Console.ReadLine();
    Console.WriteLine("Sisesta see mõõt");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r)") ;
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }

    Console.WriteLine("Kui kõrge on sinu tünn");
    int kõrgus = int.Parse(Console.ReadLine());
    Console.WriteLine("Kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());
    double tünnipõhiS = Math.PI * (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on {kogupindala}");
}

else if (valik == ("kast")
{
    Console.WriteLine("Kas kast on kuubiku kujuline (k või risttahuka (r) kujuline?");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        Console.WriteLine("Sisesta kasti küljepikkus:");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");
    }

else if (kastitüüp == "r")
{
    Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
    double pikkKülg = double.Parse(Console.ReadLine());
    Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
    double lühikeKülg = double.Parse(Console.ReadLine());
    Console.WriteLine("Mis on sinu kasti kõrgus?:");
    double kõrgus = double.Parse(Console.ReadLine());
    double V = pikkKülg * lühikeKülg * kõrgus;
    double kogupindala = 2 * ((pikkKülg * lühikeKülg) + (lühikeKülg * kõrgus) + (pikkKülg * kõrgus));
    double diagonaal = Math.Sqrt((pikkKülg * pikkKülg) + (lühikeKülg * lühikeKülg) + (kõrgus * kõrgus));
    Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on {diagonaal}");
    }


 }

Console.WriteLine("Eshkere");
// Console -> adresseritav moodul või objekt (Roheline)
// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
// WriteLine -> adresseritav funktsioon objektist Console
// () -> sulupaar mis omab endas funktsioonile vajalikku infot
//    -> saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõnu "ifi parameeter"
//    -> kasutatakse ka matemaatuilistes tehtedes
// [] -> tähistab massiive
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust
//    -> saab ka kasutada teksti sees muutujate kuvamiseks
// -> taane aitab arendajal aru saada millise koodploki sees, miski on. Vajalik ka kompilaatorile.
// "eshkere" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
// ; -> iga koodilause lõppeb komakolooniga

int muutuja = 3;
// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
// 3 -> väärtus mis sellele muutujale omistatakse

// võimalikud andmetüübid:
int a = 1; // täisarv
decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
char c1 = 'a'; // üksainus täht või tähemärk
string s = "tekst"; // inimloetaval kujul tekst
var x = "abc";// ebamäärase tüübiga kohalik muutuja.
var y = 123;
const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only

//põhilised matemaatilised tehted
int liitmine = 1 + 1; // liitmine, kaks arvu kokku
int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
int korrutamine = 1 * 1; // korrutamine, esimene arv korrutatakse teisega
int jagamine = 1 / 1; // jagamine, esimene arv jagatakse teisega
double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
double juurimine = Math.Sqrt(2); // ruutjuur, parameetriks arv mida juuritakse

int arv = 0; //sobib
string sõna = "abc"; //sobib
//string string = "abc"

//muutuja nimeks ei sobi järgnevad sõnad:
//abstract, as, base, bool, break, byte, case,
//catch, char, checked, class, const, continue, decimal,
//default, delegate, do, double, else, enum, event,
//explicit, extern, false, finally, fixed, float, for
//forrach, goto, if, implicit, in , int,
//interface, internal, is, lock, long, namespace, new,
//null, object, operator, out, override, params,
//private, protected, public, readonly, ref, return, sbyte,
//sealed, short, sizeof, stackalloc, static, string, struct,
//swtich, this, throw, true, try, typeof, uint,
//ulong, unchecked, unsase, unshort, using, virtual, void,
//volatile, while.

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
int liidetav1 = 0;
// liidetava1 nime ees olev andmetüübi kirjeldus. iga koodilause lõppeb komakolooniga
int liidetav2 = 0;
// liidetava2 nime ees olev andmetüübi kirjeldus.iga koodilause lõppeb komakolooniga
Console.WriteLine("Tere, palun sisesta esimene liidetav");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
liidetav1 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
Console.WriteLine("Tere, palun sisesta teine liidetav: ");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
liidetav2 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
//int liitmine = liidetav1 + liidetav2;
// liitmine, kaks arvu kokku. iga koodilause lõppeb komakolooniga
Console.WriteLine($"Tehte tulemus: {liitmine}");
// adresseritav modul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//Сonsole.WriteLine("Tehte tulemus: "+liitmine);
// adresseritav modul ja funktsioon objektsist Console. iga koodilause lõppeb komakolooniga

int lahutatav3 = 0;
// lahutava3 nime ees olev andmetüübi kirjeldus. iga koodilause lõppeb komakolooniga
int lahutatav4 = 0;
// lautava4 nime ees olev andmetüübi kirjeldus. iga koodilause lõppeb komakolooniga
Console.WriteLine("Tere, palun sisesta esimene liidetav");
//adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
lahutatav3 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
Console.WriteLine("Tere, palun sisesta teine liidetav: ");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
lahutatav4 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
//int lahutamine = lahutatav3 - lahutatav4;
// lahutamine, esimene arv maha teisest. iga koodilause lõppeb komakolooniga
Console.WriteLine($"Tehte tulemus: {lahutamine}");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
Console.WriteLine("Tehte tulemus: " + lahutamine);
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga


int arv1 = 0;
// täisarv. iga koodilause lõppeb komakolooniga ; .
int arv2 = 0;
// täisarv. iga koodilause lõppeb komakolooniga ; .
Console.WriteLine("Tere, palun sisesta esimene arv: ");
// adresseritav moodul ja funktsioon objektist Console, punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel. iga koodilause lõppeb komakolooniga ; .
arv1 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. Instantsieerime muutja "arv1", ning ütleme et sinna peab panna täisarve andmetüübigasõnaga int, selle muutuja sissse omistame tulemse
// mille saame kasutajalt Console.ReadLine() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. iga koodilause lõppeb komakolooniga ; .
Console.WriteLine("Tere, palun sisesta teine arv: ");
// adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel. iga koodilause lõppeb komakolooniga ; .
arv2 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. Instantsieerime muutja "arv1", ning ütleme et sinna peab panna täisarve andmetüübigasõnaga int, selle muutuja sissse omistame tulemse
// mille saame kasutajalt Console.ReadLine() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. iga koodilause lõppeb komakolooniga ; .
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^");
// adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel. iga koodilause lõppeb komakolooniga ; .
string tehtetüüp = Console.ReadLine();
// inimloetaval kujul tekst. iga koodilause lõppeb komakolooniga ; .
int tehe = 0;
// täisarv. Instantseerime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0. iga koodilause lõppeb komakolooniga ; .

if (tehtetüüp == "+")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku

    tehe = arv1 + arv2;

    // muutuja arv1 ja muutuja arv2. iga koodilause lõppeb komakolooniga ; .
} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
  
Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga ; .


if (tehtetüüp == "-")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
{// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutamises kokku

    tehe = arv1 - arv2;
    // muutuja arv1 ja muutuja arv2 sisu omavahel kokku. iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutamises kokku

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga ; .


if (tehtetüüp == "*")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
{
    // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutamises kokku
    tehe = arv1 * arv2;
    // muutuja arv1 ja muutuja arv2 sisu omavahel kokku. iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutamises kokku

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// adresseritav moodul ja funktsioon obektist Console. iga koodilause lõppeb komakolooniga ; .


if (tehtetüüp == "/")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
{
    // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagamises kokku
    tehe = arv1 / arv2;
    // muutuja arv1 muutujaga arv2. iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagamises kokku

if (tehtetüüp == "^")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
{
    // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
    // moodulist "Math" punkti abil funktsiooni "Pow()"; selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
    tehe = (int)Math.Pow(arv1, arv2);
    // Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// Adresseerime moodulit "Console", ning kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus. Iga koodilause lõppeb komakolooniga ; .