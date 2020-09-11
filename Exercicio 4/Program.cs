using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada:");
            var tudo = Console.ReadLine();
            var palindromes = Palindromes(tudo);
            if (palindromes.Count>100)
            {
                Console.WriteLine("Tamanho maior que 100");
            }
            else if (palindromes.Count > 0)
            {
                palindromes.ForEach(pali => Console.WriteLine(pali));
            }

            else
            {
                Console.WriteLine("Não existem palíndromos");
            }
        }
        public static List<string> Palindromes(string word)
        {
            List<string> palindromes = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 2; j <= word.Length; j++)
                {
                    var substr = string.Empty;
                    if ((i + j) <= word.Length)
                    {
                        substr = word.Substring(i, j);
                        if (PaliResp(substr))
                        {
                            palindromes.Add(substr);
                        }
                    }
                }
            }
            return palindromes;
        }
        public static bool PaliResp(string s)
        {
            return new String(s.Reverse().ToArray()) == s;
        }
    }
}
