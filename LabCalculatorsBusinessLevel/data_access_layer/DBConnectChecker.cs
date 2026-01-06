using Microsoft.EntityFrameworkCore;


sealed class DBConnectChecker
{
    public static bool CheckAvailability(DbContext current_db_context)
    {
        return current_db_context.Database.CanConnect();
    }
}
