using System;
namespace Student_Grades
{
    internal class Program
    {
        struct Students()
        {
            public string Name;
            public int[] grads;
            public Level level;
        }

        enum Level
        {
            Freshman = 1,
            Sophomore = 2,
            Junior = 3,
            Senior = 4,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter number of students: ");
            Students[] Student = new Students[Convert.ToInt32(Console.ReadLine())];


            float average = 0, highest = 0;

            for (int i = 0; i < Student.Length; i++)
            {
                Student[i].grads = new int[5];
                Console.WriteLine($"Please, Enter Student :{i + 1} ");
                Console.Write($"Please, Enter the Name of Student: ");
                Student[i].Name = Console.ReadLine();
                Console.Write($"Please, Press the year level of Student: 1-Freshman\n 2-Sophomore\n 3-Junior\n 4-Senior\n");
                int x = Convert.ToInt32(Console.ReadLine());
                Student[i].level = (Level)x;
                for (int j = 0; j < 5 ; j++)
                {
                    Console.Write($"Please, Enter the the grade for course {j+1} of Student: ");
                    Student[i].grads[j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < Student.Length; i++)
            {
                float sum = 0;
                for (int j = 0; j < Student[i].grads.Length; j++)
                {
                    sum += Student[i].grads[j];
                }
                average = sum / Student[i].grads.Length;
                
                //double temp = Student[i].grads.Average();
                
                highest = Math.Max(highest, average);

                Console.WriteLine($"\nStudent :{i + 1}");
                Console.Write($"\nName is: {Student[i].Name}");
                Console.Write($"\nThe year level is: {Student[i].level}");
                Console.Write($"\nAverage grade is: {average}\n");
            }
            Console.WriteLine($"\n\nhighest Average grade is: {highest}");
        }
    }
}
