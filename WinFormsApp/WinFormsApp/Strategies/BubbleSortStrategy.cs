using WinFormsApp.Models;

namespace WinFormsApp.Strategies
{
    public class BubbleSortStrategy : SortStrategy
    {
        public override string Sort(SortDto dto)
        {
            var characters = GetCharacters(dto.Value);
            int noOfCharacters = characters.Length;

            for (int idx = 0; idx < noOfCharacters - 1; idx++)
            {
                for (int chrIdx = 0; chrIdx < noOfCharacters - idx - 1; chrIdx++)
                {
                    if (characters[chrIdx] > characters[chrIdx + 1])
                    {
                        // Swap characters
                        char temp = characters[chrIdx];
                        characters[chrIdx] = characters[chrIdx + 1];
                        characters[chrIdx + 1] = temp;
                    }
                }
            }

            return new string(characters);
        }
    }
}
