namespace Assignment.Model
{
    public class Course
    {
        public int Course_Id { get; set; }
        public Teacher Course_Mentor { get; set; }
        public string Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string? Description { get; set; }
        public bool Is_Active { get; set; }
    }
}
