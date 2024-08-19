using WinFormsApp.Models;

namespace WinFormsApp.Strategies
{
    public abstract class SortStrategy
    {
        public abstract string Sort(SortDto dto);

        public char[] GetCharacters(string value) => value.ToCharArray();
    }
}
