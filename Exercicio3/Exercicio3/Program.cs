using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio3
{

    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;


        }

        public static string Change(this String str)
        {
            int wordcount = str.WordCount();
            if (wordcount == 1)
            {
                string Word = str[0].ToString().ToUpper();
                Word += str.Substring(1, str.Length - 1).ToLower();
                return Word;
            }
            else
            {
                string LastWord = str.Split()[str.Split().Length - 1];
                string FirstChar = LastWord[0].ToString().ToUpper();
                string RestOfWord = LastWord.Substring(1, LastWord.Length - 1).ToLower();


                string OtherWords = "";
                for (int i = 0; i < str.Split().Length - 1; i++)
                {
                    OtherWords += str.Split()[i][0].ToString().ToUpper() + ". ";

                }
                return OtherWords + FirstChar + RestOfWord;
            }
        }
        public static Func<T, bool> Negate<T>(this Func<T, bool> function) => t => !function(t);

    }


    class Program
    {

        public static List<int> quickSort(List<int> vetor)
        {
            int inicio = 0;
            int fim = vetor.Count - 1;

            List<int> TempList = new List<int>();

            for (int i = 0; i < vetor.Count; i++)
            {
                TempList.Add(vetor[i]);

            }

            quickSort(TempList, inicio, fim);

            return TempList;
        }

        private static void quickSort(List<int> vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }









        static void Main(string[] args)
        {
            //Exercicio 1 - A
            Console.WriteLine("Exercicio 1 - A: ");
            string[] CorrectName = { "Roberto", "Joao", "Chefe da Tribo", "Adonai", "Vitu" };
            Func<string, bool> isRoberto = x => x == "Roberto";

            var names = CorrectName.Where(isRoberto.Negate());


            foreach (string nome in names)
            {
                Console.WriteLine(nome);
            }


            //Exercicio 1 - B

            Console.WriteLine("Exercicio 1 - B: ");
            List<int> Naruto = new List<int> { 3, 1, 42, 24, 69, 420 };
            List<int> Jose(List<int> Maria) { return quickSort(Naruto); }
            List<int> Sorted = Jose(Naruto);

            foreach (int number in Sorted)
            {
                Console.WriteLine(number);
            }






            //Exercicio 2 -

            Console.WriteLine("Exercicio 2 ");
            string Roberto = "robERto";
            string RobertoEu = "roBerto henriQUE";
            string Frase = "Tres pratos de trigo para tres tigreS tristes";
          
            string R = Roberto.Change();
            string H = RobertoEu.Change();
            string F = Frase.Change();

          
            Console.WriteLine(R);
            Console.WriteLine(H);
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}

