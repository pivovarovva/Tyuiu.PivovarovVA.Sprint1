namespace Tyuiu.PivovarovVA.Sprint1.Task0.V5.Lib
{
    public class MathService : ISprint1Task0V5
    {
        public double CalculateExpression()
        {
            // Четкое выполнение операции с точностью до двух десятичных
            double result = (1 + 2) * (1 + 9.0 / 3);
            return Math.Round(result, 2); // округление до 2 знаков, чтобы избежать проблем с точностью
        }
    }
}
