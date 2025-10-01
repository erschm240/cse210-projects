using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Costume myCostume = new Costume();
        myCostume.outfit = "Wetsuit";
        myCostume.size = "Small";
        myCostume.footwear = "Flippers";
        myCostume.tools = "Goggles, snorkel, camera";
        myCostume.Display();
    }
}