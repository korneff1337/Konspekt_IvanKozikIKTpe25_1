
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

//Console.WriteLine("Kas sa tahad ära mõõta pappkasti või õlitünni?");
//string valik = Console.ReadLine();
//if (valik == "tünn")
//{

//    Console.WriteLine("Kas sa tead tünni raadiust(r) või põhja läbimõõtu(d)");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("Sisesta see mõõt");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if (rvõid != "r)") ;
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }

//    Console.WriteLine("Kui kõrge on sinu tünn");
//    int kõrgus = int.Parse(Console.ReadLine());
//    Console.WriteLine("Kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());
//    double tünnipõhiS = Math.PI * (mõõt * mõõt);
//    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on {kogupindala}");
//}

//else if (valik == "kast")
//{
//    Console.WriteLine("Kas kast on kuubiku kujuline (k või risttahuka (r) kujuline?");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        Console.WriteLine("Sisesta kasti küljepikkus:");
//        double külgA = double.Parse(Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");
//    }

//else if (kastitüüp == "r")
//{
//    Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
//    double pikkKülg = double.Parse(Console.ReadLine());
//    Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
//    double lühikeKülg = double.Parse(Console.ReadLine());
//    Console.WriteLine("Mis on sinu kasti kõrgus?:");
//    double kõrgus = double.Parse(Console.ReadLine());
//    double V = pikkKülg * lühikeKülg * kõrgus;
//    double kogupindala = 2 * ((pikkKülg * lühikeKülg) + (lühikeKülg * kõrgus) + (pikkKülg * kõrgus));
//    double diagonaal = Math.Sqrt((pikkKülg * pikkKülg) + (lühikeKülg * lühikeKülg) + (kõrgus * kõrgus));
//    Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on {diagonaal}");
//    }


// }

//Console.WriteLine("Eshkere");
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

//int muutuja = 3;
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

// võimalikud komposiitandmetüübid:
// 1. massiiv:
// [] -> Massiiv on komposiitandmetüüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega
//       Massiiv saab olla ükskõik millist lihtandmetüüpi massiive.
//       Massiivi tekitamisel tuleb ära öelda kui pikk või suur see massiiv on
//       Massiiv saab olla koostatud ka teistest massiividest.
//
// Esimene tekitusviis:
int[] arvuMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et tegu ühtlasi
                                // ka massiiviga. nimeks on "arvuMassiiv" ja võrdusmärgiga, on esimene tekitusmoodus öelda et tegu on
                                // uue massiiviga kasutades kaitstud sõna "new", ja sellele järgneb massiivi pikkuse sätestus "int[3]"
                                // see tähendab et siin ´massiivis on 3 elementi, mis on täisarvud.
int[] arvuMassiiv2 = [1, 2, 3]; // teine massiivi tekitusviis, kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe sisse
                                // järjendi pikkus tuletatakse elementide arvust
                                // -- massiivi sisemised meetodid:
int hasthismany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku, mitu
                                      // elementi järjendis parasjagu on.


//põhilised matemaatilised tehted
//int liitmine = 1 + 1; // liitmine, kaks arvu kokku
//int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
//int korrutamine = 1 * 1; // korrutamine, esimene arv korrutatakse teisega
//int jagamine = 1 / 1; // jagamine, esimene arv jagatakse teisega
//double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
//double juurimine = Math.Sqrt(2); // ruutjuur, parameetriks arv mida juuritakse

//int arv = 0; //sobib
//string sõna = "abc"; //sobib
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
//int liidetav1 = 0;
// liidetava1 nime ees olev andmetüübi kirjeldus. iga koodilause lõppeb komakolooniga
//int liidetav2 = 0;
// liidetava2 nime ees olev andmetüübi kirjeldus.iga koodilause lõppeb komakolooniga
//Console.WriteLine("Tere, palun sisesta esimene liidetav");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//liidetav1 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
//Console.WriteLine("Tere, palun sisesta teine liidetav: ");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//liidetav2 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
//int liitmine = liidetav1 + liidetav2;
// liitmine, kaks arvu kokku. iga koodilause lõppeb komakolooniga
//Console.WriteLine($"Tehte tulemus: {liitmine}");
// adresseritav modul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//Сonsole.WriteLine("Tehte tulemus: "+liitmine);
// adresseritav modul ja funktsioon objektsist Console. iga koodilause lõppeb komakolooniga

//int lahutatav3 = 0;
// lahutava3 nime ees olev andmetüübi kirjeldus. iga koodilause lõppeb komakolooniga
//int lahutatav4 = 0;
// lautava4 nime ees olev andmetüübi kirjeldus. iga koodilause lõppeb komakolooniga
//Console.WriteLine("Tere, palun sisesta esimene liidetav");
//adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//lahutatav3 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
//Console.WriteLine("Tere, palun sisesta teine liidetav: ");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//lahutatav4 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. iga koodilause lõppeb komakolooniga
//int lahutamine = lahutatav3 - lahutatav4;
// lahutamine, esimene arv maha teisest. iga koodilause lõppeb komakolooniga
//Console.WriteLine($"Tehte tulemus: {lahutamine}");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga
//Console.WriteLine("Tehte tulemus: " + lahutamine);
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga


//int arv1 = 0;
// täisarv. iga koodilause lõppeb komakolooniga ; .
//int arv2 = 0;
// täisarv. iga koodilause lõppeb komakolooniga ; .
//Console.WriteLine("Tere, palun sisesta esimene arv: ");
// adresseritav moodul ja funktsioon objektist Console, punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel. iga koodilause lõppeb komakolooniga ; .
//arv1 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. Instantsieerime muutja "arv1", ning ütleme et sinna peab panna täisarve andmetüübigasõnaga int, selle muutuja sissse omistame tulemse
// mille saame kasutajalt Console.ReadLine() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. iga koodilause lõppeb komakolooniga ; .
//Console.WriteLine("Tere, palun sisesta teine arv: ");
// adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel. iga koodilause lõppeb komakolooniga ; .
//arv2 = int.Parse(Console.ReadLine());
// Sisestab ülevalt moodule ja funktsioonile teatud nimetust. Instantsieerime muutja "arv1", ning ütleme et sinna peab panna täisarve andmetüübigasõnaga int, selle muutuja sissse omistame tulemse
// mille saame kasutajalt Console.ReadLine() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
// asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. iga koodilause lõppeb komakolooniga ; .
//Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^");
// adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel. iga koodilause lõppeb komakolooniga ; .
//string tehtetüüp = Console.ReadLine();
// inimloetaval kujul tekst. iga koodilause lõppeb komakolooniga ; .
//int tehe = 0;
// täisarv. Instantseerime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0. iga koodilause lõppeb komakolooniga ; .

//if (tehtetüüp == "+")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku

    //tehe = arv1 + arv2;

    // muutuja arv1 ja muutuja arv2. iga koodilause lõppeb komakolooniga ; .
} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
  
//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga ; .


//if (tehtetüüp == "-")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
{// peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutamises kokku

    //tehe = arv1 - arv2;
    // muutuja arv1 ja muutuja arv2 sisu omavahel kokku. iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutamises kokku

//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// adresseritav moodul ja funktsioon objektist Console. iga koodilause lõppeb komakolooniga ; .


//if (tehtetüüp == "*")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
{
    // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutamises kokku
    //tehe = arv1 * arv2;
    // muutuja arv1 ja muutuja arv2 sisu omavahel kokku. iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutamises kokku

//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// adresseritav moodul ja funktsioon obektist Console. iga koodilause lõppeb komakolooniga ; .


//if (tehtetüüp == "/")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
{
    // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagamises kokku
    //tehe = arv1 / arv2;
    // muutuja arv1 muutujaga arv2. iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagamises kokku

//if (tehtetüüp == "^")
// teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
{
    // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
    // moodulist "Math" punkti abil funktsiooni "Pow()"; selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
    //tehe = (int)Math.Pow(arv1, arv2);
    // Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Iga koodilause lõppeb komakolooniga ; .
}   // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
// Adresseerime moodulit "Console", ning kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus. Iga koodilause lõppeb komakolooniga ; .

Console.WriteLine("Sisesta ostusumma");
// adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
// mis asub funktsiooni taga olevate sulgude vahel.
double ostusumma = double.Parse(Console.ReadLine());
// kümnendsüsteemis olev komakohaga arv.
if (ostusumma > 100)
// Instantsieerimine muutuja "ostusumma", ning ütleme et peab sinna panna kümnendsüsteemis olevate andmega
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
    Console.WriteLine("Saad 20% allahindlust");
} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
else if (ostusumma > 101 &&ostusumma > 50)
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
    Console.WriteLine("Saad 10% allahindlust");
    // adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    // mis asub funktsiooni taga olevate sulgude vahel.

} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
else if (ostusumma < 51 &&ostusumma > 20)
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
    Console.WriteLine("Saab 5& allahindlust");
    // adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    // mis asub funktsiooni taga olevate sulgude vahel.

} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
else if (ostusumma < 21)
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
    Console.WriteLine("Allahindlust ei saa :(");
    // adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    // mis asub funktsiooni taga olevate sulgude vahel.

} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
else if (ostusumma < 1)
{ // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
    Console.WriteLine("Sisestatud vigane arv");
    // adresseritav moodul ja funktsioon objektist Console. punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
    // mis asub funktsiooni taga olevate sulgude vahel.

} // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisesldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku

//string kasutajaNimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi");
//    kasutajaNimi = Console.ReadLine();
//}
//while (kasutajaNimi != "user1");
//if (kasutajaNimi == "user1")
//{
//    int ruuduSuurus = 0;

//    Console.WriteLine("Kui suurt ruutu tahad?");

//    do
//    {
//        Console.WriteLine("Kui suurt ruutu tahad?");
//        ruuduSuurus = int.Parse(Console.ReadLine());
//    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
//    char reaKujund = '█';
//    string üksRida = "";
//    int tsükliMuutuja = ruuduSuurus;
//    do
//    {
//        üksRida += "_" + reaKujund;
//        tsükliMuutuja -= 1;
//    } while (tsükliMuutuja != 0);
//    tsükliMuutuja = ruuduSuurus;
//    do
//    {
//        Console.WriteLine(üksRida);
//        tsükliMuutuja -= 1;

//    } while (tsükliMuutuja != 0);
//    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
//}

/* tingimuslause osad */
if (true) { } //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb
              //koodiplok tingimuse täitumisel teostatava koodiga
else if (true) { } //kaitstud sõnad else ja if (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                   //on samamoodi sulgude ahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
                   //ja eelneva tingimuse mittetäitumisel teostaakse koodiploki sees olev koode
else { } //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodiploki sisu
         //täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.

/* Loogilised tehted */
//&& -> "and" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
//      mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
// || -> "or" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui
//      vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
// !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
//       puhul tagastab false, ja vastupidi - tulemus mis muidu tagastaks false, hüüumärgi puhul tagastab true.

/* Võrdlusoperaatorid */
// == -> on võrdne. Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt mõrdusmärgi teisel pool oleva
// objektiga. ei ole sama nagu üks võrdusmärk.  üks võrdusmärk omistb, kaks võrdleb.
// != -> ei ole võrdne. Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
//       Võrdlus operaator on kombinatsioon "on võrdne" operaatorist, ja loogilisest tehtest "not".
// >  -> on suurem kui. Märgist vasakul pool olev objektpeaks olema suurem kui paremal pool olev objekt.
// <  -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
// >= -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
//       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
// <= -> on väiksem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
//       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

/* Omistusoperaatorid ja kiirtehted */
int arv = 1;// =  -> üksik võrdusmärk omistab muutujale väärtuse.
arv += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
            //       asendab tehet "arv = arv + 1" on kombinatsiooon matemaatilisest tehtest "+" ja omistamisest ("=")
arv -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutuja maha võrdusmärgi teisel pool oleva väärtuse.
            //       asendab tehet "arv = arv - 1" on kombinatsioon matemaatilisest tehtest "-" ja omistamisest ("=")
arv *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu ja võrdusmärgi teisel pool oleva
            //       arvu kordi. asendab tehet "arv = arv * 2". on kombinatsioon matemaatilisest tehtest "*" ja omistamisest
            //       ("=")
arv /= 2;   // *= -> võrdusmärk mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
            //       arvu osadeks. asendab tehet "arv = arv / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest
            //       ("=")
arv++;     // ++ -> on spetsiifiliselt ühe juurde liitmiseks lühivariant.
arv--;      // -- -> on spetsiifiliselt ühe maha lahutamiseks lühivariant.

/* Tsüklid */
// 1. do-while
do // "do" on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi
{

} while (true); //niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud.

// 2. while
int i = 1; //tsüklimuutuja mis kontrollib "while" tsükli tööd
while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab tihtipeale välist tsüklimuutujat
              //antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, sulgude vahel, kontrollibki tingimuse abil, selle
              //muutuja olekut. Siin kontrollitakse, et tsükkel ei oleks suurem kui 5, kui ta on, siis tsükli töö lõppeb.
{
    //koodiplokk kus midagi tehakse
    i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud juhul liidetakse 1 juurde
}

// 3. for
int kogus = 6; // muutuja mida tsükkel kasutab töötlemiseks mingisugusel kujul
for (int k = 0; k < kogus; k++) // kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö jaoks
                                // vajalik info. esimene parameeter tekitab tsükli töö jaoks muutuja "int k = 0;", teine parameeter on
                                // tingimuslause mis kontrollib tingimuse täitumist "k < kogus;" ning kolmas inkrementeerib tekitatud
                                // muutujat "k++;". pane tähele et iga sulgude vahel oleva osa järel on lauselõpumärk. Tsükli tööd
                                // kontrolliv tingimuslause koosneb kolmest reast, mitte ühest, nagu while, või do-while puhul.
                                // koodiplokk kus tehakse mingi tegevus
{
    Console.WriteLine(k);       // antud juhul on tegevuseks muutuja "k" arvu väljakuvamine
}
// 4. foreach
int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
foreach (var arvInLoend in arvuLoend) // kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                      // ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                      // kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend
                                      // muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat
                                      // tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib
                                      // iga üksiku elemendi kohta andmekogumis. Tsüklil ei ole vaja tsüklimuutujat, kuna talle on
                                      // sisse ehitatud vaikimisi elemndi järjestuse jälgimine. Niipalju kui andmeid on, ongi see,
                                      // mitu korda tsükkel käivitatakse.
{                                     // {} koodiplokk kus tehakse mingi tegevus
    Console.WriteLine(arvInLoend);    // antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi element. 
}
    }
    /* meetodid */

    // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
    // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
    // Meetodeid on kahte liiki - ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta
    // midagi, kuid omavad siiski mingit tegevust.

    // Meetodi signatuur:
    // Meetodi signatuur koosneb mitmest kindalt äramääratud omadusest, nendeks on:
    // - Juurdepääsu modifikaator mis ütleb ära, kust ja kuidas sellele meetodile juurde pääseda saab
    //   public - meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub.
    //   private - meetod on saadav ainult selles klassis, kus meetod ise asub.
    //   protected - meetod on saadav ainult selles klassis, kus meetod ise asub ja kõikides klassides millen on pärilus
    //               sellele klassile.
    //   internal - meetod on saadav ainult selles klassis ja ainult selles failis.
    // - Võib olla ka pandud static - meetod kuulub selle klassi juurde
    // - Tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta.
    //   Andmetüüp mida tagastada võib olla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta
    //   üldse andmeid, pannakse selle asemel andmetüübiks "void". Kui meetodil on tagastustüüp mis on midagi muud kui
    //   void, on meetodi sees, iga toimiva koodisuuna lõpus, kaitstud sõna "return", return ütleb, et just see, on vaja
    //   väljakutseasukohta tagastada, ning peale returni on muutuja nimi tagastatava infoga. Peale return lauset, ei
    //   teostata mitte ühtegi muud meetodi sisu. Return toimib ka kui breakina, lõpetades siis aktiivse meetodi töö.

    // 1. tüüpi meetod - ei tagasta midagi
    public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb et
                                   //ta on selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei tagasta
                                   //ning pärast meetodi omadusi on meetodi nimi "UusMeetod" peale mida on sulud, kus
                                   //parameetreid ei ole. 
{                              //pärast signatuuri on koodiplokk meetodi koodiga {}
    Console.WriteLine("Tere"); //Antud juhul meetod kuvab konsooli sõnumi.
}
// 2. tüüpi meetod - tagastab väärtuse
int[] arvutatavadArvud = new int[] { 3, 67, 420 }; //Töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega
                                                   //"arvutatavadArvud.
public static int ArvutaKokku(int[] arvud) //Meetod, mille signatuuris on juurdepääsumodifikaator public, static
                                           //ütleb et meetod kuulub siia klassi, tagastustüüp "int" ütleb, et
                                           //programmis väljakutseasukohta tagastatakse täisarv, peale seda on
                                           //meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod täisarvumassiivi
                                           //millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on
                                           //koodiplokk {} tehtava koodiga.
{
    int summa = 0; //Tekitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 0.
    foreach (int i in arvud) //foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi
    {
        summa += i; //ja muutujale summa lisatakse juurde, hetkel käidav element.
    }
    return summa; //pärast tsükli töö lõppu tagastakse "return" käsu abil, muutuja summa sisu.
}
    
}