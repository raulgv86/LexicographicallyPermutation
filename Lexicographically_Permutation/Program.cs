using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lexicographically_Permutation
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type the sequence to find the next lexicographically permutation:");

            string input = Console.ReadLine();
            char[] inVec = input.ToCharArray();

            Console.WriteLine("Input: [" + string.Join(",", inVec) + "]");
            
            string outVec = Permutation.Permutate.next_lexicographic(input);
            
            Console.WriteLine("Ouput: [" + string.Join(",", outVec.ToArray()) + "]");
            Console.ReadKey(true);
        }
    }
}
