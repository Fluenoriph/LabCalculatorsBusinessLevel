using VentilationCalculatorData;

// Инициализация начальных параметров. ---------------------------------------

//NoiseCalculatorParameters noise_param = new(41.5, 54.2, 45.6, 40.2, 43.3, 40.0, 41.2, 47.5, 48.7, 52.3,
//                                          32.9, 30.2, 41.5, 39.7, 36.4, 40.1, 37.5, 32.5, 36.9, 45.1);

RectangleHoleParameters vent_parameters_rectangle_hole_type = new(50.4, 3.0, 1.8, 15, 15);

//DustCalcsParameters atmospheric_calc_parameters = new(2000.0, -25.1, 755.0, 0.00025, 0.00098);


// Проверка входных параметров. ---------------------------------------------

//NoiseCalculatorInputValueValidator noise_validator = new(noise_param, new NoiseCalculatorValueRange());
//NoiseCalculatorValidationDataViewer validate_view = new(noise_param, noise_validator.Validate_logic_tracer);

FormulaTypeCalculatorInputValueValidator vent_values_validator = new(vent_parameters_rectangle_hole_type, new RectangleHoleValueRanges());


//FormulaTypeCalculatorInputValueValidator atmospheric_values_validator = new(AtmosphericCalculatorData.ParametersTitles.MAIN_NAMES,
//                                                                          atmospheric_calc_parameters, 
//                                                                        new DustCalcsValueRanges());

// Вывести результат валидации -----------------------------------------
IValidationDataViewer.ViewResult(ParametersTitles.RECTANGLE_HOLE_NAMES, vent_parameters_rectangle_hole_type.Values, vent_values_validator.Validate_logic_tracer);


// Работа программы. ---------------------------------------------

if (vent_values_validator.Validation_result)
{
    Console.WriteLine("\nCalculator is ready !\n");

    //NoiseCalculator noise_calc = new(noise_param);
    //NoiseCalculatorResultViewer result_viewer = new(noise_param, noise_calc.Result_data);
    //Console.WriteLine(result_viewer.Produced_result);

    VentilationCalculator vent_calc = new(vent_parameters_rectangle_hole_type);
    VentilationCalculatorResultViewer vent_result = new(vent_calc.Result_data);

    Console.WriteLine(vent_result.Produced_result);

    //AtmosphericCalculator air_calc = new(atmospheric_calc_parameters);
    //AtmosphericResultViewer air_result = new(air_calc.Result_data);

    //Console.WriteLine(air_result.Produced_result);


    // Работа с базой --------------------------------------------
    // Проверка соединения

    FormulaTypeCalculatorDBSession vent_calc_session = new((int)CalculatorsCodeName.VENTILATION, vent_parameters_rectangle_hole_type.Values, vent_calc.Result_data);
    await vent_calc_session.CreateDataSet();

    Console.WriteLine("\nДанные добавлены в базу !\n");






}
else
{
    Console.WriteLine("\n Ошибка ! Проверьте входные параметры !");
}

































/*sealed class ProgramMenu
{
    static readonly List<string> CalcsTitles = ["пыль в атмосферном воздухе", "пыль в воздухе рабочей зоны", "эффективность вентиляции", "учет влияния фонового шума"];
        
    public ProgramMenu()
    {
        Console.WriteLine("\n Выберите тип калькулятора.");
        Console.WriteLine($"\n {ShowCalcTypes()}");

        var calc_value = Console.ReadLine();


    }

    static string ShowCalcTypes()
    {
        string out_result = string.Empty;

        for (int calc_index = 0; calc_index < CalcsTitles.Count; calc_index++)
        {
            out_result += $"({calc_index + 1}) Калькулятор: {CalcsTitles[calc_index]}, ";
        }

        return out_result;
    }

}*/