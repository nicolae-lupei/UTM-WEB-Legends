using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UTM.DLL.Models;
using UTM.DLL.Models.HostelModels;

namespace UTM.DLL.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomInventory> RoomInventories { get; set; }
    }
}
