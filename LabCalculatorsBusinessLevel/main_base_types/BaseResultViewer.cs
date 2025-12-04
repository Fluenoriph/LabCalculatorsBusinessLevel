// * Файл "IResultProducer.cs": интерфейс 

abstract class BaseResultViewer<TData, TReport>(TData result_data)
{
    protected TData result_data = result_data;
    protected abstract TReport Result_report { get; }

    public string? Produced_result { get; set; }
}
