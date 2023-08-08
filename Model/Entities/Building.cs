namespace Model.Entities
{
    public class Building: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; } 
        public List<Floor> Floors { get; set; }
        public List<Classroom> Classrooms { get; set; } 
    }
}
