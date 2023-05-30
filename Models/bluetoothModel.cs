using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace desafioBluetooth.Models
{
    [Table("BluetoothDeviceMobile")]
    public class bluetoothModel
    {
        [Column("Id")]
        [DisplayName("#")]
        public int Id { get; set; }

        [Column("Periodo")]
        [DisplayName("Periodo")]
        public string Periodo { get; set; }

        [Column("MAC")]
        [DisplayName("MAC User Bluetooth")]
        public string MAC { get; set; }

        [Column("MACScan")]
        [DisplayName("MACScan Bluetooth")]
        public string MACScan { get; set; }

        [Column("MACPaired")]
        [DisplayName("MACPaired Bluetooth")]
        public string MACPaired { get; set; }

        [Column("DataHoraEvento")]
        [DisplayName("Data/Hora Evento")]
        public DateTime DataHoraEvento { get; set; }

        [Column("FlagProcess")]
        [DisplayName("Processamento")]
        public bool FlagProcess { get; set; }

        [Column("ApplicationUserId")]
        [DisplayName("Usuário Execução")]
        public string ApplicationUserId { get; set; }

     
    }
}
