using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class FirsAndLastRegisterDecorator : RegisterDecorator
    {
        public FirsAndLastRegisterDecorator(StringBuilderList context) : base(context)
        {

        }

        protected override void ModifyStringBuilderList(ref List<StringBuilder> stringBuilders)
        {
            CapitilizeFirstCharacter(stringBuilders[0]);
            CapitilizeFirstCharacter(stringBuilders[stringBuilders.Count - 1]);
        }
    }
}
