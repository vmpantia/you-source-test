using WinFormsApp.Strategies;

namespace WinFormsApp.Tests.Strategies
{
    public class StrategyTest
    {
        public static TheoryData<string, string> StringTestData => new TheoryData<string, string>
        {
            { "hello", "ehllo" },
            { "world", "dlorw" },
            { "banana", "aaabnn" },
            { "mississippi", "iiiimppssss" },
            { "aabbcc", "aabbcc" },
            { "this is a test string.", "    .aeghiiinrsssstttt" },
            { "the quick brown fox jumps over the lazy dog.", "        .abcdeeefghhijklmnoooopqrrsttuuvwxyz" }
        };

        [Theory]
        [MemberData(nameof(StringTestData))]
        public void BubbleSort_Test_Sorted_Result(string value, string expected)
        {
            // Arrange
            SortStrategy strategy = new BubbleSortStrategy();

            // Act
            var actual = strategy.Sort(value);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(StringTestData))]
        public void MergeSort_Test_Sorted_Result(string value, string expected)
        {
            // Arrange
            SortStrategy strategy = new BubbleSortStrategy();

            // Act
            var actual = strategy.Sort(value);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(StringTestData))]
        public void QuickSort_Test_Sorted_Result(string value, string expected)
        {
            // Arrange
            SortStrategy strategy = new BubbleSortStrategy();

            // Act
            var actual = strategy.Sort(value);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
