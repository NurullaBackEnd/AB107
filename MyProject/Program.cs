public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            User user1 = new User("Ali Veli", "ali@example.com", "Password123");
            user1.ShowInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Student student1 = new Student("Nurulla Ibadov", 100);
        Student student2 = new Student("Jesse Jackson", 20);

        student1.StudentInfo();
        student2.StudentInfo();

        try
        {
            Group group1 = new Group("AB107", 10);

            group1.AddStudent(student1);
            group1.AddStudent(student2);

            Student retrievedStudent = group1.GetStudent(student1.Id);
            retrievedStudent.StudentInfo();

            foreach (var student in group1.GetAllStudents())
            {
                student.StudentInfo();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
