public class Hotel
{
    private static int _nextId = 1;
    public int Id { get; }
    public string Name { get; }

    public Hotel(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Hotel adını boş saxlaya bilməzsiniz.");
        }

        Id = _nextId++;
        Name = name;
    }
}
