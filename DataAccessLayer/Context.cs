using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Threading;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public interface IContext
    {
        DbSet<Room> Rooms { get; }

        DbSet<Reservation> Reservations { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
    public class Context: DbContext, IContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Filename=Database.sqlite");
    }
}
