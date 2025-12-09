// * Файл "DustCalcsParameters.cs": входные параметры для калькуляторов по пыли (идентичны). *
// Объем пробы воздуха, температура в месте отбора, давление, масса чистого фильтра, масса фильтра с пылью.

sealed class DustCalcsParameters : FormulaTypeCalculatorParameters
{
    public DustCalcsParameters(double volume, double temperature, double pressure, double filter_weight_1, double filter_weight_2)
    {
        Values.Add(volume); Values.Add(temperature); Values.Add(pressure); Values.Add(filter_weight_1); Values.Add(filter_weight_2);
    }
}
