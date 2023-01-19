namespace NHLSystemTestProject
{
    [TestClass]
    public class playerTest
    {
        [TestMethod]
        [DataRow(97, "Connor McDavid", Position.C)]
        [DataRow(93, "Ryan Nugent-Hopkins", Position.C)]
        [DataRow(41, "Mike Smith", Position.G)]
        public void testMethod(int number, string name, Position position)
        {
            Player currentPlayer = new Player(number, name, position);

            Assert.AreEqual(number, currentPlayer.Number);
            Assert.AreEqual(name, currentPlayer.Name);
            Assert.AreEqual(position, currentPlayer.Position);
        }

        [TestMethod]
        [DataRow(0, "Connor McDavid", Position.C)]
        [DataRow(99, "Connor McDavid", Position.C)]
        [DataRow(-1, "Connor McDavid", Position.C)]
        [DataRow(100, "Connor McDavid", Position.C)]
        public void PlayerNo_InvalidValue_ThrowsArugmentException(int number, string name, Position position)
        {
            try
            {
                //arrange and act
                Player currentPlayer = new Player(number, name, position);
                Assert.Fail("An ArgumentException should have been thrown");
            }
            catch(ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Number can't be ");
            }
            catch(Exception ex)
            {
                Assert.Fail("Inncorrect exception type thrown");
            }
        }

        [TestMethod]
        [DataRow(97, "", Position.C)]
        [DataRow(97, "     ", Position.C)]
        [DataRow(97, "             ", Position.C)]
        public void PlayerName_InvalidValue_ThrowsArugmentNullException(int number, string name, Position position)
        {
            try
            {
                //arrange and act
                Player currentPlayer = new Player(number, name, position);
                Assert.Fail("An ArgumentNullException should have been thrown");
            }
            catch (ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, "Name cannot be blank");
            }
            catch (Exception ex)
            {
                Assert.Fail("Inncorrect exception type thrown");
            }
        }
    }
}
