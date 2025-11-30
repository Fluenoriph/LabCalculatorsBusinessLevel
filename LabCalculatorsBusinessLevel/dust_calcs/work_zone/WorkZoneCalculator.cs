// * Файл "WorkZoneCalculator.cs": реализация калькулятора по воздуху рабочей зоны. *

using WorkZoneCalculatorData;


class WorkZoneCalculator(DustCalcsParameters parameters_object) : BaseDustCalculator(parameters_object)
{
    protected override int Current_area_reference_temperature_index { get; } = NumericConstants.CLOSED_SPACE_REFERENCE_TEMPERATURE_INDEX;
    protected override double Error_index { get; } = NumericConstants.RESULT_FAULT_INDEX;
}
