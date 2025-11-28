using LabCalculatorsBusinessLevel.CalcDBContext;
using LabCalculatorsBusinessLevel.Models;


Console.WriteLine("\n> Калькулятор атмосферный воздух *\n");

// Установка параметров (V, t, P, m_0, m).

DustCalcsParameters dust_calc_parameters = new(2000, -25.1, 755, 0.00025, 0.1);

// Валидация по диапазонам.

DustCalcsValueRanges dust_ranges = new();

FormulaTypeCalculatorInputValueValidator dust_values_validator = new(AtmosphericCalculatorData.ParametersTitles.NAMES, 
                                                                     dust_calc_parameters.Values,
                                                                     dust_ranges.Ranges);

// Работа программы.

if (dust_values_validator.Validation_result)
{
    Console.WriteLine("\nCalculator is ready !");

    using (LabCalcsContext CalcsDatabase = new())
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
    };
    
}
else
{
    Console.WriteLine("\nError ! Check the parameters !");
}































/*var self_obj_air_calc = new AtmosphericCalculator([2000, 25.1, 755, 0.00025, 0.1]);

var self_obj_air_result = new AtmosphericResult(self_obj_air_calc.Mass_concentration);

Console.WriteLine(self_obj_air_result.Result_viewer);

Console.WriteLine($"\n{new string('=', 60)}");

Console.WriteLine("\n> Калькулятор воздух рабочей зоны *\n");

var self_obj_work_zone_calc = new WorkZoneCalculator([3000, 20, 755, 0.00025, 0.00580]);

var self_obj_work_zone_result = new WorkZoneResult(self_obj_work_zone_calc.Mass_concentration);

Console.WriteLine(self_obj_work_zone_result.Result_viewer);*/
