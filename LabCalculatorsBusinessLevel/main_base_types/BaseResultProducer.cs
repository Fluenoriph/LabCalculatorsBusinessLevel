// * Файл "IResultProducer.cs": интерфейс 

abstract class BaseResultProducer<T>
{
    protected abstract T Result_report { get; }
    public string? Result_viewer { get; set; }  
}
