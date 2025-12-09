// * Файл "AtmosphericResult.cs": консольный вывод результата исследований атмосферного воздуха. *

using AtmosphericCalculatorData;


sealed class AtmosphericResultViewer(List<double> result_data) : BaseDustCalcsResultViewer(result_data)
{
    protected override double Lower_limit_range { get; } = NumericConstants.METHOD_LOWER_LIMIT_RANGE;
    protected override int Upper_limit_range { get; } = NumericConstants.METHOD_UPPER_LIMIT_RANGE;
    protected override string Result_report { get; } = ResultTitles.REPORT_NAME;
}
