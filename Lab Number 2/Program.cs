using System;

namespace Lab_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesAnswer = true;

            while (yesAnswer)
            {

                // ask for input
                Console.WriteLine("Please enter the length of the classroom ");
                // user input
                string length = Console.ReadLine();
                // process - converting string length to double 
                double classLength = double.Parse(length);

                // ask for input
                Console.WriteLine("Please enter the width of the classroom ");
                // user input
                string width = Console.ReadLine();
                // process - converting string width to double 
                double classWidth = double.Parse(width);

                // display outputs + Area calculation + Perimeter
                Console.WriteLine("Width is: {0} ", classWidth);
                Console.WriteLine("Length is: {0} ", classLength);
                Console.WriteLine($"The area of the classroom is {classWidth * classLength}");
                Console.WriteLine($"The perimeter of the classroom is {classWidth + classLength + classWidth + classLength}");



                Console.WriteLine("Would you like to continue Yes/No?");
                string answer = Console.ReadLine();



                if (answer != "yes")
                {


                    yesAnswer = false;


                }
               
            }

            
           




        }
    }
}
