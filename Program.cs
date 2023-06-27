using System;

namespace DOWHILELOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int score, total  = 0;
            string answer = "N";
            int i = 0;
            int count = 1;

            do
            {
                Console.WriteLine("Enter a score:");
                score = int.Parse(Console.ReadLine());
                total = total + score;
                i++;
                Console.WriteLine("Do you want to enter another score?(Y/N)");
                answer = Console.ReadLine();
                count = count + 1;

            }
            while (answer == "Y");
            Double average = total/i;
            Console.WriteLine("The average of the scores is: " + average);
        }
    }
}
