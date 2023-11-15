// See https://aka.ms/new-console-template for more information
// Коляда Олександра
// Варіант 10
using System;
public class Cylinder
{
    private double radius;
    private double height;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value >= 0)
                radius = value;
        }
    }
    public double Height
    {
        get { return height; }
        set
        {
            if (value >= 0)
                height = value;
        }
    }

    public double CalculateVolume()
    {
        return Math.PI * radius * radius * height;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу Cylinder
        Cylinder cylinder = new Cylinder();

        double radius;
        double height;

        Console.Write("Введіть радіус циліндра: ");
        while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
        {
            Console.WriteLine("Введено некоректне значення. Введіть будь ласка додатнє число.");
            Console.Write("Введіть радіус циліндра: ");
        }

        Console.Write("Введіть висоту циліндра: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
        {
            Console.WriteLine("Введено некоректне значення. Введіть будь ласка додатнє число.");
            Console.Write("Введіть висоту циліндра: ");
        }

        cylinder.Radius = radius;
        cylinder.Height = height;

        // Обчислення та виведення об'єму циліндра
        Console.WriteLine($"Об'єм циліндра з радіусом {cylinder.Radius} та висотою {cylinder.Height} дорівнює {cylinder.CalculateVolume():F2}");
    }
}
