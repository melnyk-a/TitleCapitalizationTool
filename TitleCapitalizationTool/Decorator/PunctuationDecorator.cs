using System;
using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class PunctuationDecorator : StringBuilderListDecorator
    {
        public PunctuationDecorator(StringBuilderList context) : base(context)
        {
        }

        protected override void ModifyStringBuilderList(IList<StringBuilder> stringBuilders)
        {
            List<StringBuilder> tempBuilders = new List<StringBuilder>();
            for (int i = 0; i < stringBuilders.Count; ++i)
            {
                for (int j = 0; j < stringBuilders[i].Length; ++j)
                {
                    char punctuationChar = stringBuilders[i][j];
                    if (ApplicationLibrary.ContainsPunctuation(punctuationChar))
                    {
                        if (stringBuilders[i].Length == 1)
                        {
                            tempBuilders[tempBuilders.Count - 1].Append(punctuationChar);
                        }
                        else
                        {
                            ExpandBuilderList(tempBuilders, stringBuilders[i],
                                punctuationChar);
                            break;
                        }
                    }
                    else if (j == stringBuilders[i].Length - 1)
                    {
                        tempBuilders.Add(stringBuilders[i]);
                    }
                }
            }
            stringBuilders.Clear();
            foreach (var item in tempBuilders)
            {
                stringBuilders.Add(item);
            }
        }

        private void ExpandBuilderList(IList<StringBuilder> expanded, StringBuilder source, char symbol)
        {
            string builderString = source.ToString(0, source.Length);
            char[] symbolArray = { symbol };
            string[] substrings = builderString.Split(symbolArray, StringSplitOptions.RemoveEmptyEntries);
            for (int k = 0; k < substrings.Length; ++k)
            {
                if (source[0] == symbol)
                {
                    expanded[expanded.Count - 1].Append(symbol);
                }
                expanded.Add(new StringBuilder(substrings[k]));
                bool isLastSubstrion = k == substrings.Length - 1;
                bool isEndWithPunctuation = builderString.EndsWith(symbol.ToString());
                if (!isLastSubstrion || isEndWithPunctuation)
                {
                    expanded[expanded.Count - 1].Append(symbol);
                }
            }
        }
    }
}