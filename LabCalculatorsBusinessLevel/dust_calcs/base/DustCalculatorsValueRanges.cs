// * Границы диапазонов значений параметров. *

class DustCalculatorsValueRanges : BaseValueRange
{
    public static (double, double) volume_range_values = (0.0, 10000.0);

    public static (double, double) temperature_range_values = (-100.0, 100.0);

    public static (double, double) pressure_range_values = (600.0, 900.0);

    public static (double, double) filter_weight_range_values = (0.0, 50.0);
}
