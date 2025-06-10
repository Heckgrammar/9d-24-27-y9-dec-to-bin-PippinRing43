using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(DenaryToBinary(210));
            //Console.WriteLine(DenaryToHex(210));
            Console.WriteLine(BinaryToDenary(0101));

        }

        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        //static string DenaryToBinary(int number)
        //{
        //    string output = "";
        //    int total = number;
        //    List<int> ints = new List<int>();
        //    while (total > 0)
        //    {
        //        ints.Add(total % 2);
        //        total /= 2;
        //    }

        //    for (int i = ints.Count-1; i >= 0; i--)
        //    {
        //        output += ints[i];
        //    }
        //    return output;
        //}

        //static string DenaryToHex(int number)
        //{
        //    string output = "";
        //    int total = number;
        //    List<int> ints = new List<int>();
        //    while (total > 0)
        //    {
        //        ints.Add(total % 16);
        //        total /= 16;
        //    }

        //    for (int i = ints.Count - 1; i >= 0; i--)
        //    {
        //        switch (ints[i])
        //        {
        //            case 10: 
        //                output += "A"; break;
        //            case 11:
        //                output += "B"; break;
        //            case 12:
        //                output += "C"; break;
        //            case 13:
        //                output += "D"; break;
        //            case 14:
        //                output += "E"; break;
        //            case 15:
        //                output += "F"; break;
        //            default:
        //                output += ints[i]; break;
        //        }
        //    }
        //    return output;
        //}

        static int BinaryToDenary(int number)
        {
            int output = 0;
            string num = Convert.ToString(number);
            int[] ints = new int[num.Length];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(num[i]);
            }
            int PowerCount = 0;

            int a;
            int b;
            int c;
            for (int i = num.Length-1; i >= 0; i--)
            {
                a = Convert.ToInt32(Math.Pow(2d, Convert.ToDouble(PowerCount)));
                c = num[i];
                b = Convert.ToInt32(c);

                output = output + (a * b);
                PowerCount++;
            }
            return output;
        }

    }
}
