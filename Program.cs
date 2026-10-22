const int ZycieMaksymalne = 100;

int zycie;
int zloto;
int mikstury;

int numerTury = 1;
int numerEksploracji = 0;

bool graDziala = true;

Console.Clear();
Console.Write("\nJak masz na imię? ");
string imie = Console.ReadLine()!;
Console.Clear();

while (true)
{
    Console.Write("Podaj punkty zdrowia: ");
    bool poprawneZdrowie = int.TryParse(Console.ReadLine(), out zycie);

    if (!poprawneZdrowie) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wpisz poprawną liczbę całkowitą");
        Console.ResetColor();
        continue;
    } 
    if (zycie < 1 || zycie > ZycieMaksymalne) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wpisz liczbę z zakresu 1-{ZycieMaksymalne}");
        Console.ResetColor();
        continue;
    }
    Console.Clear();
    
    break;
}
while (true)
{
    Console.Write("Podaj ilość złota: ");
    bool poprawneZloto = int.TryParse(Console.ReadLine(), out zloto);

    if (!poprawneZloto) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wpisz poprawną liczbę całkowitą");
        Console.ResetColor();
        continue;
    } 
    if (zloto < 0) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wpisz liczbę dodatnią");
        Console.ResetColor();
        continue;
    }
    Console.Clear();

    break;
}   
while (true)
{
    Console.Write("Podaj ilość mikstur: ");
    bool poprawneMikstury = int.TryParse(Console.ReadLine(), out mikstury);

    if (!poprawneMikstury) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wpisz poprawną liczbę całkowitą");
        Console.ResetColor();
        continue;
    } 
    if (mikstury < 0) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wpisz liczbę dodatnią");
        Console.ResetColor();
        continue;
    }
    Console.Clear();

    break;
}

while (graDziala && zloto >= 0 && mikstury >= 0)
{   
    if(zycie <= 0){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"=== KONIEC GRY ===");
        Console.WriteLine($"Bohater: {imie}");
        Console.WriteLine($"Rozegrane tury: {numerTury}");
        Console.WriteLine($"Eksploracje: {numerEksploracji}");
        Console.WriteLine($"Zdrowie: {zycie}/{ZycieMaksymalne}");
        Console.WriteLine($"Złoto: {zloto}");
        Console.WriteLine($"Mikstury: {mikstury}");
        Console.ForegroundColor = ConsoleColor.Red;                         
        Console.WriteLine($"Powód zakończenia: gracz {imie} umarł.\n");
        Console.ResetColor();
        graDziala = false;
        break;
    }
    Console.WriteLine($"=== HELLO ADVENTURER ===\n");
    Console.WriteLine($"Tura: {numerTury}");
    Console.WriteLine($"Bohater: {imie}");
    Console.WriteLine($"Zdrowie: {zycie}/{ZycieMaksymalne} | Złoto: {zloto} | Mikstury: {mikstury}\n");

    Console.WriteLine($"1 - Eksploruj loch");
    Console.WriteLine($"2 - Użyj mikstury");
    Console.WriteLine($"3 - Odpocznij");
    Console.WriteLine($"4 - Pokaż statystki");
    Console.WriteLine($"5 - Zakończ grę\n");

    bool poprawnyWybor = int.TryParse(Console.ReadLine(), out int wybor);
    Console.Clear();
    switch(wybor)
    {
        case 1:
            numerTury++;
            numerEksploracji++;

            zloto+=10;
            zycie-=8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"+10 złota");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-8 zdrowia");
            Console.ResetColor();
            Console.Write($"\nTwoje aktualne zdrowie: {zycie}/{ZycieMaksymalne} | złoto: {zloto}\n\n");
            break;
        case 2:
            if (mikstury >= 1) {
                numerTury++;

                mikstury--;
                zycie = zycie + 20 > ZycieMaksymalne ? zycie = ZycieMaksymalne : zycie + 20;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Uleczyłes się\n");
                Console.ResetColor();
                Console.Write($"Twoje aktualne zdrowie to: {zycie}/{ZycieMaksymalne}\nPozostało ci {mikstury} mikstur.\n\n");
                break;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Nie masz już mikstur\n\n");
                Console.ResetColor();
            }
            break;
        case 3:
            if (zloto >= 3) {
                numerTury++;

                zycie = zycie + 5 > ZycieMaksymalne ? zycie = ZycieMaksymalne : zycie + 5;
                zloto -= 3;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"+5 zdrowia");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("-3 złota");
                Console.ResetColor();
                Console.Write($"\nTwoje aktualne zdrowie: {zycie}/{ZycieMaksymalne} | złoto: {zloto}\n\n");
                break;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Nie masz wystarczająco złota\n\n");
                Console.ResetColor();
            }
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"=== Statystki ===");
            Console.WriteLine($"Eksploracje: {numerEksploracji}\n");
            Console.ResetColor();
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"=== KONIEC GRY ===");
            Console.WriteLine($"Bohater: {imie}");
            Console.WriteLine($"Rozegrane tury: {numerTury}");
            Console.WriteLine($"Eksploracje: {numerEksploracji}");
            Console.WriteLine($"Zdrowie: {zycie}/{ZycieMaksymalne}");
            Console.WriteLine($"Złoto: {zloto}");
            Console.WriteLine($"Mikstury: {mikstury}");
            Console.WriteLine($"Powód zakończenia: gracz wybrał wyjście.\n");
            Console.ResetColor();
            graDziala = false;
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Wybrano nie prawidłową opcję\n\n");
            Console.ResetColor();
            break;
    }
}

Console.ResetColor();