using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class SpecialWordRegisterDecorator : RegisterDecorator
    {
        public SpecialWordRegisterDecorator(StringBuilderList contex) : base(contex)
        {

        }

        protected override void ModifyStringBuilderList(ref List<StringBuilder> stringBuilders)
        {
            for (int i = 0; i < stringBuilders.Count; ++i)
            {
                ToLower(stringBuilders[i], 0);
                string loverString = stringBuilders[i].ToString(0, stringBuilders[i].Length);
                if (!ApplicationLibrary.IsSpecialWorld(loverString))
                {
                    CapitilizeFirstCharacter(stringBuilders[i]);
                }
            }
        }
    }
}
