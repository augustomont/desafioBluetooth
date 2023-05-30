using Microsoft.EntityFrameworkCore;


namespace desafioBluetooth.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options)
        {
        }
        public DbSet<bluetoothModel> Bluetooth { get; set; }
    }
}
