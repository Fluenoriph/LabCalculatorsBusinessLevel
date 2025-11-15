// Базовый класс для проверки входных параметров на допустимость.

abstract class BaseInputValueValidator<T, L, K, N>
{
    protected T parameter_names;

    protected L parameter_values;
        
    protected K? validate_logic_tracer;

    protected N Value_range { get; }

    public BaseInputValueValidator(T parameter_names, L parameter_values, N ranges)
    {
        this.parameter_names = parameter_names;
        this.parameter_values = parameter_values;
        Value_range = ranges;
        
        CheckValues();
    }

    abstract protected void CheckValues();
}
