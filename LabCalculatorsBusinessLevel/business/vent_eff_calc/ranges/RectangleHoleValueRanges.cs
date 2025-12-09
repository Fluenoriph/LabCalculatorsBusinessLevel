// * Файл "RectangleHoleValueRanges.cs": диапазоны валидации, елси отверстие прямоугольник. *

using VentilationCalculatorData;


sealed class RectangleHoleValueRanges : BaseVentilationCalculatorValueRanges
{
    public RectangleHoleValueRanges() : base()
    {
        Ranges.Add((ExtremeValuesOfRange.HOLE_SIZE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.HOLE_SIZE_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.HOLE_SIZE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.HOLE_SIZE_RANGE_UPPER_LIMIT));
    }
}