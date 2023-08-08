namespace Model.Entities
{
    public class Floor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
