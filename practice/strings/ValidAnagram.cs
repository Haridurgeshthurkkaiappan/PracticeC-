using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp.strings
{
    public class ValidAnagram
    {
        public ValidAnagram()
        {
            Console.WriteLine("enter a first string ");
            String a = Console.ReadLine();
            
            
           Console.WriteLine("enter a second string ");
            String b = Console.ReadLine();
            a = a.ToLower();
            b = b.ToLower();


            if (a.Length!= b.Length)
            {
                Console.WriteLine("The entered strings are not Anagram");
            }
            else
            {
                char[] c = a.ToCharArray();
                char[] d = b.ToCharArray();

                Array.Sort(c);
                Array.Sort(d);

                if (!(c==d))
                {
                    Console.WriteLine("The entered strings are Anagram");
                }

                else
                {
                    Console.WriteLine("The entered strings are not Anagram");
                }

            }
        }
    }


}
