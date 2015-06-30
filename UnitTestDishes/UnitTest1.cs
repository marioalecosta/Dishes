using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDishes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMain()
        {
            Console.WriteLine("Input data for 'Dishes' test :");
            string testDishes = Console.ReadLine();
            Dishes.Program.execute(testDishes);
        }
    }
}
