//

abstract class BaseCalculator<TValuesType>
{
    protected abstract TValuesType Parameter_values { get; set; }
    public abstract TValuesType Result_data { get; }

#pragma warning disable IDE0290
    public BaseCalculator(BaseInputParameters<TValuesType> parameters_object)
    {
        Parameter_values = parameters_object.Values;
    }
#pragma warning restore IDE0290
}