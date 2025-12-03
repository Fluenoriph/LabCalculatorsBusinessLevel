// Базовый класс для проверки входных параметров на допустимость по диапазону.

abstract class BaseInputValueValidator<TValues, TTracer>
{
    protected int ALL_VALUES_VALID = 0;
                
    protected TValues parameter_values;
            
    protected List<(int, int)> Value_range { get; }

    readonly protected Func<double, int, int, bool> ValidateValueToRange = static (current_value, lower_range_limit, upper_range_limit) => 
        (current_value > lower_range_limit) && (current_value < upper_range_limit);

    abstract public TTracer? Validate_logic_tracer { get; }

    public bool Validation_result { get; set; } = false;

    public BaseInputValueValidator(BaseInputParameters<TValues> parameters_object, BaseValueRanges ranges_object)
    {
        parameter_values = parameters_object.Values;
        Value_range = ranges_object.Ranges;
        
        CheckValues();
    }

    abstract protected void CheckValues();   
    
    protected void GetBadValidatedValues(List<bool> trace_list)
    {
        foreach (var logic_result in trace_list)
        {
            if (logic_result == false) ALL_VALUES_VALID++;
        }
    }

    protected void GetValidationMainResult()
    {
        if (ALL_VALUES_VALID == 0)
        {
            Validation_result = true;
        }
    }
}
