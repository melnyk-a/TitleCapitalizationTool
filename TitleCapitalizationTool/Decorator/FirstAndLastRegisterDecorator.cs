using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class FirstAndLastRegisterDecorator : RegisterDecorator
    {
        public FirstAndLastRegisterDecorator(StringBuilderList context) : base(context)
        {

        }

        protected override void ModifyStringBuilderList(ref IList<StringBuilder> stringBuilders)
        {
            CapitilizeFirstCharacter(stringBuilders[0]);
            CapitilizeFirstCharacter(stringBuilders[stringBuilders.Count - 1]);
        }
    }
}