// * Границы диапазонов значений параметров. *

using BaseData;


class DustCalculatorsValueRanges : IBaseValueRange<List<(int, int)>>
{
    public List<(int, int)> Ranges { get; } = [(ExtremeValuesOfRange.VOLUME_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.VOLUME_RANGE_UPPER_LIMIT),
                                               (ExtremeValuesOfRange.TEMPERATURE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.TEMPERATURE_RANGE_UPPER_LIMIT),
                                               (ExtremeValuesOfRange.PRESSURE_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.VOLUME_RANGE_UPPER_LIMIT),
                                               (ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_UPPER_LIMIT),
                                               (ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_LOWER_LIMIT, ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_UPPER_LIMIT)];
}
