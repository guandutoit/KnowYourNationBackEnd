using Know_Your_Nation_Speedy;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private KYNSDemo kyns;
      
        [SetUp]
        public void Setup()
        {
            kyns = new KYNSDemo();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TestCase("Mpilo","Shakes")]
        public void Test(string name,string outcome)
        {
            //assign
            //act
            var result = kyns.SpeedysFriend(name);
            //assert
            Assert.AreEqual(name, outcome);
        }
    }
}