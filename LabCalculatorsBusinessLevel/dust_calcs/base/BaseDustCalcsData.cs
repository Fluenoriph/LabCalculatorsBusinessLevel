// * Файл "Data.cs". Пространство имен "BaseDustCalcsData": общие данные для калькуляторов взвешенных веществ (пыли). *

namespace BaseDustCalcsData;


// * Константы, используемые в формулах. *

struct FormulaConstants
{
    // Значение нормальной температуры атмосферного воздуха по Кельвину (0 ℃).

    public const int ATMOS_REFERENCE_TEMPERATURE_INDEX = 273;

    // Значение нормального атмосферного (барометрического) давления в мм.рт.ст.

    public const int REFERENCE_PRESSURE_INDEX = 760;

    // Показатель кратности в системе СИ.

    public const int C_SYSTEM_STEP_RATE = 1000;
}


// * Единицы измерения. *

struct MeterUnit
{
    public const string MG_M_CUBE = "мг/м³";

    public const string LITER = "л";

    public const string DEGREES_CELSIUS = "℃";

    public const string GRAMME = "г";

    public const string MERCURY_MM = "мм.рт.ст.";
}


// Допустимые границы диапазонов входных параметров калькулятора.

struct ExtremeValuesOfRange
{
    public const int VOLUME_RANGE_LOWER_LIMIT = 0;
    public const int VOLUME_RANGE_UPPER_LIMIT = 10000;

    public const int TEMPERATURE_RANGE_LOWER_LIMIT = -100;
    public const int TEMPERATURE_RANGE_UPPER_LIMIT = 100;

    public const int PRESSURE_RANGE_LOWER_LIMIT = 600;
    public const int PRESSURE_RANGE_UPPER_LIMIT = 900;

    public const int FILTER_WEIGHT_RANGE_LOWER_LIMIT = 0;
    public const int FILTER_WEIGHT_RANGE_UPPER_LIMIT = 50;
}
