// Входные параметры для калькуляторов по пыли (идентичны). Список для использования в других классах.

sealed class DustCalcsParameters : FormulaTypeCalculatorParameters
{
    public DustCalcsParameters(double volume, double temperature, double pressure, double filter_weight_1, double filter_weight_2)
    {
        Values.Add(volume); Values.Add(temperature); Values.Add(pressure); Values.Add(filter_weight_1); Values.Add(filter_weight_2);
    }
}
