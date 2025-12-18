using SantasProgramm;

namespace Santasworkshoptests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            StandardGift testgift = new StandardGift("testname", "testdescription",1 , "blue", false );
            SleighDelivery testsleighDelivery = new SleighDelivery();
             List<BaseGift> AllGifts = new List<BaseGift>();
            Workshop testworkshop = new Workshop(testsleighDelivery);
            int expected = AllGifts.Count + 1;


            //Act
            testworkshop.AllGifts.Add(testgift);

            //Assert
            Assert.AreEqual(AllGifts.Count, expected);
        }
    }
}
