namespace Tyuiu.PivovarovVA.Sprint1.Task0.V5.Lib
{
    public class MathService : ISprint1Task0V5
    {
        public double CalculateExpression()
        {
            double result = (1 + 2) * (1 + 9.0 / 3); // 1+2 = 3, 9/3 = 3, 1+3 = 4, 3*4 = 12
            return result;
        }
    }
}
