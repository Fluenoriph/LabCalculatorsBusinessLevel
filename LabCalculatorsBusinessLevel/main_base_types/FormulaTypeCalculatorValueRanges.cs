//

abstract class FormulaTypeCalculatorValueRanges : BaseValueRange<List<(int, int)>>
{
    public override List<(int, int)> Ranges { get; } = [];
}