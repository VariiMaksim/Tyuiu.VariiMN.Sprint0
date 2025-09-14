using Tyuiu.VariiMN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VariiMN.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            Assert.Pass();
            var name = "Максим";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Максим", res);
        }
    }
}