public class Room
{
    private static int _nextId = 1;
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public int PersonCapacity { get; }
    public bool IsAvailable { get; set; } = true;

    public Room(string name, double price, int personCapacity)
    {
        if (string.IsNullOrEmpty(name) || price <= 0 || personCapacity <= 0)
        {
            throw new ArgumentException("Name, Price və PersonCapacity dəyərləri lazımdır.");
        }

        Id = _nextId++;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }

    public string ShowInfo()
    {
        return $"Room ID: {Id}, Name: {Name}, Price: {Price}, Capacity: {PersonCapacity}, Available: {IsAvailable}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}
