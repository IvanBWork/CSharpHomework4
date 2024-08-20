namespace CSharpHomework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 27;

            Console.WriteLine($"Искомое число: {target}");
            NumberSearch(arr, target);
        }

        public static void NumberSearch(int[] array, int target)
        {
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;

                while (left < right)
                {
                    int summ = array[i] + array[left] + array[right];
                    if (target == summ)
                    {
                        Console.WriteLine($"{array[i]} + {array[left]} + {array[right]} = {target}");
                        left++;
                    }
                    else if (summ < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }
    }
}
