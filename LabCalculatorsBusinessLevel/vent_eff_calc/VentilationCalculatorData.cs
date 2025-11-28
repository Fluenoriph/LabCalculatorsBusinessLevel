//

namespace VentilationCalculatorData;


readonly struct ParametersTitles
{
    public static readonly List<string> NAMES = ["Площадь помещения", "Высота помещения",
                                                 "Скорость движения воздуха в вент. отверстии",
                                                 "Диаметр вент. отверстия", "Ширина вент. отверстия", "Высота вент. отверстия"];
}


struct MeterUnit
{
    public const string SQUARE_METER = "м²";

    public const string METER = "м";

    public const string METER_PER_SECOND = "м/с";

    public const string CENTIMETER = "см";
}


struct ExtremeValuesOfRange
{
    public const int SQUARE_RANGE_LOWER_LIMIT = 0;
    public const int SQUARE_RANGE_UPPER_LIMIT = 9999;

    public const int HEIGHT_RANGE_LOWER_LIMIT = 0;
    public const int HEIGHT_RANGE_UPPER_LIMIT = 15;

    public const int AIR_SPEED_RANGE_LOWER_LIMIT = 0;
    public const int AIR_SPEED_RANGE_UPPER_LIMIT = 20;

    public const int HOLE_SIZE_RANGE_LOWER_LIMIT = 1;
    public const int HOLE_SIZE_RANGE_UPPER_LIMIT = 200;
}

