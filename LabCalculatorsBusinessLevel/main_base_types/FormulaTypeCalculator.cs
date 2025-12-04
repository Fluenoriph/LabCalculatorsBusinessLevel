//

abstract class FormulaTypeCalculator(FormulaTypeCalculatorParameters parameters_object) : BaseCalculator<List<double>>(parameters_object)
{
    public override List<double> Result_data { get; } = [];
}