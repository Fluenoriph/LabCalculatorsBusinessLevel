// * Файл "NoiseCalculatorResultViewer.cs": реализация вывода в консоль результатов по шуму. *

using NoiseCaclculatorData;


sealed class NoiseCalculatorResultViewer : BaseResultViewer<List<double>, List<string>>
{
    protected override List<string> Result_report { get; } = ResultTitles.COMPUTED_RESULT_DATA_NAMES;

    // Создание форматированной информации таблицы.

    readonly Func<string, string> CreateTableInfoData = (data) => string.Format($"{{0,{DataOuttingOffset.TABLE_INFO_VALUE}}} {{1,-4}}", data, "|");

    // Данные форматирования октавных полос.

    readonly Func<string> OctaveDataFormating = () =>
    {
        string result = string.Empty;

        for (int band_index = 0; band_index < OctaveBands.COUNT; band_index++)
        {
            result += $"{{{band_index},{DataOuttingOffset.BAND_VALUE}}}";
        }

        return result;
    };
        
    public NoiseCalculatorResultViewer(NoiseCalculatorParameters parameters, List<List<double>> results) : base(results)
    {
        Produced_result = string.Concat(CreateTableInfoData(ResultTitles.METER_UNIT_NAMES) + CreateOctaveData<string>(OctaveBands.TITLES_NAMES), "\n", "\n",
                                        CreateTableInfoData(ResultTitles.SOURCE_DATA_NAMES[0]) + CreateOctaveData<double>(parameters.Values[0]), "\n",
                                        CreateTableInfoData(ResultTitles.SOURCE_DATA_NAMES[1]) + CreateOctaveData<double>(parameters.Values[1]), "\n",
                                        CreateTableInfoData(ResultTitles.COMPUTED_RESULT_DATA_NAMES[0]) + CreateOctaveData<double>(result_data[0]), "\n",
                                        CreateTableInfoData(ResultTitles.COMPUTED_RESULT_DATA_NAMES[1]) + CreateOctaveData<double>(result_data[1]));
    }

    // Создание данных по октавным полосам.

    string CreateOctaveData<TDataType>(List<TDataType> data)
    {
        return string.Format(OctaveDataFormating(), data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);
    }
}