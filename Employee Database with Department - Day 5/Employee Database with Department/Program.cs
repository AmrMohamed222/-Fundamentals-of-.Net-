namespace Employee_Database_with_Department
{
    internal class Program
    {
        struct Employees()
        {
            public int EmployeeID;
            public string Name;
            public int Salary;
            public Departments Department;
        }

        enum Departments
        {
            HR = 1,
            IT = 2,
            Sales = 3,
            Finance = 4,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter number of Employees: ");
            Employees[] Employee = new Employees[Convert.ToInt32(Console.ReadLine())];

            float highest = 0, total_salary = 0;
            Departments department = default;

            for (int i = 0; i < Employee.Length; i++)
            {
                Console.WriteLine($"Please, Enter Employee :{i + 1} ");
                Console.Write($"Please, Enter the ID of Employee: ");
                Employee[i].EmployeeID = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Please, Enter the Name of Employee: ");
                Employee[i].Name = Console.ReadLine();
                Console.Write($"Please, Enter the Salary of Employee: ");
                Employee[i].Salary = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Please, Press the Department of Employee:\n1-HR\n2-IT\n3-Sales\n4-Finance\n ");

                int x = Convert.ToInt32(Console.ReadLine());
                Employee[i].Department = (Departments)x;

                total_salary += Employee[i].Salary;
                if (highest < Employee[i].Salary)
                {
                    highest = Employee[i].Salary;
                    department = Employee[i].Department;
                }

            }
            Console.WriteLine($"\nTotal salary is: {total_salary}");
            Console.WriteLine($"Employee Department of highest salary is: {department} and the highest salary is {highest}\n");

        }
    }
}
