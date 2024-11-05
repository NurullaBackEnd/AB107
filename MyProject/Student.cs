public class Student
{
    private static int _counter = 0;
    public int Id { get; }
    public string Fullname { get; set; }
    public double Point { get; set; }

    public Student(string fullname, double point)
    {
        Id = ++_counter;
        Fullname = fullname;
        Point = point;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Point: {Point}");
    }
}
