

sealed class FormulaTypeCalculatorDBSession(int calc_type_value, List<double> parameters, List<double> results) 
           : BaseLabCalcsDBSession<double>(calc_type_value, parameters, results), ICreateOperation
{
    public async Task CreateDataSet()
    {
        using LabCalcsContext database_context = new();

        if (database_context.Database.CanConnect())      
        {
            await using var transaction = await database_context.Database.BeginTransactionAsync();

            try
            {
                RegistrationTime reg_time_data = new() { CalcTypeId = calc_type_value };
                database_context.RegistrationTime.Add(reg_time_data);
                await database_context.SaveChangesAsync();

                database_context.FormulaTypeCalculatorData.Add(new FormulaTypeCalculatorData
                { Parameter = parameters, Result = results, RegTimeId = reg_time_data.RegTimeId });
                await database_context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                // ????
                Console.WriteLine(ex.ToString());
            }
        }
        else
        {
            Console.WriteLine("\nDatabase connection error ! Check the program !\n");
        }
    }
}
