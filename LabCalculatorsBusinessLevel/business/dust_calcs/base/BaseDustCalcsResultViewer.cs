// * Файл "BaseDustCalcsResultViewer.cs": базовый класс для вывода в консоль результата вычислений калькуляторов по пыли в воздухе. *

using DustCalcsData;


abstract class BaseDustCalcsResultViewer : BaseResultViewer<double, string>
{
    protected abstract double Lower_limit_range { get; } // Нижний предел диапазона методики.   

    protected abstract int Upper_limit_range { get; } // Верхний предел диапазона методики.    

    public BaseDustCalcsResultViewer(List<double> results) : base(results)
    {
        // Концентрация в диапазоне измерения методики.

        if (Lower_limit_range < result_data[0] && result_data[0] < Upper_limit_range)
        {
            Produced_result = $"{Result_report} {RussianLocaleConverter.Convert(result_data[0])} ± {result_data[1]} {MeterUnit.MG_ON_CUBE_METER}";
        }

        // Концентрация вне диапазона.

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
