// * Файл "BaseVentilationCalculatorValueRanges.cs": базовый класс для диапазонов валидации параметров калькулятора по вентиляции. * 
// Без параметров вентиляционного отверстия.

using VentilationCalculatorData;


abstract class BaseVentilationCalculatorValueRanges : BaseValueRanges
{
    public BaseVentilationCalculatorValueRanges()
    {
        Ranges.Add((ExtremeValuesOfRange.ROOM_SQUARE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.ROOM_SQUARE_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.ROOM_HEIGHT_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.ROOM_HEIGHT_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.AIR_MOVING_SPEED_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.AIR_MOVING_SPEED_RANGE_UPPER_LIMIT));
    }
}