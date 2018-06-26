using NUnit.Framework;
using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace calculator
{
    [TestFixture]
    public class TestClass
    {
        private Application application;

        [SetUp]
        public void setUp()
        {
            string ApplicationPath = @"C:\Windows\system32\calc1.exe";
            application = Application.Launch(ApplicationPath);

        }

        [Test]
        public void AddTwoNumbers() {
            Window mainWindow = application.GetWindow("Calculator");
            Button btnTwo = mainWindow.Get<Button>(SearchCriteria.ByText("2"));
            btnTwo.Click();
            Button btnPlus = mainWindow.Get<Button>(SearchCriteria.ByText("Add"));
            btnPlus.Click();
            Button btnNine = mainWindow.Get<Button>(SearchCriteria.ByText("9"));
            btnNine.Click();
            Button btnEquals = mainWindow.Get<Button>(SearchCriteria.ByText("Equals"));
            btnEquals.Click();
            Label lblResult = mainWindow.Get<Label>(SearchCriteria.ByAutomationId("150"));
            Assert.AreEqual("11", lblResult.Text);
        }

        [TearDown]
        public void TearDown() {
            application.Close();
        }
    }
}
