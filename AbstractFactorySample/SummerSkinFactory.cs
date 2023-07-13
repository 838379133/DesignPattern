using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SummerSkinFactory :ISkinFactory
    {     
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }

        public IComboBox CreateComboBox()
        {
                return new SummerComboBox();
        }
    }
}
