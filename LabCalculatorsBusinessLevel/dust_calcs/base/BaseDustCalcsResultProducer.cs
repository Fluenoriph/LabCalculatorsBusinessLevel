// * Файл "BaseDustCalcsResultProducer.cs": базовый класс для представления результата вычислений калькуляторов по пыли в воздухе. *

using BaseDustCalcsData;


abstract class BaseDustCalcsResultProducer : IResults
{
    // Нижний предел диапазона методики.

    abstract protected double Lower_limit_range { get; }

    // Верхний предел диапазона методики.

    abstract protected int Upper_limit_range { get; }   

    // Коэффициент рассчета погрешности.

    abstract protected double Error_index { get; }

    // Интерпретация результата.

    abstract protected string Result_report { get; }

    public string? Result { get; }

    // * Вход: массовая концентрация ВВ (пыли). *

    public BaseDustCalcsResultProducer(double mass_concentrate)
    {
        // Концентрация в диапазоне измерения методики.

        if (Lower_limit_range < mass_concentrate && mass_concentrate < Upper_limit_range)
        {
            Result = $"{Result_report} {IResults.ConvertToRussianLocale(mass_concentrate)} {GetResultError(mass_concentrate)} {MeterUnit.MG_M_CUBE}";
        }

        // Концентрация вне диапазонов.

        if (mass_concentrate < Lower_limit_range)
        {
            Result = $"{Result_report} менее {IResults.ConvertToRussianLocale(Lower_limit_range)} {MeterUnit.MG_M_CUBE}";
        }

        if (mass_concentrate > Upper_limit_range)
        {
            Result = $"{Result_report} более {IResults.ConvertToRussianLocale(Upper_limit_range)} {MeterUnit.MG_M_CUBE}";
        }
    }

    // * Рассчет погрешности измерения. *

    string GetResultError(double mass_concentrate)
    {
        return $"± {Math.Round(Error_index * mass_concentrate, 2)}";
    }
}
