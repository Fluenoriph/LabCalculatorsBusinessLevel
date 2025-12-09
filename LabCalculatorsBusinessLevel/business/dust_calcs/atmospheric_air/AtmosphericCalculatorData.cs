// * Файл "AtmosphericCalculatorData.cs": пространство имен "AtmosphericCalculatorData" - константные данные калькулятора атмосф. воздух. *

namespace AtmosphericCalculatorData;


// Параметры функции-рассчета массовой концентрации взвешенных веществ, исходя из РД 52.04.893-2020.

readonly struct ParametersTitles
{
    public static readonly List<string> NAMES = ["Объем взятого на анализ атмосферного воздуха", "Температура воздуха, прошедшего через ротаметр",
                                                "Атмосферное давление в месте отбора", "Среднее значение массы фильтра до отбора пробы", 
                                                "Среднее значение массы фильтра после отбора пробы"];
}


struct NumericConstants
{
    // Пределы диапазона измерения методики: от 0,15 до 10 мг/м³ (миллиграмм на кубический метр).

    public const double METHOD_LOWER_LIMIT_RANGE = 0.15;

    public const int METHOD_UPPER_LIMIT_RANGE = 10;

    // Коэффициент рассчета погрешности измерения.

    public const double RESULT_FAULT_INDEX = 0.110;
}


// Пояснение результата.

struct ResultTitles
{
    public const string REPORT_NAME = "Массовая концентрация взвешенных веществ:";
}
