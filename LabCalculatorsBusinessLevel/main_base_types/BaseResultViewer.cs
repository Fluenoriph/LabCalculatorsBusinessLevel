// * Файл "IResultProducer.cs": интерфейс 

abstract class BaseResultViewer<T>     // may be interface ???
{
    protected abstract T Result_report { get; }
    public string? Produced_result { get; set; }  
}
