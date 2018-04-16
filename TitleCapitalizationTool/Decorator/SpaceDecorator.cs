using System;
using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class SpaceDecorator : StringBuilderListDecorator
    {
        public SpaceDecorator(StringBuilderList context) : base(context)
        {
        }

        protected override void ModifyStringBuilderList(IList<StringBuilder> stringBuilders)
        {
            List<StringBuilder> resultBuilders = new List<StringBuilder>();
            for (int i = 0; i < stringBuilders.Count; ++i)
            {
                string source = stringBuilders[i].ToString(0, stringBuilders[i].Length);
                string[] substrings = source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in substrings)
                {
                    resultBuilders.Add(new StringBuilder(item));
                }
            }
            stringBuilders.Clear();
            foreach (var item in resultBuilders)
            {
                stringBuilders.Add(item);
            }
        }
    }
}