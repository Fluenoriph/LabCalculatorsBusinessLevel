// * Файл "BaseDustCalcsResultViewer.cs": базовый класс для представления результата вычислений калькуляторов по пыли в воздухе. *

using DustCalcsData;


abstract class BaseDustCalcsResultViewer : BaseResultViewer<List<double>, string>
{
    // Нижний предел диапазона методики.

    abstract protected double Lower_limit_range { get; }

    // Верхний предел диапазона методики.

    abstract protected int Upper_limit_range { get; }       
                
    public BaseDustCalcsResultViewer(List<double> results) : base(results)
    {
        // Концентрация в диапазоне измерения методики.

        if (Lower_limit_range < result_data[0] && result_data[0] < Upper_limit_range)
        {
            Produced_result = $"{Result_report} {RussianLocaleConverter.Convert(result_data[0])} ± {result_data[1]} {MeterUnit.MG_ON_CUBE_METER}";
        }

        // Концентрация вне диапазонов.

        if (result_data[0] < Lower_limit_range)
        {
            Produced_result = $"{Result_report} менее {RussianLocaleConverter.Convert(Lower_limit_range)} {MeterUnit.MG_ON_CUBE_METER}";
        }

        if (result_data[0] > Upper_limit_range)
        {
            Produced_result = $"{Result_report} более {RussianLocaleConverter.Convert(Upper_limit_range)} {MeterUnit.MG_ON_CUBE_METER}";
        }
    }  
}
