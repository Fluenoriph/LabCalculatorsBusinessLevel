//

using NoiseCaclculatorData;


sealed class NoiseCalculatorValueRange : BaseValueRanges
{
    public NoiseCalculatorValueRange()
    {
        Ranges.Add((ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_LOWER_LIMIT,
                    ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_UPPER_LIMIT));

        Ranges.Add((ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_LOWER_LIMIT,
                    ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_UPPER_LIMIT));
    }
}