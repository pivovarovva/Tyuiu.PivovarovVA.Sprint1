namespace Tyuiu.PivovarovVA.Sprint1.Task0.V5.Test
{
    [TestClass]
    public class MathServiceTest
    {
        [TestMethod]
        public void CalculateExpression_ReturnsCorrectResult()
        {
            // Arrange
            ISprint1Task0V5 mathService = new MathService();
            double expected = (1 + 2) * (1 + 9.0 / 3);

            // Act
            double result = mathService.CalculateExpression();

            // Assert
            Assert.AreEqual(expected, result, 0.0001, "The expression result is incorrect.");
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class MathService : ISprint1Task0V5
    {
        public double CalculateExpression()
        {
            throw new NotImplementedException();
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal interface ISprint1Task0V5
    {
        double CalculateExpression();
    }
}

