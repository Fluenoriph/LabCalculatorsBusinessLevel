// * Файл "BaseResultViewer.cs": базовый класс для обозревателей результата в консоли. *

abstract class BaseResultViewer<TData, TReport>(List<TData> result_data)
{
    protected List<TData> result_data = result_data;
    protected abstract TReport Result_report { get; } // Объяснение результатов.

    public string? Produced_result { get; set; } // Для вывода в консоль.
}
