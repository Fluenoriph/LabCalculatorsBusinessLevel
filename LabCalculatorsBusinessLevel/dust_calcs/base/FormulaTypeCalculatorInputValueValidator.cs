//

abstract class FormulaTypeCalculatorInputValueValidator : BaseInputValueValidator<List<string>, List<double>,List<bool>, List<List<double>>>
{
    public FormulaTypeCalculatorInputValueValidator(List<string> parameter_names, List<double> parameter_values, List<List<double>> ranges) : base(parameter_names, parameter_values, ranges)
    {

    }

    protected override void CheckValues()
    {
        for (int parameter_index = 0; parameter_index < parameter_values.Count; parameter_index++ )
        {
            if (Value_range[parameter_index].Contains(parameter_values[parameter_index]))
            {
                ////
            }
            else
            {

            }

        }
        



    }
}
