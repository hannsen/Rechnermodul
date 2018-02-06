using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace test
{
    class Grundrechner
    {
        static void Main(string[] args)
        {
            String input = "( 2.000 + ,1) * (4 - 1)";

            // Input sanitize
            string tausendTrenner = ".";
            string kommaZeichen = ",";
            input = input.Replace(" ", "");
            input = input.Replace(tausendTrenner, "");
            input = input.Replace(kommaZeichen, ".");

            // Actual calculation
            List<string> infixValues = infixToArray(input);


            foreach (string item in infixValues)
            {
                Console.WriteLine(item);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static List<string> infixToArray(string infix)
        {
            List<string> values = new List<string>();

            char[] operatoren = {'+','-','*','/','(',')'};
            bool numberActive = false;
            foreach (Char c in infix)
            {
                // Zahlen handling
                if (Char.IsNumber(c) || c == '.')
                {
                    // mehrstellige Zahl gefunden
                    if (numberActive){
                        values[values.Count - 1] = values[values.Count - 1] + c.ToString();
                    }
                    // erste Stelle einer Zahl gefunden
                    else{
                        values.Add(c.ToString());
                    }
                    numberActive = true;               
                    continue;
                }
                numberActive = false;

                if (operatoren.Contains(c)) {
                    values.Add(c.ToString());
                }
            }
            return values;
        }

        static double evaluateInfix(List<string> values)
        {
            return 1.00;
        }

        //    if (double.TryParse(value, out tempParse))
        //    {
        //        Console.WriteLine(value);
        //    }
    }
}
