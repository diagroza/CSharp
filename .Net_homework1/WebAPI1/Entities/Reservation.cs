namespace WebAPI1.Entities
{
    public class Reservation :BaseClass
    {
  
        public string ClientName { get; set; } = default!;
        public DateTime Date { get; set; }
        public Table Table { get; set; } = default!;
        public int TableId { get; set; }
    }
}
