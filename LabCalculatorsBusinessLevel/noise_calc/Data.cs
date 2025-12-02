//

namespace NoiseCaclculatorData;


struct OctaveBandsTitles
{
    public static List<string> NAMES = ["31.5", "63", "125", "250", "500", "1K", "2K", "4K", "8K", "L(AS)"];
}


struct ResultTitles
{
    public static List<string> SOURCE_DATA_NAMES = ["Общий уровень", "Фоновый уровень"];
    public static List<string> COMPUTED_DATA_NAMES = ["Разность с фоном", "С поправкой на фон"];
}


struct ExtremeValuesOfRange
{
    public const int SOUND_PRESSURE_LEVEL_RANGE_LOWER_LIMIT = 1;
    public const int SOUND_PRESSURE_LEVEL_RANGE_UPPER_LIMIT = 140;

    public const int CORRECTED_SOUND_LEVEL_RANGE_LOWER_LIMIT = 20;
    public const int CORRECTED_SOUND_LEVEL_RANGE_UPPER_LIMIT = 140;
}
