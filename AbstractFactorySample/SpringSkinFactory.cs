using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SpringSkinFactory :ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
        
        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }
    }
}
