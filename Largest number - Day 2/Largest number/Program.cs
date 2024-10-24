namespace Largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First solution

            /*
            Console.WriteLine("Enter three Numbers: ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int Max1 = Math.Max(num1, num2);
            int Max2 = Math.Max(num2, num3);
            int Max3 = Math.Max(Max1, Max2);
            Console.WriteLine("Largest is: " + Max3);
            //Console.Beep();
            //Console.ReadKey();
            */

            //----------------------------------------------------------------------------
            
            // Second solution

           /* Console.WriteLine("Enter three Numbers: ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mx = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine("Largest is: " + mx);
           */

            //------------------------------------------------------------------------------

            //Third Solution and the best solution

            Console.WriteLine("Enter three Numbers: ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Largest is: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Largest is: " + num2);
            }
            else
            {
                Console.WriteLine("Largest is: " + num3);
            }
         }
    }
}
