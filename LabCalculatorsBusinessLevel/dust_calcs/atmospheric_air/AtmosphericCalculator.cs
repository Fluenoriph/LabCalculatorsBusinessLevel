// * Файл "AtmosphericCalculator.cs": реализация калькулятора по атмосферному воздуху. *

using BaseData;


class AtmosphericCalculator(List<double> values) : BaseAirDustCalculator(values) 
{
    override protected int Current_area_reference_temperature_index { get; } = FormulaConstants.ATMOS_REFERENCE_TEMPERATURE_INDEX;
}