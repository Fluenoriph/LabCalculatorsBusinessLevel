// * Файл "BaseDustCalcsResultProducer.cs": базовый класс для представления результата вычислений калькуляторов по пыли в воздухе. *

using DustCalcsData;


abstract class BaseDustCalcsResultProducer : BaseResultProducer<string>
{
    // Нижний предел диапазона методики.

    abstract protected double Lower_limit_range { get; }

    // Верхний предел диапазона методики.

    abstract protected int Upper_limit_range { get; }       
                
    public BaseDustCalcsResultProducer(List<double> result_data)
    {
        // Концентрация в диапазоне измерения методики.

        if (Lower_limit_range < result_data[0] && result_data[0] < Upper_limit_range)
        {
            Result_viewer = $"{Result_report} {RussianLocaleConverter.Convert(result_data[0])} ± {result_data[1]} {MeterUnit.MG_ON_CUBE_METER}";
        }

        // Концентрация вне диапазонов.

        if (result_data[0] < Lower_limit_range)
        {
            Result_viewer = $"{Result_report} менее {RussianLocaleConverter.Convert(Lower_limit_range)} {MeterUnit.MG_ON_CUBE_METER}";
        }

        if (result_data[0] > Upper_limit_range)
        {
            Result_viewer = $"{Result_report} более {RussianLocaleConverter.Convert(Upper_limit_range)} {MeterUnit.MG_ON_CUBE_METER}";
        }
    }  
}
