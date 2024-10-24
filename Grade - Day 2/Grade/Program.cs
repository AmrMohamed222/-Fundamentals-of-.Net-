namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter student degree: ");

            string degree = Console.ReadLine();

            switch(degree)
            {
                case "A":
                    Console.WriteLine("The Grade is: Excellent");
                    break;
                case "B":
                    Console.WriteLine("The Grade is: Very Good");
                    break;
                case "C":
                    Console.WriteLine("The Grade is: Good");
                    break;
                case "D":
                    Console.WriteLine("The Grade is: Fair");
                    break;
                case "E":
                    Console.WriteLine("The Grade is: Failed");
                    break;
                default:
                    Console.WriteLine("It's not a degree");
                    break;
            }
        }
    }
}
