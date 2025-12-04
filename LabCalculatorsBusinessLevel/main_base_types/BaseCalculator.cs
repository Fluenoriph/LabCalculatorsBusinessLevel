//

abstract class BaseCalculator<TValuesType>(BaseInputParameters<TValuesType> parameters_object)
{
    protected TValuesType parameter_values = parameters_object.Values;
    public abstract TValuesType Result_data { get; }
}