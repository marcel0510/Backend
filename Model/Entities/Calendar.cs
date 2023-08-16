namespace Model.Entities
{
    public class Calendar: BaseEntity
    {
        public string Period { get; set; }
        public DateTime PeriodInit { get; set; }
        public DateTime PeriodEnd { get; set;}
        public List<Group> Groups { get; set; }
    }
}
