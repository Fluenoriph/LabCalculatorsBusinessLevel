// Входные параметры для калькуляторов по пыли (идентичны). Список для использования в других классах.

readonly struct DustCalculatorsParameters(double volume, 
                                          double temperature, 
                                          double pressure, 
                                          double filter_weight_1, 
                                          double filter_weight_2) : IInputParameters
{
    public List<double> Values { get; } = [volume, temperature, pressure, filter_weight_1, filter_weight_2];
}
