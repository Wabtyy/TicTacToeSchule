string rawdata = "O;X; ;X; ;X; ;O; ".ToLower();
string[] data = rawdata.Split(";");

string oo = "         ";

string x1 = "   ═╗ ╔═ ";
string x2 = "    ╚╦╝  ";
string x3 = "    ╔╩╗  ";
string x4 = "   ═╝ ╚═ ";

string o1 = "    ╔═╗  ";
string o2 = "   ╔╝ ╚╗ ";
string o3 = "   ╚╗ ╔╝ ";
string o4 = "    ╚═╝  ";

int counter = 0;
int secondcounter = 0;
for (int x = 0; x < 4; x++)
{
    counter += 1;

    for (int i = 0; i < data.Length/3; i++)
    {
        switch (data[i])
        {
            case "x": print("x"); break;
            case "o": print("o"); break;
            case " ": print(" "); break;
        }
    }
    Console.WriteLine();
}
counter = 0;
Console.WriteLine("═══════════════════════════════════");
for (int x = 0; x < 4; x++)
{
    counter += 1;

    for (int i = data.Length / 3; i < data.Length/1.5; i++)
    {
        switch (data[i])
        {
            case "x": print("x"); break;
            case "o": print("o"); break;
            case " ": print(" "); break;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("═══════════════════════════════════"); 
counter = 0;
for (int x = data.Length / 2 + 1; x < data.Length; x++)
{
    counter += 1;

    for (int i = 6; i < 9; i++)
    {
        switch (data[i])
        {
            case "x": print("x"); break;
            case "o": print("o"); break;
            case " ": print(" "); break;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("");




string print(string str)
{
    secondcounter += 1;

    switch (str)
    {
        case "x":
            if (counter == 1) { Console.Write(x1 + "  "); }
            if (counter == 2) { Console.Write(x2 + "  "); }
            if (counter == 3) { Console.Write(x3 + "  "); }
            if (counter == 4) { Console.Write(x4 + "  "); }
            if (secondcounter != 3) { Console.Write("║"); } else { secondcounter = 0; }
            break;

        case "o":
            if (counter == 1) { Console.Write(o1 + "  "); }
            if (counter == 2) { Console.Write(o2 + "  "); }
            if (counter == 3) { Console.Write(o3 + "  "); }
            if (counter == 4) { Console.Write(o4 + "  "); }
            if (secondcounter != 3) { Console.Write("║"); } else { secondcounter = 0; }
            break;

        case " ":
            if (counter == 1) { Console.Write("           "); }
            if (counter == 2) { Console.Write("           "); }
            if (counter == 3) { Console.Write("           "); }
            if (counter == 4) { Console.Write("           "); }
            if (secondcounter != 3) { Console.Write("║"); } else { secondcounter = 0; }
            break;
    }
    return "";
}
