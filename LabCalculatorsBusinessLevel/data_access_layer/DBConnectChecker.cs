using Microsoft.EntityFrameworkCore;


sealed class DBConnectChecker // ???? not needed
{
    public static bool CheckAvailability(DbContext current_db_context)
    {
        return current_db_context.Database.CanConnect();
    }
}
