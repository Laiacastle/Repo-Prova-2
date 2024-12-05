using System;
using Prova;
namespace ExerciciDos
{
    public class ExerciciDos
    {
        public static void Main()
        {
            const string MsgOne = "Write a number to search, please",
                MsgFormatError = "Wrong Format",
                MsgEnd = "The number is in the position {1}";
            int[] list = new int[] {10, -4, 6, 4, 8, 13, 2, -4 };
            int response;

            Console.WriteLine(MsgOne);
            try
            {
                
                int num = Convert.ToInt32(Console.ReadLine());
                int num2 = list.Length - 1;
                FirstSort.Order(list, list[0], list[list.Length-1]);
                for (int i = 0; i < list.Length; i++)
                {

                    Console.WriteLine(list[i]);
                }
                response = SearchClass.BinarySearch(list, list[0], list[list.Length - 1], num);
                Console.WriteLine(MsgEnd, response);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatError);
            }
            
        }
    }
}