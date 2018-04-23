using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace TestAutomationScan3D
{

    [TestClass]
    public class CodedUITest
    {
        private StackWhiteTest test;

        [TestMethod]
        public void RunTestAutomation()
        {
            this.StackWhiteTest.ClickCamera();

        }

        public StackWhiteTest StackWhiteTest
        {
            get
            {
                if ((this.test == null))
                {
                    this.test = new StackWhiteTest();
                }
                return this.test;
            }
        }
    }
}
