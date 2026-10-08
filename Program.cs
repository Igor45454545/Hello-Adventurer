Console.WriteLine("Hello Adventurer");

Console.Write("\nJak masz na imię? ");
string imie = Console.ReadLine();
Console.Write("Jaki znacznik? ");
char znacznik = char.Parse(Console.ReadLine());
Console.Write("Twoja siła: ");
int sila = int.Parse(Console.ReadLine());
Console.Write("Twoje punkty życie: ");
int zycie = int.Parse(Console.ReadLine());
Console.Write("Twoje złoto: ");
int zloto = int.Parse(Console.ReadLine());
Console.Write("Twoje jedzenie: ");
int jedzenie = int.Parse(Console.ReadLine());
Console.Write("Twoje punkty doświadczenia: ");
double doswiadczenie = double.Parse(Console.ReadLine());
Console.Write("Ile dni trwa wyprawa: ");
int dniWyprawy = int.Parse(Console.ReadLine());
Console.Write("Ile dni wyprawy zostało: ");
int dniWyprawyPozostale = int.Parse(Console.ReadLine());

Console.Write("Za odpowedzi podwoiło ci się złoto \n");
zloto*= 2;

const int zycieMaksymalne = 200;
bool zyje = zycie>0;
bool mozeLeczyc = zycie < zycieMaksymalne && zycie > 0;
bool zapasJedzenia = jedzenie > dniWyprawyPozostale + 1;
double procentZycia = (double)(100*zycie)/zycieMaksymalne;
int brakujaceZycie = zycieMaksymalne - zycie;
int pozostaleJedzeniaNaWyprawe = jedzenie/dniWyprawyPozostale;
int resztaJedzeniaPoWyprawie = jedzenie%dniWyprawyPozostale;
int lacznaDlugoscWyprawy = dniWyprawy + dniWyprawyPozostale;

Console.WriteLine($"┌─[{znacznik} {imie} / POZIOM {Math.Floor(doswiadczenie/10)} ]───────────┐");
Console.WriteLine($"│\t\t\t\t │");
Console.WriteLine($"├ Zdrowie: {zycie}/{zycieMaksymalne} ({procentZycia:F2}%)\t │");
Console.WriteLine($"├ Siła: {sila}\t\t\t │");
Console.WriteLine($"├ Złoto: {zloto}\t\t\t │");
Console.WriteLine($"├ Jedzenie: {jedzenie}\t\t\t │");
Console.WriteLine($"│\t\t\t\t │");
Console.WriteLine($"├────────────────────────────────┤");
Console.WriteLine($"│\t\t\t\t │");
Console.WriteLine($"├ Czy żyje: {zyje} \t\t │");
Console.WriteLine($"├ Może się uleczyć: {mozeLeczyc} \t │");
Console.WriteLine($"├ Ma zapas jedzenia: {zapasJedzenia} \t │");
Console.WriteLine($"├ Otrzymane obrażenia: {brakujaceZycie} \t │");
Console.WriteLine($"├ Posiłki na dzień wyprawy: {pozostaleJedzeniaNaWyprawe} \t │");
Console.WriteLine($"├ Jedzenia po wyprawie: {resztaJedzeniaPoWyprawie} \t │");
Console.WriteLine($"├ Łączna długość wyprawy: {lacznaDlugoscWyprawy} \t │");
Console.WriteLine($"│\t\t\t\t │");
Console.WriteLine($"└────────────────────────────────┘");
dniWyprawy++;

// \n│ HP: {zycieAktualne}     SIŁA: {sila}          │\n│ ZŁOTO: {zloto}  PUNKTY: {punktyDoswiadczenia}          │\n├───────────────────────────────┤\n│ Utraciłeś {zycieMaksymalne - zycieAktualne} HP               │\n└───────────────────────────────┘");