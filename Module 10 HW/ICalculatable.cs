using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_HW
{
    public interface ICalculatable
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    public class SimpleCalculator : ICalculatable
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b) => b != 0 ? a / b : double.NaN;

        public void PrintResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    public class AdvancedCalculator : SimpleCalculator, ICalculatable, IStorable
    {
        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);

        public double SquareRoot(double value) => value >= 0 ? Math.Sqrt(value) : double.NaN;

        public void SaveState(string fileName)
        {
            // Реализация сохранения состояния в файл
        }

        public void LoadState(string fileName)
        {
            // Реализация загрузки состояния из файла
        }
    }

    public interface IStorable
    {
        void SaveState(string fileName);
        void LoadState(string fileName);
    }

}
