// * Файл "AtmosphericResult.cs": представление результата исследований атмосферного воздуха. *

using AtmosphericCalculatorData;


class AtmosphericResultViewer(List<double> result_data) : BaseDustCalcsResultViewer(result_data)
{
    override protected double Lower_limit_range { get; } = NumericConstants.METHOD_LOWER_LIMIT_RANGE;
    override protected int Upper_limit_range { get; } = NumericConstants.METHOD_UPPER_LIMIT_RANGE;
    override protected string Result_report { get; } = ResultTitles.REPORT_NAME;
}
