//

static class DustCalcsResultError                        
{
    public static double GetResultError(double mass_concentrate, double error_index)
    {
        return Math.Round(error_index * mass_concentrate, FractionalDigits.TWO);
    } 
}
