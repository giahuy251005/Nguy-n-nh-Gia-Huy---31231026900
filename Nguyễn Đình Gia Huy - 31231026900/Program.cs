namespace Nguyen Dinh Gia Huy_31231026900
{
    internal class Section_02
{
    public static void Main()
    {
        Question_1();
        Question_2();
    }

    public static void Question_1()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} * {b} = {a * b}");

    }

    public static void Question_2()
    {
        Console.Write("Enter the A number: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Enter the B number: ");
        int B = int.Parse(Console.ReadLine());
        int temp = A;
        A = B;
        B = temp;
        Console.WriteLine("Value of A after being swapped: " + A);
        Console.WriteLine("Value of B after being swapped: " + B);

    }

    public static void Question_3()
    {
        Console.Write("Enter the first float number: ");
        float float1 = float.Parse(Console.ReadLine());
        Console.Write("Enter the second float number: ");
        int B = int.Parse(Console.ReadLine());
    }

    public static void Question_4()
    {
        Console.Write("Enter feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double meters = feet * 0.3048;
        Console.WriteLine($"{feet} feet is equal to {meters} meters");
    }

    public static void Question_5()
    {
        Console.Write("Enter temperature (C for Celsius, F for Fahrenheit, e.g., 32C): ");
        string input = Console.ReadLine().Trim();
        char scale = input[^1]; // Get the last character
        double temperature = Convert.ToDouble(input[0..^1]); // Get all but the last character

        if (scale == 'C' || scale == 'c')
        {
            double fahrenheit = (temperature * 9 / 5) + 32;
            Console.WriteLine($"{temperature}C is {fahrenheit}F");
        }
        else if (scale == 'F' || scale == 'f')
        {
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine($"{temperature}F is {celsius}C");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a temperature ending with 'C' or 'F'.");
        }
    }

    public static void Question_6()
    {
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of float: {sizeof(float)} bytes");
        Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        Console.WriteLine($"Size of char: {sizeof(char)} bytes");
        Console.WriteLine($"Size of long: {sizeof(long)} bytes");
        Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
    }

    public static void Question_7()
    {
        Console.Write("Enter a character: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine($"\nASCII value of '{character}': {(int)character}");
    }

    public static void Question_8()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Area of the circle: {area}");
    }

    public static void Question_9()
    {
        Console.Write("Enter side length of the square: ");
        double side = Convert.ToDouble(Console.ReadLine());
        double area = Math.Pow(side, 2);
        Console.WriteLine($"Area of the square: {area}");
    }

    public static void Question_10()
    {
        Console.Write("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        int years = days / 365;
        days %= 365;
        int weeks = days / 7;
        days %= 7;
        Console.WriteLine($"{years} years, {weeks} weeks, {days} days");
    }
}

}

