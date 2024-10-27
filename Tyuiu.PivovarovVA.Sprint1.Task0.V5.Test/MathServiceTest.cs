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
            double expected = Math.Round((1 + 2) * (1 + 9.0 / 3), 4);

            // Act
            double result = mathService.CalculateExpression();

            // Assert
            Assert.AreEqual(expected, result, "The expression result is incorrect.");
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class MathService : ISprint1Task0V5
    {
        public double CalculateExpression()
        {
            throw new NotImplementedException();
        }
    }

    internal interface ISprint1Task0V5
    {
        double CalculateExpression();
    }
}
