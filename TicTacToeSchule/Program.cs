string x1 = "   ═╗ ╔═ ",    o1 = "    ╔═╗  ";
string x2 = "    ╚╦╝  ",    o2 = "   ╔╝ ╚╗ ";
string x3 = "    ╔╩╗  ",    o3 = "   ╚╗ ╔╝ ";
string x4 = "   ═╝ ╚═ ",    o4 = "    ╚═╝  ";

int counter = 1, secondcounter = 0, one = 0, two = 3, three=-1, piece=0, moves=0;
string[] data = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
string aa = " ; ; ; ; ; ; ; ; ", Indicator="x";
bool realgame = false, spieler=true;

//////////////////////////////////////////////////////
///
Console.WriteLine("Animation? (y/n)");
if (Console.ReadLine() == "y")
{
    for (int c = 0; c < 13; c++, one = 0, two = 3, counter = 1, secondcounter = 0) //alles für die startanmation
    {
        if (three < 4) { three++; } else { Thread.Sleep(c * 35); }
        if (c < 12)
        {
            Random rnd = new Random();
            for (int t = 0; t < 9; t++)
            {
                int a = three < 4 ? 1 : rnd.Next(1, 4);
                switch (a)
                {
                    case 1: data[t] = "x"; break;
                    case 2: data[t] = "o"; break;
                    case 3: data[t] = " "; break;
                }
            }
        }
        else
        {
            Thread.Sleep(200);
            data = aa.Split(";");
            realgame = true;
        }

        Console.Clear();
        preprint();
    }
    menu("input");
}
else
{
    resetvars();
    Console.Clear();
    Thread.Sleep(200);
    data = aa.Split(";");
    realgame = true;

    preprint();

}
    void preprint()
    {
        for (int z = 0; z < 4; z++, one += 3, two += 3, counter = 1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╠╬════════════╬════════════╬═══════════╬╣");
            for (int x = 0; x < three; x++, counter += 1)
            {
                for (int i = one; i < two; i++)
                {
                    try
                    {
                        piece = i;
                        switch (data[i])
                        {
                            case "x": print("x"); break;
                            case "o": print("o"); break;
                            case " ": print(" "); break;
                        }
                    }
                    catch { break; }
                }
            }
            if (three < 4) { Thread.Sleep(20); }
        }
        if (realgame) { menu("input"); } // wenn es nicht die startaniamtion ist, spieler nach eingabe fragen
    }

void resetvars()
{
    one = 0; two = 3; counter = 1; secondcounter = 0; three = 4;
}

    void menu(string str)
    {
    resetvars();
    switch (str)
        {
            case "input":
            Console.WriteLine(" ╚╦══════╗                 ╚═══╗    ╔══╝");
            Console.WriteLine("  ╠>     ║                 ╔═══╩════╩══╗");
            Console.Write("  ╚══════╝                 ║ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(spieler?"Spieler 1":"Spieler 2"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" ╠╣\n");
            Console.WriteLine("                           ╚═══════════╝");
            break;
        }
    Console.SetCursorPosition(6, 17);
    Console.ForegroundColor = ConsoleColor.Red;
    switch (Console.ReadLine())
    {
        case "1": data[0] = spieler ? "x" : "o"; moves++; break;
        case "2": data[1] = spieler ? "x" : "o"; moves++; break;
        case "3": data[2] = spieler ? "x" : "o"; moves++; break;
        case "4": data[3] = spieler ? "x" : "o"; moves++; break;
        case "5": data[4] = spieler ? "x" : "o"; moves++; break;
        case "6": data[5] = spieler ? "x" : "o"; moves++; break;
        case "7": data[6] = spieler ? "x" : "o"; moves++; break;
        case "8": data[7] = spieler ? "x" : "o"; moves++; break;
        case "9": data[8] = spieler ? "x" : "o"; moves++; break;
        default: Console.Clear(); Console.WriteLine("Ungültige eingabe!"); Thread.Sleep(2000); Console.Clear(); preprint();  break;
    }
    
    Console.ForegroundColor = ConsoleColor.White;

    spieler = !spieler;
    checkwin();
        Console.Clear();
    preprint();
}

void print(string str) 
{ 
        secondcounter += 1;

        switch (str)
        {
              case "x":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ║");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (counter == 1) { Console.Write(x1 + "  "); }
                    if (counter == 2) { Console.Write(x2 + "  "); }
                    if (counter == 3) { Console.Write(x3 + "  "); }
                    if (counter == 4) { Console.Write(x4 + "  "); }
                    print("backline");
            break;

            case "o":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ║");
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (counter == 1) { Console.Write(o1 + "  "); }
                    if (counter == 2) { Console.Write(o2 + "  "); }
                    if (counter == 3) { Console.Write(o3 + "  "); }
                    if (counter == 4) { Console.Write(o4 + "  "); }
                    print("backline");
            break;

            case " ":
           
                    if (counter==2&&realgame==true) 
                    { 
                    Console.Write(" ║"); 
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.Write($"     {piece+1}     "); 
                    Console.ForegroundColor = ConsoleColor.White; 
                    }
                    else
                    {
                    Console.Write($" ║           ");
                    }
                    print("backline");
            break;

            case "backline":
                    Console.ForegroundColor = ConsoleColor.White;
                    secondcounter -= 1;
                    if (secondcounter == 3) { secondcounter = 0; Console.Write("║\n"); }
            break;
        }
}

void checkwin()
{
    
    for (int indcounter = 0; indcounter < 2; indcounter++)
    {
        if (indcounter==1) { Indicator = "x"; } else { Indicator = "o"; }
        if (data[0] == Indicator && data[1] == Indicator && data[2] == Indicator) { Win(false); }
        if (data[3] == Indicator && data[4] == Indicator && data[5] == Indicator) { Win(false); }
        if (data[6] == Indicator && data[7] == Indicator && data[8] == Indicator) { Win(false); }

        if (data[0] == Indicator && data[3] == Indicator && data[6] == Indicator) { Win(false); }
        if (data[1] == Indicator && data[4] == Indicator && data[7] == Indicator) { Win(false); }
        if (data[3] == Indicator && data[5] == Indicator && data[8] == Indicator) { Win(false); }

        if (data[0] == Indicator && data[4] == Indicator && data[8] == Indicator) { Win(false); }
        if (data[2] == Indicator && data[4] == Indicator && data[6] == Indicator) { Win(false); }
    }
    if (moves == 9) { Win(true); }
}
void Win(bool unendschieden)
{


    if(unendschieden==false)
    {
        Console.WriteLine(!spieler ? "Spieler 1 hat gewonnen" : "Spieler 2 hat gewonnen");
    }
    else
    {
        Console.WriteLine("Unendschieden");
    }

    Console.ReadLine();
}
