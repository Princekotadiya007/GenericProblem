using GenericProblems;

namespace FindsMaxUnits
{
    public class Tests
    {
        FindsMaxNumber findsMax = new FindsMaxNumber();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findsMax.IntNumber(20, 5, 10);
            Assert.AreEqual(10, result);
        }
    }
}