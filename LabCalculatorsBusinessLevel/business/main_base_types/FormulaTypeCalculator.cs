// * Файл "FormulaTypeCalculator.cs": базовый класс для сущности калькуляторов типа формулы. *

abstract class FormulaTypeCalculator(FormulaTypeCalculatorParameters parameters_object) : BaseCalculator<double>(parameters_object)
{
    public override List<double> Result_data { get; } = [];
}