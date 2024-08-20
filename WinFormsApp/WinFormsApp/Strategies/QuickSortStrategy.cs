using WinFormsApp.Models;

namespace WinFormsApp.Strategies
{
    public class QuickSortStrategy : SortStrategy
    {
        public override string Sort(string value) => QuickSort(value);

        private static string QuickSort(string value)
        {
            if (value.Length <= 1) return value; // Base case: Already sorted

            char pivot = value[0];
            string left = string.Empty;
            string right = string.Empty;

            // Partition the string
            for (int index = 1; index < value.Length; index++)
            {
                if (value[index] <= pivot)
                {
                    left += value[index];
                    continue;
                }

                right += value[index];
            }

            // Recursively sort the sub-strings
            return QuickSort(left) + pivot + QuickSort(right);
        }
    }
}
