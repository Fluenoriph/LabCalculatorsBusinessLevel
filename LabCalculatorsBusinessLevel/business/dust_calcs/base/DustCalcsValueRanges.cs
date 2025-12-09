// * Файл "DustCalcsValueRanges.cs": диапазоны валидации параметров калькуляторов по пыли. *

using DustCalcsData;


sealed class DustCalcsValueRanges : BaseValueRanges
{
    public DustCalcsValueRanges()
    {
        Ranges.Add((ExtremeValuesOfRange.VOLUME_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.VOLUME_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.TEMPERATURE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.TEMPERATURE_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.PRESSURE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.VOLUME_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_UPPER_LIMIT));
        Ranges.Add((ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_UPPER_LIMIT));
    }
}
