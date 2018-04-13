using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal abstract class StringBuilderList
    {
        public abstract IList<StringBuilder> GetStringBuilderList();

        public string GetString(IEnumerable<StringBuilder> stringBuilders)
        {
            StringBuilder result = new StringBuilder();
            foreach(var item in stringBuilders)
            {
                result.Append(" ");
                result.Append(item);
            }
            
            return result.ToString();
        }
    }
}