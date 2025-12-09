// * Файл "NoiseCalculator.cs": реализация калькулятора по шуму. *

using NoiseCaclculatorData;
using MainData;


sealed class NoiseCalculator : BaseCalculator<List<double>>
{
    public override List<List<double>> Result_data { get; } = [[], []];

    public NoiseCalculator(NoiseCalculatorParameters parameters_object) : base(parameters_object)
    {
        // Проход по всему спектру.

        for (int octave_band_index = 0; octave_band_index < OctaveBands.COUNT; octave_band_index++)
        {
            var result = ComputingWithBackgroundLevel(parameter_values[NoiseLevelTypeIndex.SOURCE][octave_band_index], 
                                                      parameter_values[NoiseLevelTypeIndex.BACKGROUND][octave_band_index]);

            Result_data[NoiseLevelTypeIndex.DELTA].Add(Math.Round(result.Item1, FractionalDigits.ONE));
            Result_data[NoiseLevelTypeIndex.FIXED].Add(Math.Round(result.Item2, FractionalDigits.ONE));
        }
    }

    // Вычисление результата с применением поправок на фоновый уровень. Для одного значения.

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