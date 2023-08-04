namespace Assignment.Model
{
    public class RequestCourse
    {
        public int Course_Id { get; set; }
        public int Course_Mentor { get; set; }
        public string Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string? Description { get; set; }
        public bool Is_Active { get; set; }
    }
}
