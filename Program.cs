using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverseprogram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter String Input");
            string stringInput = Console.ReadLine();
            Console.WriteLine(stringInput.Length == 0 ? "Please enter valid input" : Program.reverseMethod(stringInput));
            Console.ReadLine();
        }

        public static string reverseMethod(string stringInput)
        {
            try
            {
                char[] stringArray = stringInput.ToCharArray();

                string reverse = String.Empty;

                for (int i = stringArray.Length - 1; i >= 0; i--)
                {
                    reverse += stringArray[i];
                }

             
                return reverse;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
