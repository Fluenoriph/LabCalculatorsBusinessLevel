// Контекст данных входных параметров калькулятора. 

class AirDustCalcParametersData       // для контекста скорей всего нужны базовые типы DbSet<base_type> ??
{
    public int Id { get; set; }
    public double Volume { get; set; } 
    public double Temperature { get; set; } 
    public double Pressure { get; set; } 
    public double MassBefore { get; set; } 
    public double MassAfter { get; set; } 
    public int RegisterId { get; set; }
}
