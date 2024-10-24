namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number between 2 and 9: ");
            
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= 10; i++)
            {
                int multiplier = num * i;
                Console.WriteLine(num + " * " + i +" = " + multiplier);
            }
        }
    }
}
