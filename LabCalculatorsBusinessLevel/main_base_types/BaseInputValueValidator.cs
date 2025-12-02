// Базовый класс для проверки входных параметров на допустимость по диапазону.

abstract class BaseInputValueValidator<TValues, TRange, TTracer>
{
    protected int ALL_VALUES_VALID = 0;
                
    protected TValues parameter_values;
            
    protected TRange Value_range { get; }

    readonly protected Func<double, int, int, bool> ValidateValueToRange = static (current_value, lower_range_limit, upper_range_limit) => 
        (current_value > lower_range_limit) && (current_value < upper_range_limit);

    abstract public TTracer? Validate_logic_tracer { get; }

    public bool Validation_result { get; set; } = false;

    public BaseInputValueValidator(BaseInputParameters<TValues> parameters_object, BaseValueRange<TRange> ranges_object)
    {
        parameter_values = parameters_object.Values;
        Value_range = ranges_object.Ranges;
        
        CheckValues();
        GetValidationMainResult();
    }

    abstract protected void CheckValues();
        
    abstract protected void GetValidationMainResult();
}
