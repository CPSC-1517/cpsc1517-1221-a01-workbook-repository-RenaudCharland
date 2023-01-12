using NHLSystemClassLibrary;

namespace NHLSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers", Conference.Western, Division.Pacific)]
        [DataRow("Flames", Conference.Western, Division.Pacific)]
        [DataRow("Canucks", Conference.Western, Division.Pacific)]
        [DataRow("Maple leafs", Conference.Eastern, Division.Atlantic)]
        [DataRow("Senators", Conference.Eastern, Division.Atlantic)]
        [DataRow("Canadiens", Conference.Eastern, Division.Atlantic)]
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