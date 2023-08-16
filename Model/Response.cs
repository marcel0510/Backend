namespace Model
{
    public class Response
    {
        public bool Ok { get; set; }
        public int ErrorType { get; set; }
        public List<int> Groups { get; set; } = new List<int> { 0 };

    }
}
