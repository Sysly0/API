namespace StudentAPI.Models;

public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
    public string ClassDescription { get; set; }
    public Teacher ClassTeacher { get; set; }
    public List<Student> ClassStudents { get; set; }
}