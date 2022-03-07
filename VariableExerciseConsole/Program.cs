using System;

namespace VariablesExerciseConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variable Delcarations
            int age;
            string name;

            bool isPuertorican;
            Decimal weight;
            


            //Variable initalization
            age = 24;
            name = "Plinio";
            isPuertorican = true;
            weight = 150.23m;

            string fullname = "Plinio Colon";
            

            Console.WriteLine($"{name} age is {age }. is he puerorican?: {isPuertorican}.The weight of {fullname} is: {weight}lb");

            
        }
    }


}