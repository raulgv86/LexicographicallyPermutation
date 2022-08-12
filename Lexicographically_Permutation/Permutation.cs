using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicographically_Permutation
{
    public class Permutation
    {
        private static Permutation _permutation = null;
        private string vector_result = "";

        public Permutation()
        {
            
        }

        public static Permutation Permutate
        {
            get 
            {
                if (_permutation == null)
                {
                    _permutation = new Permutation();
                }
                return _permutation;
            }
        
        }

        public string next_lexicographic(string input)
        {
            char[] array = input.ToCharArray();
            int length = array.Length;

            for (int i = length - 1; i > 0; i--)
            {
                char num = array[i];

                if (num.CompareTo(array[i - 1]) < 0)
                    continue;

                char anterior = array[i - 1];
                int posicion = i;

                for (int j = i + 1; j < length; j++)
                {
                    char temporal = array[j];

                    if (temporal.CompareTo(num) < 0 && temporal.CompareTo(anterior) > 0)
                    {
                        num = temporal;
                        posicion = j;
                    }
                }

                array[posicion] = anterior;
                array[i - 1] = num;

                for (int j = length - 1; j > i; j--, i++)
                {
                    char temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;

                }

                break;
            }

            //String resultado = new String(array);
            vector_result = new String(array);
            if (vector_result == input)
            {
                char[] prueba = vector_result.ToCharArray();
                Array.Sort(prueba);
                vector_result = new String(prueba);
            }

            return vector_result;
        }
    }
}
