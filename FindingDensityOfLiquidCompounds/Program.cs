// Application: Finding Density Of Liquid Compounds (console-based)
// Programmed by: Zherish Galvin Mayordo
//
// This program finds the density of a liquid compound with varying temperature
// from 273.15K to 373.15K (0 to 100 degrees Celsius)
//

namespace LiquidCompoundDensity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProgramStart();
        }

        public static void ProgramStart()
        {

            float c1, c2, c3, c4;
            float maxtemperature = 373.15f;

            float result = 0;

            Console.WriteLine("\nEnter the values.");
            Console.WriteLine("\nC1: ");
            c1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nC2: ");
            c2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nC3: ");
            c3 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nC4: ");
            c4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Inputted Values: \nC1: " + c1 + "\nC2: " + c2 + "\nC3: " + c3 + "\nC4: " + c4);
            
            for (float i = 273.15f; i <= maxtemperature; i = i + 10)
            {
                float exponent = 1f + (float)Math.Pow((1f - (i / c3)), c4);
                result = c1 / (float)Math.Pow(c2, exponent);
                Console.WriteLine("\nTemperature: " + i + " Result: " + result);
            }
        }
    }
}
