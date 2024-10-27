using Tyuiu.PivovarovVA.Sprint1.Task0.V5.Lib; // ���������, ��� ����������� ���������� ������������ ����

namespace Tyuiu.PivovarovVA.Sprint1.Task0.V5.Test
{
    [TestClass]
    public class MathServiceTest
    {
        [TestMethod]
        public void CalculateExpression_ReturnsCorrectResult()
        {
            ISprint1Task0V5 mathService = new MathService(); // ���������, ��� MathService ��������� ISprint1Task0V5
            double expected = 12.0;

            double result = mathService.CalculateExpression();

            Assert.That(result, Is.EqualTo(expected).Within(0.001), "�������� ��������� ���������");
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}
