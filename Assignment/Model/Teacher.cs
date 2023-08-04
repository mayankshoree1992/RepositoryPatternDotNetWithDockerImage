using Microsoft.AspNetCore.Mvc;

namespace Assignment.Model
{
    public class Teacher
    {
        public int Teacher_Id { get; set; }
        public string Name { get; set; }
        public bool Is_Active { get; set; }
        public string Desigination { get; set; }
    }
}
