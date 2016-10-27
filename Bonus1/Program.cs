using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1
{
    class Bonus1
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string grade="Unknown";
                Console.WriteLine("Please enter the student's score");
                Int32 score = Convert.ToInt32(Console.ReadLine());
                if (score >= 88 && score <= 100)
                {
                    grade = "A";
                }
                else if (score >= 80 && score <= 87)
                {
                    grade = "B";
                }
                else if (score >= 67 && score <= 79)
                {
                    grade = "C";
                }
                else if (score >= 60 && score <= 66)
                {
                    grade = "D";
                }
                else if (score >= 0 && score <= 60)
                {
                    grade = "F";
                }
                Console.WriteLine("The corressponding letter grade is "+grade);
                Console.WriteLine("Would you like to continue? (Press any key for yes or N for no)");
                string answer = Console.ReadLine();//prompts user if they want to continue
                if (answer == "N")
                {
                    break;
                }
            }
        }
    }
}
