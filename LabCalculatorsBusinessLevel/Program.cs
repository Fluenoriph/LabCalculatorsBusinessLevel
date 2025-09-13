// Параметры: V, t, P, m_0, m.

Console.WriteLine("\n> Калькулятор атмосферный воздух *\n");

var self_obj_air_calc = new AtmosphericCalculator([2000, 25.1, 755, 0.00025, 0.1]);

var self_obj_air_result = new AtmosphericResult(self_obj_air_calc.Mass_concentration);

Console.WriteLine(self_obj_air_result.Result);

Console.WriteLine($"\n{new string('=', 60)}");

Console.WriteLine("\n> Калькулятор воздух рабочей зоны *\n");

var self_obj_work_zone_calc = new WorkZoneCalculator([3000, 20, 755, 0.00025, 0.00580]);

var self_obj_work_zone_result = new WorkZoneResult(self_obj_work_zone_calc.Mass_concentration);

Console.WriteLine(self_obj_work_zone_result.Result);
