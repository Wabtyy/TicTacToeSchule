

using System.Security.Cryptography;

string x1 = "   ═╗ ╔═ ",    o1 = "    ╔═╗  ";
string x2 = "    ╚╦╝  ",    o2 = "   ╔╝ ╚╗ ";
string x3 = "    ╔╩╗  ",    o3 = "   ╚╗ ╔╝ ";
string x4 = "   ═╝ ╚═ ",    o4 = "    ╚═╝  ";

int counter = 1, secondcounter = 0, one = 0, two = 3, three=-1, piece=0;
string[] data = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

bool realgame = false;
//////////////////////////////////////////////////////
for (int c = 0; c < 13; c++, one = 0, two = 3, counter = 1, secondcounter = 0)
{ if (three < 4) { three++; } else { Thread.Sleep(c * 35); }
    
    
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
        string a = " ; ; ; ; ; ; ; ; ";
        data = a.Split(";");
        realgame = true;

    }

        Console.Clear();

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
            Console.WriteLine();
        }
        if (three < 4) { Thread.Sleep(20); }
    }
}


void menu(string str)
{
        switch (str)
        {
            case "input":
            Console.WriteLine("╠╬════════════╣            ╠═══════════╬╣");
            break;
        }
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
                    Console.ForegroundColor = ConsoleColor.White; }
                    else
                    {
                    Console.Write($" ║           ");
                    }
                    print("backline");
            break;

            case "backline":
                    Console.ForegroundColor = ConsoleColor.White;
                    secondcounter -= 1;
                    if (secondcounter == 3) { secondcounter = 0; Console.Write("║"); }
            break;
        }
}

    Thread.Sleep(200000);
    Console.Clear();
