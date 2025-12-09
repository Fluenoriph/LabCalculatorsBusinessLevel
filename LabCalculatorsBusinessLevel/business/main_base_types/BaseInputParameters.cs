// * Файл "BaseInputParameters.cs": базовый класс входных параметров калькулятора. *

abstract class BaseInputParameters<TDataType>
{
    public abstract List<TDataType> Values { get; }
}
