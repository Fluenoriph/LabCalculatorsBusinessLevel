//

using VentilationCalculatorData;


sealed class VentilationCalculator : FormulaTypeCalculator
{
    public VentilationCalculator(BaseVentilationCalculatorParameters parameters_object) : base(parameters_object)
    {
        double ventilation_perfomance = Parameter_values[2] * SelectAndCalculateHoleSquare(parameters_object) * FormulaConstants.SECONDS_IN_HOUR;

        double ventilation_rate = ventilation_perfomance / (Parameter_values[0] * Parameter_values[1]);

        Result_data.Add(Math.Round(ventilation_perfomance, FractionalDigits.VENTILATION_CALC));
        Result_data.Add(Math.Round(ventilation_rate, FractionalDigits.VENTILATION_CALC));
    }

    double SelectAndCalculateHoleSquare(BaseVentilationCalculatorParameters parameters_object)
    {
        if (parameters_object is CircleHoleParameters)
        {
            return (Math.PI * Math.Pow(Parameter_values[3] / FormulaConstants.TO_METER_CONVERT_INDEX, 2)) / 4;
        }
        else
        {
            return (Parameter_values[4] / FormulaConstants.TO_METER_CONVERT_INDEX) * (Parameter_values[5] / FormulaConstants.TO_METER_CONVERT_INDEX);
        }
    }
}