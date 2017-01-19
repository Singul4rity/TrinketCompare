using System.Data;
using NUnit.Framework;
using TrinketCompare.Core.DataAccess;

namespace TrinketCompare.Tests
{
    [TestFixture]
    public class DataAccessTests
    {
        [Test]
        public void Existing_Trinket_List_CanBeRead()
        {
            var _reader = new DataReader();
            Assert.NotNull(_reader);
        }
    }
}
