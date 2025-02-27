string rawdata = "O;X;O;X;O;X;X;O;O".ToLower();
string[] data = rawdata.Split(";");

string x1 = "█▄▄█";
string x2 = " ██ ";
string x3 = "█▀▀█";

string o1 = "████";
string o2 = "█  █";
string o3 = "████";
int counter = 0;
for (int x = 0; x < 4; x++)
{
    counter += 1;
    for (int i = 0; i < 6; i++)
    {
       

        switch (data[i])
        {
            case "x": print("x"); break;
            case "o": print("o"); break;

        }
    }
    Console.Write("\n");

}

    Console.WriteLine("");




string print(string str)
{
    switch (str)
    {
        case "x":
            if (counter == 1) { Console.Write(x1 + "  "); }
            if (counter == 2) { Console.Write(x2 + "  "); }
            if (counter == 3) { Console.Write(x3 + "  "); }
            if (counter == 4) { Console.Write(x4 + "  "); }
            break;

        case "o":
            if (counter == 1) { Console.Write(o1 + "  "); }
            if (counter == 2) { Console.Write(o2 + "  "); }
            if (counter == 3) { Console.Write(o3 + "  "); }
            if (counter == 4) { Console.Write(o4 + "  "); }
            break;
    }
    return "";
}