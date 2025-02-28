string rawdata = "o; ;o;o;x;x;X; ;O".ToLower();
string[] data = rawdata.Split(";");

string x1 = "   ═╗ ╔═ ",    o1 = "    ╔═╗  ";
string x2 = "    ╚╦╝  ",    o2 = "   ╔╝ ╚╗ ";
string x3 = "    ╔╩╗  ",    o3 = "   ╚╗ ╔╝ ";
string x4 = "   ═╝ ╚═ ",    o4 = "    ╚═╝  ";

int counter = 1, secondcounter = 0, one = 0, two = 3;

//////////////////////////////////////////////////////

for (int z = 0; z < 4; z++, one+=3, two+=3, counter=1)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("╠╬════════════╬════════════╬═══════════╬╣");

    for (int x = 0; x < 4; x++, counter += 1)
    {
        for (int i = one; i < two; i++)
        {
            try
            {
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
                    Console.Write(" ║           ");
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
