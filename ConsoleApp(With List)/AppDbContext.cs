using ConsoleApp_With_List_;

public class AppDbContext
{
    private List<Room> rooms = new List<Room>();
    private List<Hotel> hotels = new List<Hotel>();

    public void AddRoom(Room room)
    {
        if (room != null)
        {
            rooms.Add(room);
        }
    }

    public List<Room> FindAllRooms(Func<Room, bool> predicate)
    {
        return rooms.Where(predicate).ToList();
    }

    public void MakeReservation(int? roomId, int personCount)
    {
        if (roomId == null)
        {
            throw new NullReferenceException("Room ID boş ola bilməz.");
        }

        Room room = rooms.FirstOrDefault(r => r.Id == roomId);

        if (room == null)
        {
            throw new KeyNotFoundException("Belə bir otaq tapılmadı.");
        }

        if (!room.IsAvailable)
        {
            throw new NotAvailableException("Otaq mövcud deyil.");
        }

        if (room.PersonCapacity < personCount)
        {
            throw new ArgumentException("Şəxsi kapasitet kifayət deyil.");
        }

        room.IsAvailable = false;
    }

    public void AddHotel(Hotel hotel)
    {
        if (hotel != null && !hotels.Any(h => h.Name == hotel.Name))
        {
            hotels.Add(hotel);
        }
    }

    public List<Hotel> GetAllHotels()
    {
        return hotels;
    }

    public Hotel SelectHotel(string name)
    {
        return hotels.FirstOrDefault(h => h.Name == name);
    }
}
