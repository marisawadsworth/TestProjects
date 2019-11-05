using BaseProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTest
{
    [TestClass]
    public class UnitPerson
    {
        [TestMethod]
        public void testGreetingMethodToSayHelloToPerson()
        {
            Person p = new Person("Stephen", "Doe");
            string result = p.Greeting();
            Assert.AreEqual(result, $"Hello {p.Fname} {p.Lname}");
        }

        [TestMethod]
        public void testGreetingMethodToSayHelloToSteven()
        {
            Person p = new Person("Steven", "Doe");
            string result = p.Greeting();
            Assert.AreEqual(result, $"Hello Steven Doe");
        }

        [TestMethod]
        public void testThatPersonCanHaveABirthday()
        {
            Person p = new Person("Stephen", "Doe", 34);
            bool result = p.HasBirthday() == p.Age + 1;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void testTheSumOf2Numbers()
        {
            SimpleCalculation sc = new SimpleCalculation();
            int result = sc.SumofTwoNumbers(6, 4);
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void testTheProductOf2Numbers()
        {
            SimpleCalculation sc = new SimpleCalculation();
            int result = sc.ProductOfTwoNumbers(6, 4);
            Assert.AreEqual(result, 24);
        }

        [TestMethod]
        public void testTheSubstractionOf2Numbers()
        {
            SimpleCalculation sc = new SimpleCalculation();
            int result = sc.SubstractOfTwoNumbers(6, 4);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void testTheDivsionOf2Numbers()
        {
            SimpleCalculation sc = new SimpleCalculation();
            double result = sc.DivisionOfTwoNumbers(6, 3);
            Assert.AreEqual(result, 2);
        }
    }
}