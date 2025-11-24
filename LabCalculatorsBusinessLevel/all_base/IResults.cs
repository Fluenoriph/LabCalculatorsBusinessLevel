// * Файл "IResults.cs": интерфейс для результатов. *

using System.Globalization;


interface IResults
{
    // Результат с погрешностью.

    string? Result { get; }

    // * Замена точки на запятую. Российская локализация. *

    static string ConvertToRussianLocale(double value)    
    {
        // При получении целого числа, добавим запятую и ноль для вывода результата.

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
