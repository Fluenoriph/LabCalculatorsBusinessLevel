// * Файл "BaseInputValueValidator.cs": базовый класс для проверки входных параметров на допустимость по диапазону.

abstract class BaseInputValueValidator<TDataType, TTracer>
{
    protected int bad_values = 0; // Количество невалидных значений.

    protected List<TDataType> parameter_values;
        
    protected List<(int, int)> value_range; // Список граничных значений диапазонов.
        
    protected readonly Func<double, int, int, bool> ValidateValueToRange = static (current_value, lower_range_limit, upper_range_limit) => 
        (current_value > lower_range_limit) && (current_value < upper_range_limit); // Проверка по диапазону.
        
    public abstract TTracer? Validate_logic_tracer { get; } // Булева логика результата валидации по каждому значению.
        
    public bool Validation_result { get; set; } = false; // Результирующий показатель валидации.

    public BaseInputValueValidator(BaseInputParameters<TDataType> parameters_object, BaseValueRanges ranges_object)
    {
        parameter_values = parameters_object.Values;
        value_range = ranges_object.Ranges;
        
        CheckValues();
    }

    protected abstract void CheckValues();   
    
    // Если хотя бы одно значение не верно, то общий результат будет отрицательный.

    protected void GetBadValidatedValues(List<bool> trace_list)
    {
        foreach (var logic_result in trace_list)
        {
            if (logic_result == false) bad_values++;
        }
    }

    protected void GetValidationMainResult()
    {
        if (bad_values == 0)
        {
            Validation_result = true;
        }
    }
}
