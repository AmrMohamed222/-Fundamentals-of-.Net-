namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the temperature in celsius");
            float C = float.Parse(Console.ReadLine()), F;
            F = C * 9/5 + 32;
            Console.WriteLine(C + " degrees Celsius is " + F + " degrees Fahrenheit");
        }
    }
}
