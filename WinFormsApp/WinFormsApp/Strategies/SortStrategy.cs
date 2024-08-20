using WinFormsApp.Models;

namespace WinFormsApp.Strategies
{
    public abstract class SortStrategy
    {
        public abstract string Sort(string value);

        public char[] GetCharacters(string value) => value.ToCharArray();
    }
}
