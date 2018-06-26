using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace calculator.core
{
    class WindowCalculator
    {
        private Button btnTwo;
        private Button btnNine;
        private Button btnAdd;
        private Button btnEquals;
        private Label lblResult;

        public WindowCalculator()
        {
            btnTwo = Calculator.GetWindow().Get<Button>(SearchCriteria.ByText("2"));
            btnNine = Calculator.GetWindow().Get<Button>(SearchCriteria.ByText("9"));
            btnEquals = Calculator.GetWindow().Get<Button>(SearchCriteria.ByText("Equals"));
            btnAdd = Calculator.GetWindow().Get<Button>(SearchCriteria.ByText("Add"));
            lblResult = Calculator.GetWindow().Get<Label>(SearchCriteria.ByText("Result"));
        }
    }
}
