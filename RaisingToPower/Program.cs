using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaisingToPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2;
            int power = 0;
            double calculatedNumber = 0;
            int maxValue = 1024;

            Random rand = new Random();
            int givenNumber = rand.Next(maxValue);

            bool doFind = true;

            while (doFind)
            {   
                calculatedNumber = Math.Pow(value, power);
                power++;

                if (givenNumber < calculatedNumber)
                {
                    power--;
                    doFind = false;                   
                }                                
            }
            Console.WriteLine($"заданное число: {givenNumber}");
            Console.WriteLine($"двойка в степени {power}\n{givenNumber.ToString("N0")}<{calculatedNumber.ToString("N0")}");
        }
    }
}
