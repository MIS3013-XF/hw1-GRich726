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
            int idNumber = Convert.ToInt32(idInput);

            Console.WriteLine("What is your overall percentage grade for you homeworks? ");
            string homeworkInput = Console.ReadLine();
            double homeworkPercentage = Convert.ToDouble(homeworkInput);
        }
    }
}
