using VentilationCalculatorData;   // одинаковые имена структур. Нужны отдельные классы сессий калькуляторов.






//Console.WriteLine("\n> Калькулятор атмосферный воздух *\n");

// Параметры

NoiseCalculatorParameters noise_param = new(41.5, 54.2, 45.6, 40.2, 43.3, 40.0, 41.2, 47.5, 48.7, 52.3,
                                            32.9, 30.2, 41.5, 39.7, 36.4, 40.1, 37.5, 32.5, 36.9, 45.1);



//CircleHoleParameters vent_parameters_circle_hole_type = new(45.4, 2.9, 4.6, 15);

//DustCalcsParameters atmospheric_calc_parameters = new(2000.0, -25.1, 755.0, 0.00025, 0.00098);

// Проверка входных параметров.

NoiseCalculatorInputValueValidator noise_validator = new(noise_param, new NoiseCalculatorValueRange());

NoiseCalculatorValidationDataViewer validate_view = new(noise_param, noise_validator.Validate_logic_tracer);

//FormulaTypeCalculatorInputValueValidator vent_values_validator = new(vent_parameters_circle_hole_type, new CircleHoleValueRanges());


//FormulaTypeCalculatorInputValueValidator atmospheric_values_validator = new(AtmosphericCalculatorData.ParametersTitles.MAIN_NAMES,
//                                                                          atmospheric_calc_parameters, 
//                                                                        new DustCalcsValueRanges());

//IValidationDataViewer.ViewResult(ParametersTitles.CIRCLE_HOLE_NAMES, vent_parameters_circle_hole_type.Values, vent_values_validator.Validate_logic_tracer);


// Работа программы.

if (noise_validator.Validation_result)
{
    Console.WriteLine("\nCalculator is ready !");

    NoiseCalculator noise_calc = new(noise_param);



    NoiseCalculatorResultViewer result_viewer = new(noise_param, noise_calc.Result_data);

    Console.WriteLine(result_viewer.Produced_result);

    //VentilationCalculator vent_calc = new(vent_parameters_circle_hole_type);
    //VentilationCalculatorResultViewer vent_result = new(vent_calc.Result_data);

    //Console.WriteLine(vent_result.Produced_result);








    //AtmosphericCalculator air_calc = new(atmospheric_calc_parameters);
    //AtmosphericResultViewer air_result = new(air_calc.Result_data);

    //Console.WriteLine(air_result.Produced_result);


    //////////////////////////////////////////////////////////////////////////////////  Database sets

    /*using (LabCalcsContext CalcsDatabase = new())
    {
        bool db_ready = CalcsDatabase.Database.CanConnect();

        if (db_ready) Console.WriteLine("Base is OK !");
        else Console.WriteLine("Base is BAD !");






        AirParameters air_parameters = new()
        {
            Volume = (float)dust_calc_parameters.Values[0],
            Temperature = (float)dust_calc_parameters.Values[1],
            Pressure = (float)dust_calc_parameters.Values[2],
            FilterWeightBefore = (float)dust_calc_parameters.Values[3],
            FilterWeightAfter = (float)dust_calc_parameters.Values[4]
        };
        CalcsDatabase.Airparameters.Add(air_parameters);

        

        CalcsDatabase.SaveChanges();
        Console.WriteLine("\nДанные добавлены в базу данных !");
    };*/








    ////////////////////////////////////////////////////////////////////////////////////////////
}
else
{
    Console.WriteLine("\n Ошибка ! Проверьте входные параметры !");
}










sealed class ProgramMenu
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

}