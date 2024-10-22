public class Group
{
    public string GroupNo { get; set; }
    public int StudentLimit { get; set; }
    private Student[] Students;
    private int currentStudentCount = 0;

    public Group(string groupNo, int studentLimit)
    {
        if (studentLimit < 5 || studentLimit > 18)
        {
            throw new Exception("Student limit must be between 5 and 18.");
        }

        if (!CheckGroupNo(groupNo))
        {
            throw new Exception("Group number must consist of 2 uppercase letters followed by 3 digits.");
        }

        GroupNo = groupNo;
        StudentLimit = studentLimit;
        Students = new Student[StudentLimit];
    }

    public bool CheckGroupNo(string groupNo)
    {
        if (groupNo.Length == 5 &&
            groupNo.Take(2).All(char.IsUpper) &&
            groupNo.Skip(2).All(char.IsDigit))
        {
            return true;
        }
        return false;
    }

    public void AddStudent(Student student)
    {
        if (currentStudentCount < StudentLimit)
        {
            Students[currentStudentCount++] = student;
        }
        else
        {
            throw new Exception("Cannot add more students, limit reached.");
        }
    }

    public Student GetStudent(int? id)
    {
        if (id == null) return null;
        return Students.FirstOrDefault(s => s != null && s.Id == id);
    }

    public Student[] GetAllStudents()
    {
        return Students.Where(s => s != null).ToArray();
    }
}
