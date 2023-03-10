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
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            double result = findsMax.FloatNumber(26.5f, 15.5f, 35.7f);
            Assert.AreEqual(35.7f, result);
        }
    }
    public class FindMaxTestsString
    {
        FindsMaxNumber findsMax = new FindsMaxNumber();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = findsMax.String("prince", "pratik", "karan");
            Assert.AreEqual("prince", result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = findsMax.String("ajay", "pratik", "karan");
            Assert.AreEqual("pratik", result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = findsMax.String("ajay", "vishal", "karan");
            Assert.AreEqual("vishal", result);
        }
        [Test]
        public void RefactorGenericClass()
        {
            int result = findsMax.GenericClass(20, 25, 30);
            Assert.AreEqual(30, result);
        }
    }
}