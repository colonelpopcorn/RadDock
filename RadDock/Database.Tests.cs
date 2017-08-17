using NUnit.Framework;

namespace RadDock
{
    [TestFixture]
    public class DatabaseTests
    {
        private string mockXmlUri = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\example.xml";

        [Test]
        public void IsValidProgramRows()
        {
            var db = new Database(mockXmlUri);

            Assert.AreEqual(4, db.getInfoObject().Count);
        }

        [Test]
        public void IsValidArgumentRows()
        {
            var db = new Database(mockXmlUri);

            Assert.AreEqual(3, db.getComboObject().Count);
        }
    }
}
