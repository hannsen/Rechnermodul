using System;
using System.Collections.Generic;
using System.Linq;

namespace test {
    class Grundrechner {
        static void Main(string[] args) {
            String input = "2 * (-2.000 + ,1) * (4 - 1)  / 4";
            Console.WriteLine(CalculateInput(input));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static double CalculateInput(string input) {
            // Input sanitize
            string tausendTrenner = ".";
            string kommaZeichen = ",";
            input = "(" + input + ")";
            input = input.Replace(" ", "");
            input = input.Replace(tausendTrenner, "");
            input = input.Replace(kommaZeichen, ",");

            // Actual calculation
            List<string> infixValues = InfixToArray(input);
            List<string> postfix = InfixToPostfix(infixValues);
            return CalculatePostfix(postfix);
        }

        static double CalculatePostfix(List<string> postfix) {
            string[] ops = { "+", "-", "*", "/" };
            int i = 0;
            while (true) {
                if (ops.Contains(postfix[i])) {
                    string result = Calc(postfix[i - 2], postfix[i - 1], postfix[i]);
                    if (postfix.Count == 3)
                        return Convert.ToDouble(result);
                    postfix[i] = result;
                    postfix.RemoveAt(i - 2);
                    postfix.RemoveAt(i - 2);
                    i = i - 1; // 2 elements removed, next element in array is i-1
                    continue;
                }
                i++;
            }
        }

        private static List<string> InfixToPostfix(List<string> infix) {
            List<string> postFix = new List<string>() { };
            string arrival;
            Stack<string> opstack = new Stack<string>();
            foreach (string c in infix) {
                if (Double.TryParse(c, out double temp_out)) {
                    postFix.Add(c);
                }
                else if (c == "(") { 
                    opstack.Push(c);
                    }
                else if (c == ")") {
                    arrival = opstack.Pop();
                    while (arrival != "(") {
                        postFix.Add(arrival);
                        arrival = opstack.Pop(); 
                    }
                }
                else {
                    // wenn opstack priorität über aktuellen operator hat
                    if (opstack.Count != 0 && HasPriority(opstack.Peek(), c)) {
                        arrival = opstack.Pop();
                        while (HasPriority(arrival, c)) {
                            postFix.Add(arrival);
                            if (opstack.Count == 0 || opstack.Peek() == "(")
                                break;
                            arrival = opstack.Pop();
                        }
                        opstack.Push(c);
                    }
                    else
                        opstack.Push(c);
                }
            }
            return postFix;
        }

        static List<string> InfixToArray(string infix) {
            List<string> values = new List<string>();
            char last_op = '+';
            char[] operatoren = { '+', '-', '*', '/', '(', ')' };
            bool numberActive = false;
            foreach (Char c in infix) {
                // wenn ein minus nicht als operator, negative zahl, also -1 *
                if (operatoren.Contains(last_op) && c == '-') {
                    values.Add("-1");
                    values.Add("*");
                    last_op = 'x';
                    continue;
                }
                last_op = 'x';
                // Zahlen handling
                if (Char.IsNumber(c) || c == '.') {
                    // mehrstellige Zahl gefunden
                    if (numberActive) {
                        values[values.Count - 1] = values[values.Count - 1] + c.ToString();
                    }
                    // erste Stelle einer Zahl gefunden
                    else {
                        values.Add(c.ToString());
                    }
                    numberActive = true;
                    continue;
                }
                numberActive = false;

                if (operatoren.Contains(c)) {
                    last_op = c;
                    values.Add(c.ToString());
                }
            }
            return values;
        }

        static string Calc(string sNum1, string sNum2, string op) {
            double num1 = Convert.ToDouble(sNum1);
            double num2 = Convert.ToDouble(sNum2);
            double result = 0;

            switch (op) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    throw new Exception("Invalid operand detected: " + op);
            }
            return Convert.ToString(result);
        }

        static bool HasPriority(string op1, string op2) {
            IDictionary<string, int> priorities = new Dictionary<string, int> {
                ["("] = 0,
                [")"] = 0,
                ["+"] = 1,
                ["-"] = 1,
                ["*"] = 2,
                ["/"] = 2
            };
            return priorities[op1] >= priorities[op2];
        }
    }
}
