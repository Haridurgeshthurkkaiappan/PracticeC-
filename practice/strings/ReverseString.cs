using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp.strings
{
   public  class ReverseString
    {
        public  ReverseString()
        {
            Console.WriteLine("enter a string to Print Reverse");
            String s = Console.ReadLine();

            string temp = String.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                temp = temp + s[i]  ;
            }
            Console.WriteLine("Reveresed string is   " + temp);

            if (temp == s)
            {
                Console.WriteLine("This string is palindrone");

            }
            else
            {
                Console.WriteLine("This string is not a palindrone");
            }
        }

    }

}




