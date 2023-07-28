namespace Hastane.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}