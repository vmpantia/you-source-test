using WinFormsApp.Models;
using WinFormsApp.Models.Enums;
using WinFormsApp.Strategies;

namespace WinFormsApp.Controllers
{
    public class SortController
    {
        private readonly Dictionary<SortType, SortStrategy> _sortStrategies;
        public SortController()
        {
            // Prepare strategies
            _sortStrategies = new Dictionary<SortType, SortStrategy>
            {
                { SortType.BubbleSort, new BubbleSortStrategy() },
                { SortType.QuickSort, new QuickSortStrategy() },
                { SortType.MergeSort, new MergeSortStrategy() },
            };
        }

        public string ProcessSort(SortDto dto)
        {
            var result = string.Empty;

            // Get strategy to be used for sorting
            var strategy = _sortStrategies.GetValueOrDefault(dto.Type);

            // Check if any strategy found on the selected type
            if (strategy is SortStrategy) result = strategy.Sort(dto);

            return result;
        }
    }
}
