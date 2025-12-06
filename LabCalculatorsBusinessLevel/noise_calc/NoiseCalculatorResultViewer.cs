//

using NoiseCaclculatorData;


sealed class NoiseCalculatorResultViewer : BaseResultViewer<List<List<double>>, List<string>>
{
    protected override List<string> Result_report { get; } = ResultTitles.COMPUTED_DATA_NAMES;
        
    readonly Func<string> Formating = () =>
    {
        string result = string.Empty;

        for (int band_index = 0; band_index < OctaveBands.COUNT; band_index++)
        {
            result += $"{{{band_index},{BandDataOuttingOffset.VALUE}}}";
        }

        return result;
    };
    
    public NoiseCalculatorResultViewer(NoiseCalculatorParameters parameters, List<List<double>> results) 
         : base(results)
    {
        Produced_result = string.Concat(CreateOctaveData<string>(OctaveBands.TITLES_NAMES), "\n", "\n",
                                        CreateOctaveData<double>(parameters.Values[0]), "\n",
                                        CreateOctaveData<double>(parameters.Values[1]), "\n",
                                        CreateOctaveData<double>(result_data[0]), "\n",
                                        CreateOctaveData<double>(result_data[1]));
    }

    string CreateOctaveData<TDataType>(List<TDataType> data)
    {
        return string.Format(Formating(), data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);
    }
}