//

abstract class FormulaTypeCalculator(FormulaTypeCalculatorParameters parameters_object) : BaseCalculator<List<double>>
{
    protected override List<double> Parameter_values { get; } = parameters_object.Values;
    public override List<double> Result_data { get; } = [];
}