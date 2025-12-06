//

using VentilationCalculatorData;


sealed class VentilationCalculator : FormulaTypeCalculator
{
    public VentilationCalculator(BaseVentilationCalculatorParameters parameters_object) : base(parameters_object)
    {
        double ventilation_perfomance = parameter_values[2] * SelectAndCalculateHoleSquare(parameters_object) * FormulaConstants.SECONDS_IN_HOUR;

        double ventilation_rate = ventilation_perfomance / (parameter_values[0] * parameter_values[1]);

        Result_data.Add(Math.Round(ventilation_perfomance, FractionalDigits.ONE));
        Result_data.Add(Math.Round(ventilation_rate, FractionalDigits.ONE));
    }

    double SelectAndCalculateHoleSquare(BaseVentilationCalculatorParameters parameters_object)
    {
        if (parameters_object is CircleHoleParameters)
        {
            return (Math.PI * Math.Pow(parameter_values[3] / FormulaConstants.TO_METER_CONVERT_INDEX, 2)) / 4;
        }
        else
        {
            return (parameter_values[4] / FormulaConstants.TO_METER_CONVERT_INDEX) * (parameter_values[5] / FormulaConstants.TO_METER_CONVERT_INDEX);
        }
    }
}