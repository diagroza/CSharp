namespace WebAPI1.Entities
{
    public class Table : BaseClass
    {
        
        public int Number  { get; set; }
        public int RestaurantId { get; set; }
        public Reservation Reservation { get; set; } = default!;
    }
}
