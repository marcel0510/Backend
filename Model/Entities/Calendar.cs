namespace Model.Entities
{
    public class Calendar: BaseEntity
    {
        public string Period { get; set; }
        public DateTime PeriodInit { get; set; }
        public DateTime PeriodEnd { get; set;}
        List<Group> Groups { get; set; }
    }
}
