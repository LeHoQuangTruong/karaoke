using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.Model
{
    public class KaraDB: DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomService> RoomServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }


        public string DbName = "KaraDb.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string path = Path.Combine("D:", DbName);
            string path = Path.Combine(Application.StartupPath, DbName);// đường dẫn chạy file debug bài miềng
            optionsBuilder.UseSqlite($"Data source={path}");

            //optionsBuilder.UseSqlServer("Connection String");
        }

    }
}
