// * Файл "BaseDustCalcsResultProducer.cs": базовый класс для представления результата вычислений калькуляторов по пыли в воздухе. *

using BaseDustCalcsData;


abstract class BaseDustCalcsResultProducer : IResultProducer
{
    // Нижний предел диапазона методики.

    abstract protected double Lower_limit_range { get; }

    // Верхний предел диапазона методики.

    abstract protected int Upper_limit_range { get; }   

    // Интерпретация результата.

    abstract protected string Result_report { get; }

    public string? Result_viewer { get; }

    public BaseDustCalcsResultProducer(double mass_concentrate, double result_error)
    {
        // Концентрация в диапазоне измерения методики.

        if (Lower_limit_range < mass_concentrate && mass_concentrate < Upper_limit_range)
        {
            Result_viewer = $"{Result_report} {RussianLocaleConverter.Convert(mass_concentrate)} ± {result_error} {MeterUnit.MG_M_CUBE}";
        }

        // Концентрация вне диапазонов.

        if (mass_concentrate < Lower_limit_range)
        {
            Result_viewer = $"{Result_report} менее {RussianLocaleConverter.Convert(Lower_limit_range)} {MeterUnit.MG_M_CUBE}";
        }

        if (mass_concentrate > Upper_limit_range)
        {
            Result_viewer = $"{Result_report} более {RussianLocaleConverter.Convert(Upper_limit_range)} {MeterUnit.MG_M_CUBE}";
        }
    }  
}
