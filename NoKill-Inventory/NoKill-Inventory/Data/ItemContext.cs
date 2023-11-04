using Microsoft.EntityFrameworkCore;

namespace NoKill_Inventory.Data;

public class ItemContext : DbContext
{
    public DbSet<Item> Inventory { get; set; }
}