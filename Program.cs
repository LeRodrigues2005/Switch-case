// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code> // "01-MN-L"
Console.WriteLine("TYPE: 01 -> Sweat shirt || 02 -> T--shirt || 03 -> Sweat pants\nCOLOR: BL -> BLACK || MN -> MAROON\nSIZE: S -> SMALL || M -> MEDIUM || L -> LARGUE\n");
Console.WriteLine("Type a value format TYPE-COLOR-SIZE: ");
string sku = Console.ReadLine();

string[] product = sku.Split('-').Select(x => x.ToUpper()).ToArray();

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
