// * Файл "BaseCalculator.cs" : базовый класс сущности калькулятора. * 

abstract class BaseCalculator<TValuesType>(BaseInputParameters<TValuesType> parameters_object)
{
    protected List<TValuesType> parameter_values = parameters_object.Values;
    public abstract List<TValuesType> Result_data { get; }
}