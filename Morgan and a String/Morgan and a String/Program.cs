using System;
using System.Linq;

namespace Morgan_and_a_String
{
    class Program
    {
        static string morganAndString(string a, string b)
        {
            string result = "";
            
            char[] av = a.ToCharArray();
            char[] bv = b.ToCharArray();

            int avi = 0;
            int bvi = 0;

            while ((avi < av.Length) || (bvi < bv.Length))
            {
                if ((avi < av.Length) && (bvi < bv.Length))
                {
                    if(av[avi]<= bv[bvi])
                    {
                        //result = result + av[avi];
                        result.Concat(av[avi].ToString());
                        avi++;
                    }
                    else
                    {
                        //result = result + bv[bvi];
                        result.Concat(bv[bvi].ToString());
                        bvi++;
                    }
                }
                else
                {
                    if (avi < av.Length)
                    {
                        //result = result + av[avi];
                        result.Concat(av[avi].ToString());
                        avi++;
                    }
                    else if (bvi < bv.Length)
                    {
                        //result = result + bv[bvi];
                        result.Concat(bv[bvi].ToString());
                        bvi++;
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string result = morganAndString(a, b);

                Console.WriteLine("Output:");
                Console.WriteLine(result);

                Console.ReadKey();
            }
        }
    }
}
