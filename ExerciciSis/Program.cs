using System;
using System.Diagnostics.Contracts;
using ExerciciSisLibrary;
namespace ExerciciCinc
{
    public class ExercicicCinc { 
       

    public static void Main()
    {
            int num;
            try
            {
                do {
                    num = Convert.ToInt32(Console.ReadLine());
                        } while (num < 5 || num > 12);

                char[] contra = new char[num];

                for (int i = 0; i < contra.Length; i++)
                {
                    contra[i] = Convert.ToChar(Console.ReadLine());
                }

                Utils.NumsStartEnd(contra);
                Utils.CharCompruve(contra);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
            
    }
}
}