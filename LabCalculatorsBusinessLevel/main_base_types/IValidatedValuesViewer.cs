//

interface IValidatedValuesViewer
{
    static void ViewResult(List<string> parameter_names, List<double> parameter_values, List<bool> validate_logic_tracer)
    {
        for (int parameter_index = 0; parameter_index < parameter_values.Count; parameter_index++)
        {
            Console.WriteLine($"{parameter_names[parameter_index]}: {parameter_values[parameter_index]} - - - " +
                $"{(validate_logic_tracer[parameter_index] ? "Value Is Valid !" : "Value Is Bad !")}");
        }
    }
}