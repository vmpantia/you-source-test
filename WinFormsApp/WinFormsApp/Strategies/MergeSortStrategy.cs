using WinFormsApp.Models;

namespace WinFormsApp.Strategies
{
    public class MergeSortStrategy : SortStrategy
    {
        public override string Sort(string value) => MergeSort(value);

        private static string MergeSort(string value)
        {
            if (value.Length <= 1) return value; // Base case: Already sorted

            int middleIdx = value.Length / 2;
            string left = MergeSort(value.Substring(0, middleIdx));
            string right = MergeSort(value.Substring(middleIdx));

            return Merge(left, right);
        }

        private static string Merge(string left, string right)
        {
            string result = string.Empty;
            int leftIndex = 0, righIndex = 0;

            while (leftIndex < left.Length && righIndex < right.Length)
            {
                if (left[leftIndex] <= right[righIndex])
                {
                    result += left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result += right[righIndex];
                    righIndex++;
                }
            }

            // Append remaining elements from either left or right
            while (leftIndex < left.Length)
            {
                result += left[leftIndex];
                leftIndex++;
            }
            while (righIndex < right.Length)
            {
                result += right[righIndex];
                righIndex++;
            }

            return result;
        }
    }
}
