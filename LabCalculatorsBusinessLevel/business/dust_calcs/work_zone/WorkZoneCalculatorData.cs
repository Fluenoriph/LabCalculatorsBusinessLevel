// * Файл "WorkZoneCalculatorData.cs": пространство имен "WorkZoneCalculatorData" - константные данные калькулятора по воздуху рабочей зоны. *

namespace WorkZoneCalculatorData;


// Параметры функции-рассчета массовой концентрации пыли, исходя из МУК 4.1.2468-09.

readonly struct ParametersTitles
{
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


// Пояснение результата.

struct ResultTitles
{
    public const string REPORT_NAME = "Массовая концентрация пыли:";
}
