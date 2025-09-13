// * Файл "WorkZoneResult.cs": представление результата исследований воздуха рабочей зоны. *

using WorkZoneCalculatorData;


class WorkZoneResult(double mass_concentrate) : BaseResultProducer(mass_concentrate)
{
    override protected double Lower_limit_range { get; } = NumericConstants.LOWER_LIMIT_RANGE;
    override protected int Upper_limit_range { get; } = NumericConstants.UPPER_LIMIT_RANGE;
    override protected double Error_index { get; } = NumericConstants.RESULT_FAULT_INDEX;
    override protected string Result_report { get; } = Results.UNIT_REPORT;
}
