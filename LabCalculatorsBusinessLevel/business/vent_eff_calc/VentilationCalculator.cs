// * Файл "VentilationCalculator.cs": реализация калькулятора по вентиляции. *

using VentilationCalculatorData;
using MainData;


sealed class VentilationCalculator : FormulaTypeCalculator
{
    public VentilationCalculator(BaseVentilationCalculatorParameters parameters_object) : base(parameters_object)
    {
        // МР 4.3.0212-20 "Контроль систем вентиляции".
        // Производительность вентиляции = скорость воздуха * площадь отверстия * 3600 сек.

        double ventilation_perfomance = parameter_values[2] * SelectAndCalculateHoleSquare(parameters_object) * FormulaConstants.SECONDS_IN_HOUR;

        // Кратность воздухообмена = производительность / объем помещения.

        double ventilation_rate = ventilation_perfomance / (parameter_values[0] * parameter_values[1]);

        Result_data.Add(Math.Round(ventilation_perfomance, FractionalDigits.ONE));
        Result_data.Add(Math.Round(ventilation_rate, FractionalDigits.ONE));
    }

    // Вычисление площади вентиляционного отверстия, в зависимости от типа параметров.

    double SelectAndCalculateHoleSquare(BaseVentilationCalculatorParameters parameters_object)
    {
        // Площадь окружности. 

        if (parameters_object is CircleHoleParameters)
        {
            return (Math.PI * Math.Pow(parameter_values[3] / FormulaConstants.TO_METER_CONVERT_INDEX, 2)) / 4;
        }

        // Площадь прямоугольника.

        else
        {
            return (parameter_values[3] / FormulaConstants.TO_METER_CONVERT_INDEX) * (parameter_values[4] / FormulaConstants.TO_METER_CONVERT_INDEX);
        }
    }
}