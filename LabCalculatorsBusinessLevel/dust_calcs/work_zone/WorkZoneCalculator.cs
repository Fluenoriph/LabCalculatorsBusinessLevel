// * Файл "WorkZoneCalculator.cs": реализация калькулятора по воздуху рабочей зоны. *

using WorkZoneCalculatorData;


class WorkZoneCalculator(List<double> values) : BaseDustCalculator(values)
{
    override protected int Current_area_reference_temperature_index { get; } = NumericConstants.CLOSED_SPACE_REFERENCE_TEMPERATURE_INDEX;
}
