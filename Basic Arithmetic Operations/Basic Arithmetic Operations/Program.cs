namespace Basic_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please, enter two var.");
            int x = int.Parse (Console.ReadLine()), y = int.Parse (Console.ReadLine()), Sum , Dif , Product;
            Sum = x + y;
            Dif = x - y;
            Product = x * y;
            Console.WriteLine ("The sum is:" + Sum);
            Console.WriteLine("The Dif is:" + Dif);
            Console.WriteLine("The Product is:" + Product);
            #region manual converting
            /*
            string num = Console.ReadLine();
            int res = 0, p = 1;
            for(int i = num.Length-1; i >= 0; i--)
            {
                res = res + (num[i] - '0') * p;
                p = p * 10;
            }
            Console.WriteLine(res);
            */
            #endregion

        }
    }
}
