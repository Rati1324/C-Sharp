using System;

namespace Tasks
{
    
    public static class Task_4
    {
   
        //task_1_20
        public static float higher_than_b(float[] arr, float b)
        {
            float sum = 0;
            foreach (var i in arr) sum += i > b ? 1 : 0;
            return sum;
        }

        //task_1_16
        public static int even_nums(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr) sum += i % 2 == 0 ? i : 0;
            return sum;
        }

        //task_1_17
        public static float largest_negative(float[] arr)
        {
            int max = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    if (arr[max] >= 0 || arr[max] < arr[i]) max = i;
                }
            }
            return max;
        }

        // task_1_22
        public static float nums_in_array_range(float[] arr, float n1, float n2)
        {
            int sum = 0;
            bool check = false;

            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == n2) break;
                if (check) sum++;
                else if (arr[i] == n1) check = true;
            }
            return sum;
        }

        
        public static float diagonal(float[,] x)
        {
            int len = x.GetLength(0);
            float sum = 0;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (j < len - i - 1) sum += x[i, j];
                }
            }
            return sum;
        }
    }
}
