// Замена точки на запятую. Российская локализация.
// При получении целого числа, добавим запятую и ноль для вывода результата.

using System.Globalization;


static class RussianLocaleConverter
{
    public static string Convert(double value)
    {
        if (Math.Truncate(value) != value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }
        else
        {
            return $"{value},0";
        }
    }
}
