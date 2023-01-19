namespace NHLSystemTestProject
{
    [TestClass]
    public class GoalieTest
    {
        [TestMethod]
        [DataRow(41, "Mike Smith", Position.G)]
        public void GoalieNumber_InvalidValue_ThrowsArugmentException(int number, string name, Position position)
        {
            
        }
    }
}
