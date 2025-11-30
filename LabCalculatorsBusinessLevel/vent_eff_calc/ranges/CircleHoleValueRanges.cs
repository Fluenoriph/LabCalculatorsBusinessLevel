//

using VentilationCalculatorData;


sealed class CircleHoleValueRanges : BaseVentilationCalculatorValueRanges
{
    public CircleHoleValueRanges() : base()
    {
        Ranges.Add((ExtremeValuesOfRange.HOLE_SIZE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.HOLE_SIZE_RANGE_UPPER_LIMIT));
    }
}
