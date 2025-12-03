//

abstract class FormulaTypeCalculator(FormulaTypeCalculatorParameters parameters_object) : BaseCalculator<List<double>>(parameters_object)
{
    protected override List<double> Parameter_values { get; set; } = [];
    public override List<double> Result_data { get; } = [];
}