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

        protected override void ModifyStringBuilderList(ref List<StringBuilder> stringBuilders)
        {
            List<StringBuilder> tempBuilders = new List<StringBuilder>();
            for (int i = 0; i < stringBuilders.Count; ++i)
            {
                string str = stringBuilders[i].ToString(0, stringBuilders[i].Length);
                string[] substrings = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in substrings)
                {
                    tempBuilders.Add(new StringBuilder(item));
                }
            }
            stringBuilders = tempBuilders;
        }
    }
}