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
    public class FindMaxTestsFloat
    {
        FindsMaxNumber findsMax = new FindsMaxNumber();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            double result = findsMax.FloatNumber(2.5f, 10.5f, 15.7f);
            Assert.AreEqual(15.7f, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            double result = findsMax.FloatNumber(20.6f, 10.5f, 15.7f);
            Assert.AreEqual(20.6f, result);
        }
    }
}