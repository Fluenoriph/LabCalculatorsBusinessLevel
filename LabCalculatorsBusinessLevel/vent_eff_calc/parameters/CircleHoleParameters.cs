//

sealed class CircleHoleParameters : BaseVentilationCalculatorParameters
{
    public CircleHoleParameters(double room_square, double room_height, double air_moving_speed, double hole_diameter) 
        : base(room_square, room_height, air_moving_speed)
    {
        Values.Add(hole_diameter);
    }
}
