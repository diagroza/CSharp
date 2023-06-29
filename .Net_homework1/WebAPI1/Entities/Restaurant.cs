namespace WebAPI1.Entities
{
    public class Restaurant : BaseClass
    {
     
        public string Name { get; set; } = default!;
        public int Stars { get; set; }
        public string Location { get; set; } = default!;

        public string? Description { get; set; }
        public List<Table> Tables { get; set; } = new List<Table>();

    }
}
