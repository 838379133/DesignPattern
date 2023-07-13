using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    interface ISkinFactory
    {
        IButton CreateButton();
        ITextField CreateTextField();
        IComboBox CreateComboBox();
    }
}
