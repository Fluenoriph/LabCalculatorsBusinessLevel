using NoiseCaclculatorData;

sealed class NoiseCalculatorDBSession(int calc_type_value, List<List<double>> parameters, List<List<double>> results)
           : BaseLabCalcsDBSession<List<double>>(calc_type_value, parameters, results), ICreateOperation
{
    public async Task CreateDataSet()
    {
        using LabCalcsContext database_context = new();
        await using var transaction = await database_context.Database.BeginTransactionAsync();

        try
        {
            RegistrationTime reg_time_data = new() { CalcTypeId = calc_type_value };
            database_context.RegistrationTime.Add(reg_time_data);
            await database_context.SaveChangesAsync();

            database_context.NoiseCalculatorData.Add(new NoiseCalculatorData
            { SourceLevel = parameters[NoiseLevelTypeIndex.SOURCE], BackgroundLevel = parameters[NoiseLevelTypeIndex.BACKGROUND],
              Delta = results[NoiseLevelTypeIndex.DELTA], Result = results[NoiseLevelTypeIndex.FIXED], RegTimeId = reg_time_data.RegTimeId });

            await database_context.SaveChangesAsync();

            await transaction.CommitAsync();
        }
        catch (Exception ex) // What is Exception type ???
        {
            // ????
            Console.WriteLine(ex.ToString());
        }
    }
}