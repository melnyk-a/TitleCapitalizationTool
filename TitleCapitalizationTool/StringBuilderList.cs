using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal abstract class StringBuilderList
    {
        public abstract List<StringBuilder> GetStringBuilderList();
        public string GetString(List<StringBuilder> stringBuilders)
        {
            for (int i = 1; i < stringBuilders.Count; ++i)
            {
                stringBuilders[0].Append(" ");
                stringBuilders[0].Append(stringBuilders[i]);
            }
            return stringBuilders[0].ToString();
        }
    }
}