// * Границы диапазонов значений параметров. *

using BaseData;


class DustCalculatorsValueRanges : IBaseValueRange<List<IEnumerable<int>>>
{
    public List<List<double>> CorrectRanges { get; } = [];

    public List<IEnumerable<int>> Ranges { get; } = [Enumerable.Range(ExtremeValuesOfRange.VOLUME_RANGE_LOWER_VALUE, ExtremeValuesOfRange.VOLUME_RANGE_UPPER_VALUE),
                                                     Enumerable.Range(ExtremeValuesOfRange.TEMPERATURE_RANGE_LOWER_VALUE, ExtremeValuesOfRange.TEMPERATURE_RANGE_UPPER_VALUE),
                                                     Enumerable.Range(ExtremeValuesOfRange.PRESSURE_RANGE_LOWER_VALUE, ExtremeValuesOfRange.VOLUME_RANGE_UPPER_VALUE),
                                                     Enumerable.Range(ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_LOWER_VALUE, ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_UPPER_VALUE),
                                                     Enumerable.Range(ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_LOWER_VALUE, ExtremeValuesOfRange.FILTER_WEIGHT_RANGE_UPPER_VALUE)];

    public DustCalculatorsValueRanges()
    {
        for (int range_index = 0; range_index < Ranges.Count; range_index++)
        {
            List<double> correct_range = [];

            foreach (var value in Ranges[range_index])
            {
                correct_range.Add(Convert.ToDouble(value));
            }

            CorrectRanges.Add(correct_range);
        }
    }
}
