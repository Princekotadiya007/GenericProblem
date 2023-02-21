using GenericProblems;

namespace FindsMaxUnits
{
    public class FindMaxTestsInt
    {
        FindsMaxNumber findsMax = new FindsMaxNumber();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findsMax.IntNumber(20, 5, 10);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findsMax.IntNumber(15, 2, 12);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findsMax.IntNumber(28, 12, 22);
            Assert.AreEqual(28, result);
        }
    }
}