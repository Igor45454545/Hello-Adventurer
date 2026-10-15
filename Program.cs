const int ZycieMaksymalne = 200;

Console.WriteLine("Hello Adventurer");

Console.Write("\nJak masz na imię? ");
string imie = Console.ReadLine()!;
Console.Write("Jaki znacznik? ");
char znacznik = char.Parse(Console.ReadLine()!);
Console.Write("Twoja siła: ");
int sila = int.Parse(Console.ReadLine()!);
Console.Write("Twoje punkty życia: ");
int zycie = int.Parse(Console.ReadLine()!);
Console.Write("Twoje złoto: ");
int zloto = int.Parse(Console.ReadLine()!);
Console.Write("Twoje jedzenie: ");
int jedzenie = int.Parse(Console.ReadLine()!);
Console.Write("Twoje punkty doświadczenia: ");
double doswiadczenie = double.Parse(Console.ReadLine()!);
int poziom = (int)Math.Floor(doswiadczenie/10);

bool ranny = zycie < ZycieMaksymalne && zycie > 0;
double procentZycia = (double)(100*zycie)/ZycieMaksymalne;
int otrzymaneObrazenia = ZycieMaksymalne - zycie;
string stan = zycie > 0 ? "żyje" : "nie żyje";

Console.Clear();

if (zycie >= (ZycieMaksymalne/2)){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Bohater jest w dobrej formie. \n");
}
else if (zycie < (ZycieMaksymalne/2) && zycie != 0){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Bohater jest ranny. \n");
}
else if (zycie == 0){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Bohater nie żyje. \n");
}
Console.ResetColor();

Console.WriteLine("1. Pokaż kartę bohatera");
Console.WriteLine("2. Wymień złoto na poziom");
Console.WriteLine("3. Ulecz się");

Console.WriteLine("Wybierz akcję: ");
int akcja = int.Parse(Console.ReadLine()!);
Console.Clear();
switch(akcja)
{
    case 1:
        // Console.WriteLine($"┌─[{znacznik} {imie} / POZIOM {poziom} ]───────────┐");
        Console.Write($"┌─[");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"{znacznik} {imie} / POZIOM {poziom} ");
        Console.ResetColor();
        Console.Write($"]───────────┐\n");
        Console.WriteLine($"│\t\t\t\t │");
        Console.WriteLine($"├ Stan: {stan}\t\t\t │");
        // Console.WriteLine($"├ Zdrowie: {zycie}/{ZycieMaksymalne} ({procentZycia:F2}%)\t │");
        Console.Write($"├ Zdrowie: ");
        if (zycie < ZycieMaksymalne / 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        } else if (zycie > ZycieMaksymalne / 2 && zycie < ZycieMaksymalne*0.75)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Green; 
        }
        Console.Write($"{zycie}");
        Console.ResetColor();
        Console.Write($"/{ZycieMaksymalne} ({procentZycia:F2}%)\t │\n");
        Console.WriteLine($"├ Siła: {sila}\t\t\t │");
        Console.WriteLine($"├ Złoto: {zloto}\t\t\t │");
        Console.WriteLine($"├ Jedzenie: {jedzenie}\t\t\t │");
        Console.WriteLine($"│\t\t\t\t │");
        Console.WriteLine($"├────────────────────────────────┤");
        Console.WriteLine($"│\t\t\t\t │");
        // Console.WriteLine($"├ Otrzymane obrażenia: {otrzymaneObrazenia} \t │");
        Console.Write($"├ Otrzymane obrażenia: ");
        if (otrzymaneObrazenia > ZycieMaksymalne / 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        } else if (otrzymaneObrazenia > ZycieMaksymalne / 4)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Green; 
        }
        Console.Write($"{otrzymaneObrazenia}");
        Console.ResetColor();
        Console.Write($" \t │\n");
        
        Console.WriteLine($"│\t\t\t\t │");
        Console.WriteLine($"└────────────────────────────────┘");
        break;
    case 2:
        if(zloto > 0)
        {
            Console.WriteLine("1 poziom kosztuje 10 złota");
            Console.WriteLine($"Stać cię na {zloto/10} poziomów");
            Console.WriteLine("Ile poziomów chciałbyś kupić?");
            int poziomyKupione = int.Parse(Console.ReadLine()!);
            if(poziomyKupione <= zloto/10)
            {
                zloto-=poziomyKupione*10;
                poziom+= poziomyKupione;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Udało ci się kupić {poziomyKupione} poziomy za {poziomyKupione*10} złota");
                Console.ResetColor();
                Console.WriteLine($"Twój atkualny poziom to {poziom}, zostało ci {zloto} złota.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz wystarczająco złota aby zakupić tyle poziomów");
                Console.ResetColor();
            }
        } 
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie masz wystarczająco złota");
            Console.ResetColor();
        }
        break;
    case 3:
        if (jedzenie >= 1){
            if (ranny){
                Console.ForegroundColor = ConsoleColor.Green;
                jedzenie--;
                if (zycie + 50 > ZycieMaksymalne) {zycie = ZycieMaksymalne;}
                else { zycie += 50; }
                Console.WriteLine("Bohater został uleczony");
                procentZycia = (double)(100*zycie)/ZycieMaksymalne;
                Console.WriteLine($"Aktualny poziom zdrowia to: {zycie}/{ZycieMaksymalne} ({procentZycia:F2}%)");
            } 
            else if (zycie == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bohater nie żyje"); 
                Console.ResetColor();
            } 
            else { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bohater jest już uleczony"); 
                Console.ResetColor();
            }
        } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Za mało jedzenia");
            Console.ResetColor();
        }
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie wybrano poprawnej opcji");
        Console.ResetColor();
        break;
}

Console.ResetColor();