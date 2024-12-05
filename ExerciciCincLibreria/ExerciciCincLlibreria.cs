namespace ExerciciCincLibreria
{
    public class Cinc
    {
        public static void Order(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1 + i; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }
        }
        public static bool Search(int[] nums, int key)
        {
            return nums.Contains(key);
        }
    }
}
