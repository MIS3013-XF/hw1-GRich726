// HW1b Grade

// Gabe Richardson:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? "); //fname
            string fname = Console.ReadLine();
            
            Console.WriteLine("What is your last name? "); //lname
            string lname = Console.ReadLine();
            
            Console.WriteLine("What is your student id? "); //id
            string idInput = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for your homeworks? "); //hw
            string homeworkInput = Console.ReadLine();
            double homeworkPercentage = Convert.ToDouble(homeworkInput);

            Console.WriteLine("What is your overall percentage grade for your participations? "); //part
            string partInput = Console.ReadLine();
            double partPercentage = Convert.ToDouble(partInput);

            Console.WriteLine("What is your overall percentage grade for your first exam? "); //exam 1
            string exam1Input = Console.ReadLine();
            double exam1Percentage = Convert.ToDouble(exam1Input);

            Console.WriteLine("What is your overall percentage grade for your midterm? "); //exam 2
            string exam2Input = Console.ReadLine();
            double exam2Percentage = Convert.ToDouble(exam2Input);

            Console.WriteLine("What is the overeall percentage grade for your final? "); //final
            string finalInput = Console.ReadLine();
            double finalPercentage = Convert.ToDouble(finalInput);

            //grade weights
            double hwWeight = 0.20;
            double partWeight = 0.15;
            double exam1Weight = 0.15;
            double exam2Weight = 0.25;
            double finalWeight = 0.25;

            //final grade calculation
            double finalgrade = (homeworkPercentage * hwWeight) + (partPercentage * partWeight) + (exam1Percentage * exam1Weight) +
                (exam2Percentage * exam2Weight) + (finalPercentage * finalWeight);

            Console.WriteLine(fname + " " + lname + " " + "(" + idInput + ")" + " " + "your final grade is: " + finalgrade);
        }
    }
}
