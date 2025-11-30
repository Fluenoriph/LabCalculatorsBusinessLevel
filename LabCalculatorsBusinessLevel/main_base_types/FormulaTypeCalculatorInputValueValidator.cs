// Класс, для валидации параметров калькуляторов, где результат рассчитывается по формуле. 

class FormulaTypeCalculatorInputValueValidator(List<string> parameter_names, FormulaTypeCalculatorParameters parameters_object, FormulaTypeCalculatorValueRanges ranges_object) 
    : BaseInputValueValidator<List<string>, List<double>, List<bool>, List<(int, int)>> (parameter_names, parameters_object, ranges_object)
{
    protected override List<bool> Validate_logic_tracer { get; } = [];

    protected override void CheckValues()
    {
        for (int parameter_index = 0; parameter_index < parameter_values.Count; parameter_index++ )
        {
            Validate_logic_tracer.Add(ValidateValueToRange(parameter_values[parameter_index], Value_range[parameter_index].Item1, Value_range[parameter_index].Item2));   
        }
    }

    protected override void GetParameterResult()
    {
        for (int parameter_index = 0; parameter_index < parameter_values.Count; parameter_index++)
        {
            Console.WriteLine($"{parameter_names[parameter_index]}: {parameter_values[parameter_index]} -- " +
                $"{(Validate_logic_tracer[parameter_index] ? "Value Is Valid !" : "Value Is Bad !")}");
        }
    }

    protected override void GetValidationMainResult()
    {
        foreach (var logic_result in Validate_logic_tracer)
        {
            if (logic_result == false) ALL_VALUES_VALID++;
        }

        if (ALL_VALUES_VALID == 0)
        {
            Validation_result = true;
        }
    }
}
