
abstract class BaseLabCalcsDBSession<TDataType>
{
    protected int calc_type_value;
    protected readonly List<TDataType> parameters;
    protected readonly List<TDataType> results;

    public BaseLabCalcsDBSession(int calc_type_value, List<TDataType> parameters, List<TDataType> results)
    {
        this.calc_type_value = calc_type_value;
        this.parameters = parameters;
        this.results = results;

        // Возможно вынести эту проверку из класса вовне.

        if (CheckingTheDatabaseConnection())
        {
            Console.WriteLine("\nConnect is OK !\n");
        }
        else
        {
            Console.WriteLine("\nConnect is BAD !\n");
        }
    }

    static bool CheckingTheDatabaseConnection()
    {
        using LabCalcsContext database_context = new();

        if (database_context.Database.CanConnect())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}