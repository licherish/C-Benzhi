namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_08
{
    using System;
    using Listing12_04;

    public class DelegateSample
    {
        public static void BubbleSort(
            int[] items, ComparisonHandler comparisonMethod)
        {
            int i;
            int j;
            int temp;

            if(items == null)
            {
                return;
            }
            if(comparisonMethod == null)
            {
                throw new ArgumentNullException("comparisonMethod");
            }

            for(i = items.Length - 1; i >= 0; i--)
            {
                for(j = 1; j <= i; j++)
                {
                    if(comparisonMethod(items[j - 1], items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        public static bool GreaterThan(int first, int second)
        {
            return first > second;
        }

        public static void Main()
        {
            int i;
            int[] items = new int[100];
            Random random = new Random();

            for(i = 0; i < items.Length; i++)
            {
                items[i] = random.Next(int.MinValue, int.MaxValue);
            }

            BubbleSort(items,
                new ComparisonHandler(GreaterThan));

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}