using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;

namespace calculator.core
{
    class CommonUtils
    {
        public static void ClickButton(Button button) {
            button.Click();
        }

        public static String GetText(Label label) {
            return label.Text;
        }
    }
}
