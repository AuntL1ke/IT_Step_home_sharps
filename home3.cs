using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME
{
    internal class home3
    {

        static int[][] CreateJugged(int row, int start_col, int step = 0)
        {
            int[][] tmp = new int[row][];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = new int[start_col++];
                start_col += step;
            }
            return tmp;
        }
        static void printJugged(int[][] arr, string prompt = "")
        {
            Console.WriteLine(prompt);

            foreach (var line in arr)
            {
                foreach (var item in line)
                {
                    Console.Write($"{item,7}");
                }
                Console.WriteLine();
            }
        }
        static void FillRand(int[][] arr, int min = 1, int max = 25)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(min, max + 1);
                }


            }
        }
        static void SwapUp(int[][] arr, int times)
        {

            for (int i = 0; i < times % arr.Length; i++)
            {
                int[] tmp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];

                }
                arr[arr.Length - 1] = tmp;
            }
        }
        static void SwapDown(int[][] arr, int times)
        {

            for (int i = 0; i < times % arr.Length; i++)
            {
                int[] tmp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];

                }
                arr[0] = tmp;
            }
        }
        static void deleteByindex(ref int[][] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1].ToArray();
                }

                Array.Resize(ref arr, arr.Length - 1);
            }
            else
            {
                Console.WriteLine("Error: Invalid index.");
            }
        }

        static void AddRow(ref int[][] arr, params int[] newRow)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = newRow;
        }
        static int FindMax(int[][] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i].Max();
            }
            return newArr.Max();
        }
        static int[,,] CreateArray(int x, int y, int z)
        {
            int[,,] array = new int[x, y, z];
            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        array[i, j, k] = random.Next(1, 101);
                    }
                }
            }
            return array;

        }

        static void Display(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine($"{array[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void SumOfArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        sum += array[i, j, k];
                    }
                }
                Console.WriteLine($"Sum of elements for subarray {i + 1}: {sum}");
            }
        }
        static string RemoveCharacters(string input, params char[] charactersToRemove)
        {
            foreach (char character in charactersToRemove)
            {
                input = input.Replace(character.ToString(), string.Empty);
            }

            return input;
        }
        static void Main(string[] args)
        {
            /* int[][] mas = CreateJugged(5, 4, 2);
             FillRand(mas);
             printJugged(mas);
             Console.WriteLine();
             deleteByindex(ref mas, 2);
             printJugged(mas);
             Console.WriteLine("Max");
             Console.WriteLine(FindMax(mas));*/

            /* Console.Write("Input a text string :: ");
             string text = Console.ReadLine();

             Console.Write("Input a symbol in text :: ");
             string symb = Console.ReadLine();

             if (text.Contains(symb) && symb.Length == 1)
             {
                 int lastIndex = -1;

                 for (int i = 0; i < text.Length; i++)
                 {
                     if (text[i] == symb[0])
                     {
                         lastIndex = i;

                         text = text.Remove(i, 1).Insert(i, symb.ToUpper());
                     }
                 }

                 if (lastIndex != -1)
                 {
                     text = text.Substring(0, lastIndex + 1);
                 }

                 Console.WriteLine(text);
             }
             else
             {
                 Console.WriteLine("Invalid input. Please make sure the symbol is a single character and exists in the text.");
             }*/
            /*  Console.Write("Input a text string :: ");
              string inputText = Console.ReadLine();

              Console.Write("Input characters to remove (separated by spaces) :: ");
              string charactersToRemoveInput = Console.ReadLine();

              char[] charactersToRemove = charactersToRemoveInput.Split(' ').Select(char.Parse).ToArray();

              string result = RemoveCharacters(inputText, charactersToRemove);
              Console.WriteLine("Result: " + result);*/

            string sentence = "I don’t know whether to delete this or rewrite it";
            string filter = new string(sentence.ToLower().Where(char.IsLetter).ToArray());
            for(char letter = 'a'; letter <= 'z'; letter++)
            {
                int count = filter.Count(c => c == letter);
                if(count>0)
                {
                    Console.WriteLine($"{letter} [{count}] {new string('*', count)}");
                }
            }

        }
    }   
}