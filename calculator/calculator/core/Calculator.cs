using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace calculator.core
{
    class Calculator
    {
        public Calculator() {            
        }

        public static Window GetWindow() {
            Application application = Application.Launch(@"C:\Windows\system32\calc1.exe");
            return application.GetWindow("Calculator");
        } 
    }
}
