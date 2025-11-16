// Параметры: V, t, P, m_0, m.

Console.WriteLine("\n> Калькулятор атмосферный воздух *\n");

// Установка параметров.

DustCalculatorsParameters dust_calc_parameters = new(2000, -25.1, 755, 0.00025, 0.1);

// Валидация по диапазонам.

DustCalculatorsValueRanges dust_ranges = new();

FormulaTypeCalculatorInputValueValidator dust_values_validator = new(AtmosphericCalculatorData.CalcParameters.NAMES, 
                                                                     dust_calc_parameters.Values,
                                                                     dust_ranges.Ranges);

// Работа программы.

if (dust_values_validator.Validation_result)
{
    Console.WriteLine("\nCalculator is ready !");

    using (ApplicationContext CalcsDatabase = new())
    {
        //DateOfCalculationData date_and_time = new() { Value = "2025-05-25 15:55:02" };
        //RegisterData main_data = new() { CalcType = 1 };
        AirDustCalcParametersData air_dust_calc_parameters = new() { Volume = 2000, Temperature = 25.0, Pressure = 755.6, MassBefore = 0.0006, MassAfter = 0.12, RegisterId = 1 };
        //AirDustCalcResultsData air_dust_calc_results = new() { Concentrate = 0.58, Fault = 0.12 };

        //CalcsDatabase.DateOfCalculation.Add(date_and_time);
        //CalcsDatabase.Register.Add(main_data);
        CalcsDatabase.AirDustCalcParameters.Add(air_dust_calc_parameters);
        //CalcsDatabase.AirDustCalcResults.Add(air_dust_calc_results);
        CalcsDatabase.SaveChanges();

        Console.WriteLine("\nДанные добавлены в базу данных !");
    };
    




}
else
{
    Console.WriteLine("\nError ! Check the parameters !");
}































/*var self_obj_air_calc = new AtmosphericCalculator([2000, 25.1, 755, 0.00025, 0.1]);

var self_obj_air_result = new AtmosphericResult(self_obj_air_calc.Mass_concentration);

Console.WriteLine(self_obj_air_result.Result);

Console.WriteLine($"\n{new string('=', 60)}");

Console.WriteLine("\n> Калькулятор воздух рабочей зоны *\n");

var self_obj_work_zone_calc = new WorkZoneCalculator([3000, 20, 755, 0.00025, 0.00580]);

var self_obj_work_zone_result = new WorkZoneResult(self_obj_work_zone_calc.Mass_concentration);

Console.WriteLine(self_obj_work_zone_result.Result);*/
