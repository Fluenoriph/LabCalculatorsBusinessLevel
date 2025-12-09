// * Файл "RectangleHoleParameters.cs": параметры калькулятора по вентиляции, если отверстие - прямоугольник. *

sealed class RectangleHoleParameters : BaseVentilationCalculatorParameters
{
    public RectangleHoleParameters(double room_square, double room_height, double air_moving_speed, double hole_width, double hole_height) 
         : base(room_square, room_height, air_moving_speed)
    {
        Values.Add(hole_width); Values.Add(hole_height);
    }
}