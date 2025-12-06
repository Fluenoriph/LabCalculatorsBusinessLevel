//

using NoiseCaclculatorData;


sealed class NoiseCalculatorValidationDataViewer
{
    readonly List<List<double>> parameter_values;
    readonly List<List<bool>> tracer;

    public NoiseCalculatorValidationDataViewer(NoiseCalculatorParameters parameter_object, List<List<bool>> validate_logic_tracer)
    {
        parameter_values = parameter_object.Values;
        tracer = validate_logic_tracer;

        for (int noise_level_type_index = 0; noise_level_type_index < parameter_values.Count; noise_level_type_index++)
        {
            Console.WriteLine(ResultTitles.SOURCE_DATA_NAMES[noise_level_type_index]);

            IValidationDataViewer.ViewResult(OctaveBands.TITLES_NAMES, parameter_values[noise_level_type_index],
                                             tracer[noise_level_type_index]);
        }
    }
}