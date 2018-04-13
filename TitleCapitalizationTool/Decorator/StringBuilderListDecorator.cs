using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal abstract class StringBuilderListDecorator : StringBuilderList
    {
        private StringBuilderList _stringBuilderList;

        public StringBuilderListDecorator(StringBuilderList context)
        {
            _stringBuilderList = context;
        }

        protected abstract void ModifyStringBuilderList(ref List<StringBuilder> stringBuilders);
        public override List<StringBuilder> GetStringBuilderList()
        {
            var innerStringBuilder = _stringBuilderList.GetStringBuilderList();
            ModifyStringBuilderList(ref innerStringBuilder);
            return innerStringBuilder;
        }
    }
}