Console.WriteLine("Hello Adventurer");

Console.Write("\nJak masz na imię? ");
string imie = Console.ReadLine();

int zycieMaksymalne = 200;
int zycieAktualne = 170;
int sila = 25;
int zloto = 4;
decimal punktyDoswiadczenia = 34;

Console.Write($"┌─[ {imie} / POZIOM {Math.Floor(punktyDoswiadczenia/10)} ]───────────┐\n│ HP: {zycieAktualne}     SIŁA: {sila}          │\n│ ZŁOTO: {zloto}  PUNKTY: {punktyDoswiadczenia}          │\n├───────────────────────────────┤\n│ Utraciłeś {zycieMaksymalne - zycieAktualne} HP               │\n└───────────────────────────────┘");