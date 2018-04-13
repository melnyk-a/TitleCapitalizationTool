using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class DefaultStringBuilderList : StringBuilderList
    {
        private List<StringBuilder> _stringBuilders = new List<StringBuilder>();

        public DefaultStringBuilderList(string context)
        {
            _stringBuilders.Add(new StringBuilder(context));
        }

        public override IList<StringBuilder> GetStringBuilderList()
        {
            return _stringBuilders;
        }
    }
}