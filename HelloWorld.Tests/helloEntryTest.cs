using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace HelloWorld.Tests
{
    [TestClass]
    public class helloEntryTest
    {
        private string consoleResText;
        [TestInitialize]
        public void Initialize()
        {
            var _write = new System.IO.StringWriter();
            Console.SetOut(_write);
            Program.Main(new string[0]);
            consoleResText = _write.GetStringBuilder().ToString().Trim();
        }
        [TestMethod]
        public void SaysHelloWorld()
        {
            Assert.AreEqual("Hello, world!", consoleResText);
        }

    }
}
