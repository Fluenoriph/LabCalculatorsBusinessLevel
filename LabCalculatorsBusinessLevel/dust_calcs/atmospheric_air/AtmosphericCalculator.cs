// * Файл "AtmosphericCalculator.cs": реализация калькулятора по атмосферному воздуху. *

using AtmosphericCalculatorData;
using DustCalcsData;


class AtmosphericCalculator(DustCalcsParameters parameters_object) : BaseDustCalculator(parameters_object) 
{
    protected override int Current_area_reference_temperature_index { get; } = FormulaConstants.ATMOS_REFERENCE_TEMPERATURE_INDEX;
    protected override double Error_index { get; } = NumericConstants.RESULT_FAULT_INDEX;
}