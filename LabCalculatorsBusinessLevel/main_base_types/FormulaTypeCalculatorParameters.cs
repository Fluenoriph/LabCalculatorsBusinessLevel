// * Файл "FormulaTypeCalculatorParameters.cs": базовый класс для параметров калькуляторов типа формулы. *

abstract class FormulaTypeCalculatorParameters : BaseInputParameters<double>
{
    public override List<double> Values { get; } = [];
}