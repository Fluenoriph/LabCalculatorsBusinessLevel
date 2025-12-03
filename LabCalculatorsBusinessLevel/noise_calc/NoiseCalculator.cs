//

using NoiseCaclculatorData;

sealed class NoiseCalculator : BaseCalculator<List<List<double>>>
{
    protected override List<List<double>> Parameter_values { get; set; } = [];
    public override List<List<double>> Result_data { get; } = [];

    public NoiseCalculator(NoiseCalculatorParameters parameters_object) : base(parameters_object)
    {
        for (int octave_band_index = 0; octave_band_index < OctaveBands.COUNT; octave_band_index++)
        {
            var result = ComputingWithBackgroundLevel(Parameter_values[NoiseLevelTypeIndex.SOURCE][octave_band_index], 
                                                      Parameter_values[NoiseLevelTypeIndex.BACKGROUND][octave_band_index]);

            Result_data[NoiseLevelTypeIndex.DELTA].Add(result.Item1);
            Result_data[NoiseLevelTypeIndex.FIXED].Add(result.Item2);
        }
    }

    static (double, double) ComputingWithBackgroundLevel(double source_level_value, double back_level_value)
    {
        double delta = source_level_value - back_level_value;

        if (delta < NoiseFixesAndDeltaRanges.DELTA_RANGE_LOWER_LIMIT)
        {
            return (delta, source_level_value);
        }
        else if (delta > NoiseFixesAndDeltaRanges.DELTA_RANGE_UPPER_LIMIT)
        {
            return (delta, source_level_value * 0);
        }
        else
        {
            (double, double) result = new();

            foreach (var noise_fix_unit in NoiseFixesAndDeltaRanges.Values)
            {
                if ((delta >= noise_fix_unit.Item1) && (delta <= noise_fix_unit.Item2))
                {
                    result = (delta, source_level_value - noise_fix_unit.Item3);
                }
            }

            return result;
        }
    }
}