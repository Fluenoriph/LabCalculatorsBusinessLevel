//

using VentilationCalculatorData;


sealed class VentilationCalculatorResultViewer : BaseResultViewer<List<double>, List<string>>
{
    protected override List<string> Result_report { get; } = ResultTitles.RESULT_NAME;

    public VentilationCalculatorResultViewer(List<double> results) : base(results)
    {
        Produced_result = $"{Result_report[0]} {RussianLocaleConverter.Convert(result_data[0])} {MeterUnit.CUBE_METER_PER_HOUR}\n" +
                          $"{Result_report[1]} {RussianLocaleConverter.Convert(result_data[1])} {MeterUnit.RATE_PER_HOUR}";
    }
}