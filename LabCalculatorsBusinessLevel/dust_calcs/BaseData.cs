// * Файл "BaseData.cs": общие данные для калькуляторов взвешенных веществ (пыли). *

// * Константы, используемые в формулах. *

struct FormulaConstants
{
    // Значение нормальной температуры атмосферного воздуха по Кельвину (0 ℃).

    public const int REFERENCE_ATMOS_TEMPERATURE_INDEX = 273;

    // Значение нормального атмосферного (барометрического) давления в мм.рт.ст.

    public const int REFERENCE_PRESSURE_INDEX = 760;

    // Показатель кратности в системе СИ.

    public const int C_SYSTEM_STEP_RATE = 1000;
}


// * Единицы измерения. *

struct MeterUnit
{
    // Миллиграмм на кубический метр.

    public const string MG_M_CUBE = "мг/м³";
}
