using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class DashDecorator : StringBuilderListDecorator
    {
        public DashDecorator(StringBuilderList context) : base(context)
        {

        }
        //todo
        protected override void ModifyStringBuilderList(IList<StringBuilder> stringBuilders)
        {
            for (int i = 0; i < stringBuilders.Count; ++i)
            {
                for (int j = 0; j < stringBuilders[i].Length; ++j)
                {
                    char punctuationChar = stringBuilders[i][j];
                    if (punctuationChar == '-')
                    {
                        stringBuilders.Insert(i + 1, new StringBuilder("-"));
                        stringBuilders[i].Remove(j, 1);
                        ++i;
                    }
                }
            }
        }
    }
}