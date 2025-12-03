// Класс, для валидации параметров калькуляторов, где результат рассчитывается по формуле. 

sealed class FormulaTypeCalculatorInputValueValidator : BaseInputValueValidator<List<double>, List<bool>> 
{
    public override List<bool> Validate_logic_tracer { get; } = [];

    public FormulaTypeCalculatorInputValueValidator(FormulaTypeCalculatorParameters parameters_object, BaseValueRanges ranges_object) 
         : base(parameters_object, ranges_object)
    {
        GetBadValidatedValues(Validate_logic_tracer);
        GetValidationMainResult();
    }

    protected override void CheckValues()
    {
        for (int parameter_index = 0; parameter_index < parameter_values.Count; parameter_index++ )
        {
            Validate_logic_tracer.Add(ValidateValueToRange(parameter_values[parameter_index], Value_range[parameter_index].Item1, Value_range[parameter_index].Item2));   
        }
    }
}
