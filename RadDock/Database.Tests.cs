using NUnit.Framework;

namespace RadDock
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void IsValidProgramRows()
        {
            var db = new Database(@".\example.xml");

            Assert.AreEqual(4, db.getInfoObject().Count);
        }

        [Test]
        public void IsValidArgumentRows()
        {
            var db = new Database(@".\example.xml");

            Assert.AreEqual(3, db.getComboObject().Count);
        }
    }
}
