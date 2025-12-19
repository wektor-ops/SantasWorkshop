using SantasProgramm;

namespace Santasworkshoptests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Checkifgiftwasadded()
        {
            //Arange
            StandardGift testgift = new StandardGift("testname", "testdescription", 1, false);
            SleighDelivery testsleighDelivery = new SleighDelivery();
            Workshop testworkshop = new Workshop(testsleighDelivery);
            int expected = Workshop.AllGifts.Count + 1;


            //Act
            Workshop.AllGifts.Add(testgift);

            //Assert
            Assert.AreEqual(Workshop.AllGifts.Count, expected);
        }
        [TestMethod]
        public void hastheelfreceivedanewtask()
        {
            //Arange
            Elf jegor = new Elf("egor", "");
            string expected = jegor.Task;

            //Act
            jegor.GiveNewTask("Teddy Geschenk Herstellen");
            //Assert
            Assert.AreNotEqual(expected, jegor.Task, "Nicht funktioniert");
        }
    }
}
