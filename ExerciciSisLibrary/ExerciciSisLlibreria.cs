namespace ExerciciSisLibrary
{
    public class Utils
    {
        public static bool NumsStartEnd(char[] contra)
        {
            try
            {
                Convert.ToInt32(contra[0]);
                Convert.ToInt32(contra[contra.Length - 1]);
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        public static bool CharCompruve(char[] contra)
        {
            return contra.Length > 5 || contra.Length < 12;
        }

    }
}
