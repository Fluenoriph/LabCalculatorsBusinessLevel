// * Файл "Data.cs". Пространство имен "WorkZoneCalculatorData": константные данные калькулятора. *

namespace WorkZoneCalculatorData;


readonly struct CalcParameters
{
    // Параметры функции-рассчета массовой концентрации пыли, исходя из МУК 4.1.2468-09.

    public static readonly List<string> NAMES = ["Объем воздуха, отобранный для анализа", "Температура воздуха в месте отбора пробы",
                                                 "Барометрическое давление в месте отбора пробы", "Масса фильтра до отбора пробы", 
                                                 "Масса фильтра (с пылью) после отбора пробы"];
}

   
struct NumericConstants
{
    // Пределы диапазона измерения методики: от 1,0 до 250 мг/м³ (миллиграмм на кубический метр).

    public const int METHOD_LOWER_LIMIT_RANGE = 1;

    public const int METHOD_UPPER_LIMIT_RANGE = 250;

    // Коэффициент рассчета погрешности измерения.

    public const double RESULT_FAULT_INDEX = 0.24;

    // Значение нормальной температуры воздуха закрытых помещений по Кельвину (20 ℃).

    public const int CLOSED_SPACE_REFERENCE_TEMPERATURE_INDEX = 293;
}


struct Results
{
    public const string UNIT_REPORT = "Массовая концентрация пыли:";
}
