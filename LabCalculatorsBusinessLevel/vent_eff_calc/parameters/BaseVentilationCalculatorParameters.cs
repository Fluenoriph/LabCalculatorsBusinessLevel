//

abstract class BaseVentilationCalculatorParameters : FormulaTypeCalculatorParameters
{
    public BaseVentilationCalculatorParameters(double room_square, double room_height, double air_moving_speed)
    {
        Values.Add(room_square); Values.Add(room_height); Values.Add(air_moving_speed);
    }
}