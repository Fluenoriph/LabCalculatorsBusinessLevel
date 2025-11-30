// Базовый класс для проверки входных параметров на допустимость по диапазону.

abstract class BaseInputValueValidator<T, L, K, N>
{
    protected int ALL_VALUES_VALID = 0;

    public bool Validation_result { get; set; } = false;

    protected T parameter_names;

    protected L parameter_values;
        
    abstract protected K? Validate_logic_tracer { get; }

    protected N Value_range { get; }

    readonly protected Func<double, int, int, bool> ValidateValueToRange = static (current_value, lower_range_limit, upper_range_limit) => 
        (current_value > lower_range_limit) && (current_value < upper_range_limit);

    public BaseInputValueValidator(T parameter_names, BaseInputParameters<L> parameters_object, BaseValueRange<N> ranges_object)
    {
        this.parameter_names = parameter_names;
        parameter_values = parameters_object.Values;
        Value_range = ranges_object.Ranges;
        
        CheckValues();
        GetValidationMainResult();
        GetParameterResult();
    }

    abstract protected void CheckValues();

    abstract protected void GetParameterResult();

    abstract protected void GetValidationMainResult();
}
