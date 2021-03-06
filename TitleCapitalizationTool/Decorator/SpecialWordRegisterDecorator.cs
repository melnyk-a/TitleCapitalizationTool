﻿using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationTool
{
    internal class SpecialWordRegisterDecorator : RegisterDecorator
    {
        public SpecialWordRegisterDecorator(StringBuilderList context) : base(context)
        {
        }

        protected override void ModifyStringBuilderList(IList<StringBuilder> stringBuilders)
        {
            for (int i = 0; i < stringBuilders.Count; ++i)
            {
                ToLower(stringBuilders[i], 0);
                string lowerString = stringBuilders[i].ToString(0, stringBuilders[i].Length);
                if (!ApplicationLibrary.IsSpecialWorld(lowerString))
                {
                    CapitilizeFirstCharacter(stringBuilders[i]);
                }
            }
        }
    }
}