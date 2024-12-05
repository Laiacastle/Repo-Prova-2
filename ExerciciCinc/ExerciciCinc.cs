using System;
using ExerciciCincLibreria;
namespace ExerciciCinc
{
    public class ExerciciCinc
    {
        
        public static void Main()
        {
            const string MsgOne = "Write 20 numbers please",
                MsgEnd = "The numbers ordereds are: ",
                MsgError = "Wrong Format",
                
                MsgS = "Write a number to search",
                MsgSearch = "The number is {0}in the list";
            int num;
            int[] nums = new int[20];
            string res;

            Console.WriteLine(MsgOne);
            try
            {
                for(int i = 0; i< nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                Cinc.Order(nums);
                Console.WriteLine(MsgEnd);
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
                Console.WriteLine($"\n{MsgS}");
                num = Convert.ToInt32(Console.ReadLine());
                if (Cinc.Search(nums, num)) { res = ""; } else{ res = "not "; }
                Console.WriteLine(MsgSearch, res);

            }catch(FormatException) { Console.WriteLine(MsgError); }
        }
    }
}