using System;
static class Circle
{
    public static double pi = 3.14;
    public static void PrintArea(double radius)
    {
        Console.WriteLine($"Area is {pi*radius*radius}");
    }
    public static void PrintCircumference(double radius)
    {
        Console.WriteLine($"Circumference is {2*pi*radius}");
    }
}
class Test 
{
    static void Main(string[] args)
    {
        Circle.PrintArea(2);
        Circle.PrintCircumference(2);
    }
}