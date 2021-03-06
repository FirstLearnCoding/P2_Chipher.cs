using System;

namespace P2_Chipher
{
    class P2_Chipher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String LIne");
            string sentance = Console.ReadLine();
            string resolvestring = workFunction(sentance);
            Console.WriteLine(resolvestring);
            Console.WriteLine();
        }
        public static string workFunction(string data)
        {
            string resolvedata = "";
            foreach(char c in data)
            {
                if (c == ' ')
                {
                    resolvedata = resolvedata + '$';
                }
                else if (c == 'r'||c == 'R')
                {
                    resolvedata = resolvedata + '3';
                }
                else if(c=='t' || c== 'T')
                {
                    resolvedata = resolvedata + '5';
                }
                else if(c=='e' || c == 'E')
                {
                    resolvedata = resolvedata + '8';
                }
                else if (c == 'a' || c == 'A')
                {
                    resolvedata = resolvedata + '2';
                }
                else if (c == 'b' || c == 'B')
                {
                    resolvedata = resolvedata + '&';
                }
                else if (c == 'f' || c == 'F')
                {
                    resolvedata = resolvedata + "34";
                   // resolvedata = resolvedata + '4';
                }
                else if (c == 'v' || c == 'V')
                {
                    resolvedata = resolvedata + '#';
                }
                else if (c == 'c' || c == 'C')
                {
                    resolvedata = resolvedata + "29";
                    //resolvedata = resolvedata + '9';
                }
                else
                {
                    resolvedata = resolvedata + "999";
                }


            }
            return resolvedata;
        }
    }
}
