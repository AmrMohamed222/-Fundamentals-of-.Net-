namespace Age_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your birth year: ");
            int x = int.Parse(Console.ReadLine()), Age, current_year = 2024;
            Age = current_year - x;
            Console.WriteLine("You are " + Age + " years old.");
        }
    }
}