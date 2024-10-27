namespace Tyuiu.PivovarovVA.Sprint1.Task0.V5.Lib
{
    public class MathService : ISprint1Task0V5
    {
        public double CalculateExpression()
        {
            double result = (1 + 2) * (1 + 9.0 / 3);
            return Math.Round(result, 4); // округление до 4 знаков
        }
    }
}
