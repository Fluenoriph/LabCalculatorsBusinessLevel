// * Файл "Data.cs": пространство имен "NoiseCaclculatorData" - данные для калькулятора по шуму. *

namespace NoiseCaclculatorData;


// Октавные полосы частот (Гц).

struct OctaveBands
{
    public static List<string> TITLES_NAMES = ["31.5", "63", "125", "250", "500", "1K", "2K", "4K", "8K", "L(AS)"];
    public const int COUNT = 10;
}


// Информация таблицы.

struct ResultTitles
{
    public const string METER_UNIT_NAMES = "dB \\ Hz";
    public static List<string> SOURCE_DATA_NAMES = ["Общий уровень", "Фоновый уровень"];
    public static List<string> COMPUTED_RESULT_DATA_NAMES = ["Разность с фоном", "С поправкой на фон"];
}


// Диапазоны и поправки для рассчета результата
// (МУК 4.3.3722-21 "Контроль уровня шума на территории жилой застройки, в жилых и общественных зданиях и помещениях").

struct NoiseFixesAndDeltaRanges
{
    // Разность между общим уровнем (от источника) и фоновым.

    public const int DELTA_RANGE_LOWER_LIMIT = 3; // Нижний предел.
    public const int DELTA_RANGE_UPPER_LIMIT = 10; // Верхний предел.

    // Динамическое применение поправки.
    // 1 - нижний предел, 2 - верхний предел, 3 - вычитаемая поправка.

    public static List<(double, double, double)> Values = [(3.0, 3.4, 2.8), (3.5, 3.9, 2.4), (4.0, 4.4, 2.0), (4.5, 4.9, 1.8), (5.0, 5.9, 1.4),
                                                           (6.0, 6.9, 1.1), (7.0, 7.9, 0.9), (8.0, 8.9, 0.7), (9.0, 9.9, 0.5)];
}


// Индексы списков.

struct NoiseLevelTypeIndex
{
    public const int SOURCE = 0, DELTA = 0;
    public const int BACKGROUND = 1, FIXED = 1;
}


// Границы диапазонов валидации.

struct ExtremeValuesOfRange
{
    // Для звукового давления.

    public const int SOUND_PRESSURE_LEVEL_RANGE_LOWER_LIMIT = 1;
    public const int SOUND_PRESSURE_LEVEL_RANGE_UPPER_LIMIT = 151;

    // Для уровня звука по (А).

    public const int CORRECTED_SOUND_LEVEL_RANGE_LOWER_LIMIT = 21;
    public const int CORRECTED_SOUND_LEVEL_RANGE_UPPER_LIMIT = 140;
}


// Выравнивание результатов в консоли.

struct DataOuttingOffset
{
    public const int BAND_VALUE = -8;
    public const int TABLE_INFO_VALUE = -20;
}