namespace WebApp1.Models
{
    public class Taskss
    {
        public Taskss() { }

        public int? Id { get; set; }
        public string? Title { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? duedate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
