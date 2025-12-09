// * Файл "NoiseCalculatorValueRange.cs": диапазоны проверки параметров калькулятора по шуму. *

using NoiseCaclculatorData;


sealed class NoiseCalculatorValueRange : BaseValueRanges
{
    public NoiseCalculatorValueRange()
    {
        // Проверка уровней звукового давления (дБ) по октавным полосам частот.

        Ranges.Add((ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_LOWER_LIMIT,
                    ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_UPPER_LIMIT));

        // Проверка уровня звука по частотной коррекции А (дБА).

        Ranges.Add((ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_LOWER_LIMIT,
                    ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_UPPER_LIMIT));
    }
}