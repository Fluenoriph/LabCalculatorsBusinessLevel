
abstract class BaseLabCalcsDBSession<TDataType>(int calc_type_value, List<TDataType> parameters, List<TDataType> results)
{
    protected readonly List<TDataType> parameters = parameters;
    protected readonly List<TDataType> results = results;
    protected int calc_type_value = calc_type_value;
}