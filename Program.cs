using System;

namespace Pythagorean_theorem_Solver_In_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pythagorean theorem in C# 
            Console.Title = "Pythagorean theorem By Apurva Singh";
            Console.WriteLine("This Project's Source Code Is Also Available On My Website https://apurvasingh.ml");
            Console.WriteLine("Pythagorean theorem referrs to Side A Squared + Side B Squared = Hypotenuse Squared ");
            Console.WriteLine("Note: Please Enter Single Units Only. Decimal Numbers and words Are Currently Isn't Allowed. Thanks ");
            Console.WriteLine("Please Enter Side A");
            string SideAasString = Console.ReadLine();
            int SideA = Int32.Parse(SideAasString);
            Console.WriteLine("Sucessfully Entered the value of Side A. You Have Entered " + SideA);
            Console.WriteLine("Please Enter Side B");
            string SideBasString = Console.ReadLine();
            int SideB = Int32.Parse(SideBasString);
            Console.WriteLine("Sucessfully Entered the value of Side B. You Have Entered " + SideB);
            int SideASQ = SideA * SideA;
            int SideBSQ = SideB * SideB;
            int Final = SideASQ + SideBSQ;

            Console.WriteLine("Hypotenuse Is");
            Console.Write(Math.Sqrt(Final));
            Console.WriteLine(" Units");
            Console.WriteLine("Thanks For Using");
            Console.ReadLine();
        }
    }
}
