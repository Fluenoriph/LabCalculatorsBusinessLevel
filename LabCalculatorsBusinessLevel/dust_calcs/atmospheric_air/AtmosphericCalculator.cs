// * Файл "AtmosphericCalculator.cs": реализация калькулятора по атмосферному воздуху. *

using BaseDustCalcsData;


class AtmosphericCalculator(List<double> values) : BaseDustCalculator(values) 
{
    override protected int Current_area_reference_temperature_index { get; } = FormulaConstants.ATMOS_REFERENCE_TEMPERATURE_INDEX;
}