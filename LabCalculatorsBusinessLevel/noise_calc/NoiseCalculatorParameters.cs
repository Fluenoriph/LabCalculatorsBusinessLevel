//

sealed class NoiseCalculatorParameters : BaseInputParameters<List<List<double>>> 
{
    public override List<List<double>> Values { get; } = [[], []];

    public NoiseCalculatorParameters(double source_31_5_band_value, double source_63_band_value, double source_125_band_value,
                                     double source_250_band_value, double source_500_band_value, double source_1k_band_value,
                                     double source_2k_band_value, double source_4k_band_value,
                                     double source_8k_band_value, double source_L_AS_band_value,

                                     double back_31_5_band_value, double back_63_band_value, double back_125_band_value,
                                     double back_250_band_value, double back_500_band_value, double back_1k_band_value,
                                     double back_2k_band_value, double back_4k_band_value,
                                     double back_8k_band_value, double back_L_AS_band_value)
    {
        Values[0].Add(source_31_5_band_value); Values[0].Add(source_63_band_value); Values[0].Add(source_125_band_value); 
        Values[0].Add(source_250_band_value); Values[0].Add(source_500_band_value); Values[0].Add(source_1k_band_value);
        Values[0].Add(source_2k_band_value); Values[0].Add(source_4k_band_value); Values[0].Add(source_8k_band_value);
        Values[0].Add(source_L_AS_band_value);
                
        Values[1].Add(back_31_5_band_value); Values[1].Add(back_63_band_value); Values[1].Add(back_125_band_value);
        Values[1].Add(back_250_band_value); Values[1].Add(back_500_band_value); Values[1].Add(back_1k_band_value);
        Values[1].Add(back_2k_band_value); Values[1].Add(back_4k_band_value); Values[1].Add(back_8k_band_value);
        Values[1].Add(back_L_AS_band_value);
    }
}