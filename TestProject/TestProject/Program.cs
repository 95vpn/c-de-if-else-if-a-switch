// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
/*
string fruit = "cherry";

switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry");
        break;
}
*/

/*
int employeeLevel = 100;
string employeeName = "John Smith";


string title = "";

switch (employeeLevel)
{
    case 100:
        //title = "Junior Associate";
        //break;
    
    case 200:
        title = "Senior Adociate";
        break;

    case 300:
        title = "Manager";
        break;
    
    case 400:
        title= "Senior Manager";
        break;

    default:
        title = "Asociate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
*/

//pasar de un programa con estructura if - else if - a switch
string sku = "01-MN-L";

string[] product = sku.Split('-');
string modelo = product[0];
string colores = product[1];
string talla = product[2];

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else {
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
} 
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

switch (modelo)
{
    case "01":
        type = "Sweat Shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat Pants";
        break;
    default:
        type = "Other";
        break;

}

switch (colores)
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

switch (talla)
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

Console.WriteLine($"Tamaño: {size} {color} {type}");