//

using NoiseCaclculatorData;


sealed class NoiseCalculatorValueRange : BaseValueRange<List<(int, int)>>
{
    public override List<(int, int)> Ranges { get; } = [(ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_LOWER_LIMIT, 
                                                         ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_UPPER_LIMIT),
                                                        (ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_LOWER_LIMIT,
                                                         ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_UPPER_LIMIT)];
}
