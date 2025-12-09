// * Файл "BaseValueRanges.cs": базовый класс - диапазоны валидации входных параметров. *

abstract class BaseValueRanges
{
    public List<(int, int)> Ranges { get; } = [];
}
