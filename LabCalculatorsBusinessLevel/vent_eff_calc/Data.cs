//

namespace VentilationCalculatorData;


static class ParametersTitles
{
    static readonly List<string> MAIN_NAMES = ["Площадь помещения", "Высота помещения", "Скорость движения воздуха в вент. отверстии"];
        
    public static readonly List<string> CIRCLE_HOLE_NAMES;
    public static readonly List<string> RECTANGLE_HOLE_NAMES;

    static ParametersTitles()
    {
        CIRCLE_HOLE_NAMES = MAIN_NAMES; 
        CIRCLE_HOLE_NAMES.Add("Диаметр вент. отверстия");

        RECTANGLE_HOLE_NAMES = MAIN_NAMES;
        RECTANGLE_HOLE_NAMES.Add("Ширина вент. отверстия");
        RECTANGLE_HOLE_NAMES.Add("Высота вент. отверстия");
    }
}


struct FormulaConstants
{
    public const int SECONDS_IN_HOUR = 3600;

    public const int TO_METER_CONVERT_INDEX = 100;
}


struct MeterUnit
{
    public const string SQUARE_METER = "м²";

    public const string METER = "м";

    public const string METER_PER_SECOND = "м/с";

    public const string CENTIMETER = "см";

    public const string CUBE_METER_PER_HOUR = "м³/ч";

    public const string RATE_PER_HOUR = "раз/ч";
}


struct ExtremeValuesOfRange
{
    public const int ROOM_SQUARE_RANGE_LOWER_LIMIT = 0;
    public const int ROOM_SQUARE_RANGE_UPPER_LIMIT = 9999;

    public const int ROOM_HEIGHT_RANGE_LOWER_LIMIT = 0;
    public const int ROOM_HEIGHT_RANGE_UPPER_LIMIT = 15;

    public const int AIR_MOVING_SPEED_RANGE_LOWER_LIMIT = 0;
    public const int AIR_MOVING_SPEED_RANGE_UPPER_LIMIT = 20;

    public const int HOLE_SIZE_RANGE_LOWER_LIMIT = 1;
    public const int HOLE_SIZE_RANGE_UPPER_LIMIT = 200;
}


struct ResultTitles
{
    public static List<string> RESULT_NAME = ["Производительность вентиляции:", "Кратность воздухообмена:"];
}