using System.ComponentModel.DataAnnotations;

class Costume
{
    // Attributes
    public string outfit="";

    public string footwear="";

    public string tools="";

    public string size="";

    // Behaviors
    public void Display()
    {
        Console.WriteLine($"Outfit: {outfit}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Footwear: {footwear}");
        Console.WriteLine($"Accessories: {tools}");
    }
}