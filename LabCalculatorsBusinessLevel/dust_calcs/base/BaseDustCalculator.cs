// * Файл "BaseDustCalculator.cs": базовый класс, для калькуляторов рассчета взвешенных веществ в воздухе. *

using DustCalcsData;


abstract class BaseDustCalculator : FormulaTypeCalculator
{
    // Значение нормальной температуры среды, в которой проводился отбор проб.
    // Атмосферный воздух или воздух закрытых помещений.

    abstract protected int Current_area_reference_temperature_index { get; }

    // Коэффициент погрешности.

    abstract protected double Error_index { get; }
    
    // Параметры: (0)-объем, (1)-температура, (2)-давление, (3)-масса чистого фильтра, (4)-масса фильтра с пылью.

    public BaseDustCalculator(DustCalcsParameters parameters_object) : base(parameters_object)
    {
        var mass_concentration = CalcMassConcentration();

        Result_data.Add(mass_concentration);
        Result_data.Add(DustCalcsResultError.GetResultError(mass_concentration, Error_index));
    }

    /* * Вычисление массовой концентрации взвешенных веществ (пыли). *
     *   
     *   Концентрация ВВ (мг/м куб.) = ( ( масса фильтра после отбора (с пылью), г * 1000 ) - ( масса фильтра до отбора (чистого), г * 1000) ) * 1000 /
     *                                      нормальный объем, л
     * 
     *   Примечание: массы фильтров даны в граммах, т.к. все же, ориентируемся на весы лабораторные, которые измеряют в граммах. 
     *   Осуществляем перевод в миллиграммы, как требуется в методиках.
     */

    double CalcMassConcentration()
    {
        var concentration = ( (parameter_values[4] * FormulaConstants.C_SYSTEM_STEP_RATE) - (parameter_values[3] * FormulaConstants.C_SYSTEM_STEP_RATE) ) * FormulaConstants.C_SYSTEM_STEP_RATE /
                               GetNormalVolume();

        return Math.Round(concentration, FractionalDigits.DUST_CALCS);
    }

    /* * Приведение объема отобранной пробы к нормальным условиям. *
     *   
     *   Норм. объем (л) = (объем пробы, л * коэффициент температуры в исследуемой среде * давление в месте отбора, мм.рт.ст) /
     *                     ( (273 + температура воздуха при отборе, град. Цельсия) * 760)
     *      
     *   Примечание: если давление измеряется в кПа, то нормальное тоже должно быть в кПа (101,33 кПа).
     *   
     *   В данном случае результат нормального объема получаем в литрах, вопреки РД 52.04.893-2020, т.к. ориентируемся на данные пробоотборных 
     *   устройств, где объем вычисляется также в литрах.
     *   
     *   Учитываем, что 1 дециметр куб., достаточно примерно равен 1 литру.
     */

    double GetNormalVolume()
    {
        var normal_volume = (parameter_values[0] * Current_area_reference_temperature_index * parameter_values[2]) /
                            ( (FormulaConstants.ATMOS_REFERENCE_TEMPERATURE_INDEX + parameter_values[1]) * FormulaConstants.REFERENCE_PRESSURE_INDEX);

        return Math.Round(normal_volume);
    }
}