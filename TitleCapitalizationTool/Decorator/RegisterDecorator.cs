using System.Text;

namespace TitleCapitalizationTool
{
    internal abstract class RegisterDecorator : StringBuilderListDecorator
    {
        public RegisterDecorator(StringBuilderList context) : base(context)
        {

        }

        protected void CapitilizeFirstCharacter(StringBuilder word)
        {
            word[0] = char.ToUpper(word[0]);
        }
        protected void ToLower(StringBuilder word, int startIndex)
        {
            for (int i = startIndex; i < word.Length; ++i)
            {
                word[i] = char.ToLower(word[i]);
            }
        }
    }
}