// базовый класс для представления результата исследований

using System.Globalization;


abstract class BaseResultProducer
{
    // Нижний предел диапазона методики.

    abstract protected double Lower_limit_range { get; }

    // Верхний предел диапазона методики.

    abstract protected int Upper_limit_range { get; }   

    // Коэффициент рассчета погрешности.

    abstract protected double Error_index { get; set; }

    // Интерпретация результата.

    abstract protected string Result_report { get; set; }

    // Результат с погрешностью.

    public string? Result { get; }   // interface ??

    // * Вход: массовая концентрация ВВ (пыли). *

    public BaseResultProducer(double mass_concentrate)
    {
        // Концентрация в диапазоне измерения методики.

        if (Lower_limit_range < mass_concentrate && mass_concentrate < Upper_limit_range)
        {
            Result = $"{Result_report} {ConvertToRussianLocale(mass_concentrate)} {GetResultError(mass_concentrate)} {MeterUnit.MG_M_CUBE}";
        }

        // Концентрация вне диапазонов.

        if (mass_concentrate < Lower_limit_range)
        {
            Result = $"{Result_report} \"менее\", {ConvertToRussianLocale(Lower_limit_range)} {MeterUnit.MG_M_CUBE}";
        }

        if (mass_concentrate > Upper_limit_range)
        {
            Result = $"{Result_report} \"более\", {ConvertToRussianLocale(Upper_limit_range)} {MeterUnit.MG_M_CUBE}";
        }
    }

    // * Замена точки на запятую в результатах. *

    static string ConvertToRussianLocale(double value)    // interface ??
    {
        return value.ToString(CultureInfo.CurrentCulture);   // test ??
    }

    // * Рассчет погрешности измерения. *

    string GetResultError(double mass_concentrate)
    {
        return $"± {Math.Round(Error_index * mass_concentrate, 2)}";
    }
}
