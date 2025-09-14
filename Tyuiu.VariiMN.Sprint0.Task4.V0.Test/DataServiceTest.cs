using Tyuiu.VariiMN.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VariiMN.Sprint0.Task4.V0.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedAdditionValid()
        {
            Assert.Pass();
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}