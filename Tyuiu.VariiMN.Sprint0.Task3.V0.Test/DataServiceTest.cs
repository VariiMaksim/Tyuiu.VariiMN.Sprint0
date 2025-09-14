using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Interfaces;

using Tyuiu.VariiMN.Sprint0.Task3.V0.Lib;

namespace Tyuiu.VariiMN.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.sum(5, 5));
        }
    }
}