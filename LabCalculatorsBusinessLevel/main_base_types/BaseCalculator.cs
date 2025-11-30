//

abstract class BaseCalculator<T>
{
    protected abstract T Parameter_values { get; }
    public abstract T Result_data { get; }
}