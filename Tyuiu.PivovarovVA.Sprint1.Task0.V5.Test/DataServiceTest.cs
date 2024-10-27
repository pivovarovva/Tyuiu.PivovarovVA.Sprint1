namespace ISprint1.Task0.V5.Test
{
    [TestClass]
    public class MathServiceTest
    {
        [TestMethod]
        public void TestCalculateExpression()
        {
            double expected = 12.0;
            double result = MathService.CalculateExpression();
            Assert.AreEqual(expected, result);
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class MathService
    {
        internal static double CalculateExpression()
        {
            throw new NotImplementedException();
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }
}

