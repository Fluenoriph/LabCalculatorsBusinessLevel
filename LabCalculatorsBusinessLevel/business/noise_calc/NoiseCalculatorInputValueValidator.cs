// * Файл "NoiseCalculatorInputValueValidator.cs": класс для валидации параметров по шуму. *

using NoiseCaclculatorData;


sealed class NoiseCalculatorInputValueValidator : BaseInputValueValidator<List<double>, List<List<bool>>>
{
    public override List<List<bool>> Validate_logic_tracer { get; } = [[], []];

    public NoiseCalculatorInputValueValidator(NoiseCalculatorParameters parameters_object, NoiseCalculatorValueRange ranges_object) 
         : base(parameters_object, ranges_object)
    {
        foreach (var trace_list in Validate_logic_tracer)
        {
            GetBadValidatedValues(trace_list);
        }

        GetValidationMainResult();
    }

    protected override void CheckValues()
    {
        var last_value_index = OctaveBands.COUNT - 1;

        for (int noise_level_type_param_index = 0; noise_level_type_param_index < parameter_values.Count; noise_level_type_param_index++)
        {
            for (int octave_band_index = 0; octave_band_index < last_value_index; octave_band_index++)
            {
                var current_value = parameter_values[noise_level_type_param_index][octave_band_index];

                bool check_result = (current_value > ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_LOWER_LIMIT)
                                 && (current_value < ExtremeValuesOfRange.SOUND_PRESSURE_LEVEL_RANGE_UPPER_LIMIT);

                Validate_logic_tracer[noise_level_type_param_index].Add(check_result);
            }

            Validate_logic_tracer[noise_level_type_param_index].Add(ValidateValueToRange(parameter_values[noise_level_type_param_index][last_value_index],
                                                                    ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_LOWER_LIMIT, 
                                                                    ExtremeValuesOfRange.CORRECTED_SOUND_LEVEL_RANGE_UPPER_LIMIT));
        }
    }
}