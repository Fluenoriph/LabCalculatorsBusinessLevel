// * Файл "NoiseCalculatorValidationDataViewer.cs": класс для вывода в консоль результатов валидации входных параметров по шуму. *

using NoiseCaclculatorData;


sealed class NoiseCalculatorValidationDataViewer
{
    public NoiseCalculatorValidationDataViewer(NoiseCalculatorParameters parameter_object, List<List<bool>> validate_logic_tracer)
    {
        for (int noise_level_type_index = 0; noise_level_type_index < parameter_object.Values.Count; noise_level_type_index++)
        {
            Console.WriteLine(ResultTitles.SOURCE_DATA_NAMES[noise_level_type_index]);

            IValidationDataViewer.ViewResult(OctaveBands.TITLES_NAMES, parameter_object.Values[noise_level_type_index],
                                             validate_logic_tracer[noise_level_type_index]);
        }
    }
}