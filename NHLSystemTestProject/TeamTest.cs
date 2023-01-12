using NHLSystemClassLibrary;

namespace NHLSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers")]
        [DataRow("Flames")]
        [DataRow("Canucks")]
        [DataRow("Maple leafs")]
        [DataRow("Senators")]
        [DataRow("Canadiens")]
        public void Name_ValidName_NameSet(string teamName)
        {
            //arrange
            //act
            Team currentTeam = new Team(teamName);
            //assert
            Assert.AreEqual(teamName, currentTeam.Name);
        }

        [TestMethod]
        //[DataRow(null,"Invalid input for name")]
        [DataRow("","Invalid input for name")]
        [DataRow("     ", "Invalid input for name")]
        public void Name_InvalidName_ThrowsArugmentNullException(string teamName, string exceptedErrorMessage)
        {
            try
            {
                Team currentTeam = new Team(teamName);
                Assert.Fail("An ArugmentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, exceptedErrorMessage);
            }
        }
    }
}