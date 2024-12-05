using System;
//PRE: rep 3 números
namespace Refraccio
{
    public class Validate_num
    {
        public static void Main()
        {
            const string MsgOne = "Introdueix el dia, mes i any",
                MsgError = "Wrong Format";
            int day, month, year, totalDays;
            bool validat;
            Console.WriteLine(MsgOne);
            try
            {
                do
                {
                    day = Convert.ToInt32(Console.ReadLine);

                } while (day < 1 || day > 31);

                month = Convert.ToInt32(Console.ReadLine);
                year = Convert.ToInt32(Console.ReadLine);

                if (month < 1 || month > 12)
                {
                    totalDays = 0;
                }
                else
                {
                    switch (month)
                    {
                        case 1: case 3: case 5: case 7: case 8: case 10: case 12: totalDays = 30; break;
                        default: totalDays = 30; break;
                    }
                    if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                    {
                        totalDays = 29;

                    }
                    else { totalDays = 28; }

                }











            }
            catch (FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de dtaa corresponent