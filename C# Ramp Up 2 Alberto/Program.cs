using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ramp_Up_2_Alberto
{
    public class Program
    {
        public static void Main()
        {
            string arrivederci = "Welcome to the Ramp Up 2 Application(Alberto)";
            string aurevoir = "Thank you for using the App";
            string linebreak = "---------------------------------------------";
            Console.WriteLine(arrivederci);
            Console.WriteLine(linebreak);

            //weight conversion
            Console.WriteLine("Enter your weight(lbs): ");
            string weight = Console.ReadLine();

            try
            {
                double userweight = double.Parse(weight);
                double kilo = 0.453592;
                double result = userweight * kilo;
                Console.WriteLine($"Your weight in Kilograms is: {result}\n");
                Console.WriteLine(linebreak+ "\n");
            }

            catch
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Enter length in miles: ");
            string miles = Console.ReadLine();

            //distance conversion
            try
            {
                double usermiles = double.Parse(miles);
                double km = 1.60934;
                double kmResult = usermiles * km;
                Console.WriteLine($"{miles} in kilometres is: {kmResult}\n");
                Console.WriteLine(linebreak + "\n");
            }

            catch
            {
                Console.WriteLine("You messed up");
            }

            //temperature conversion
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            string fahren = Console.ReadLine();

            try
            {
                double userfahren = double.Parse(fahren);
                double celcius = -17.2222;
                double celciusResult = userfahren * celcius;
                Console.WriteLine($"{fahren} in celcius is: {celciusResult}\n");
                Console.WriteLine(linebreak + "\n");
            }

            catch
            {
                Console.WriteLine("You messed up");
            }
            //declaration
            Console.WriteLine("Enter student 1 age: ");
            string age1 = Console.ReadLine();
            Console.WriteLine("Enter student 2 age: ");
            string age2 = Console.ReadLine();
            Console.WriteLine("Enter student 3 age: ");
            string age3 = Console.ReadLine();
            Console.WriteLine("Enter student 4 age: ");
            string age4 = Console.ReadLine();
            Console.WriteLine("Enter student 5 age: ");
            string age5 = Console.ReadLine();
            Console.WriteLine("Enter student 6 age: ");
            string age6 = Console.ReadLine();
            Console.WriteLine("Enter student 7 age: ");
            string age7 = Console.ReadLine();
            Console.WriteLine("Enter student 8 age: ");
            string age8 = Console.ReadLine();
            Console.WriteLine("Enter student 9 age: ");
            string age9 = Console.ReadLine();
            Console.WriteLine("Enter student 10 age: ");
            string age10 = Console.ReadLine();
            //initialization
            double stu1 = double.Parse(age1);
            double stu2 = double.Parse(age2);
            double stu3 = double.Parse(age3);
            double stu4 = double.Parse(age4);
            double stu5 = double.Parse(age5);
            double stu6 = double.Parse(age6);
            double stu7 = double.Parse(age7);
            double stu8 = double.Parse(age8);
            double stu9 = double.Parse(age9);
            double stu10 = double.Parse(age10);
            //sum up
            double ageSum = stu1 + stu2 + stu3 + stu4 + stu5 + stu6 + stu7 + stu8 + stu9 + stu10;
            double ageResult = ageSum / 10;
            Console.WriteLine($"The average is: {ageResult}");
            Console.WriteLine(linebreak + "\n");



            Console.WriteLine(aurevoir);
        }
    }
}
