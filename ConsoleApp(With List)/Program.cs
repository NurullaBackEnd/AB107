public class Program
{
    private static AppDbContext dbContext = new AppDbContext();

    public static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("******Menu******");
            Console.WriteLine("1. Sisteme giris");
            Console.WriteLine("0. Cixis");
            Console.Write("Seciminiz: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SystemLogin();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin!");
                    break;
            }
        }
    }

    private static void SystemLogin()
    {
        bool back = false;

        while (!back)
        {
            Console.WriteLine("\n1. Hotel yarat");
            Console.WriteLine("2. Butun Hotelleri gor");
            Console.WriteLine("3. Hotel sec");
            Console.WriteLine("0. Exit");
            Console.Write("Seciminiz: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateHotel();
                    break;
                case 2:
                    ShowAllHotels();
                    break;
                case 3:
                    SelectHotel();
                    break;
                case 0:
                    back = true;
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin!");
                    break;
            }
        }
    }

    private static void CreateHotel()
    {
        Console.Write("Hotel adını daxil edin: ");
        string name = Console.ReadLine();
        dbContext.AddHotel(new Hotel(name));
        Console.WriteLine($"{name} oteli yaradildi.");
    }

    private static void ShowAllHotels()
    {
        var hotels = dbContext.GetAllHotels();
        if (hotels.Count == 0)
        {
            Console.WriteLine("Heç bir otel tapılmadı.");
            return;
        }

        foreach (var hotel in hotels)
        {
            Console.WriteLine($"ID: {hotel.Id}, Name: {hotel.Name}");
        }
    }

    private static void SelectHotel()
    {
        Console.Write("Hotelin adını daxil edin: ");
        string name = Console.ReadLine();
        Hotel hotel = dbContext.SelectHotel(name);

        if (hotel == null)
        {
            Console.WriteLine("Belə bir hotel tapılmadı.");
            return;
        }

        HotelMenu(hotel);
    }

    private static void HotelMenu(Hotel hotel)
    {
        bool back = false;

        while (!back)
        {
            Console.WriteLine("\n1. Room yarat");
            Console.WriteLine("2. Roomlari gor");
            Console.WriteLine("3. Rezervasya et");
            Console.WriteLine("4. Evvelki menuya qayit");
            Console.WriteLine("0. Exit");
            Console.Write("Seciminiz: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateRoom();
                    break;
                case 2:
                    ShowAllRooms();
                    break;
                case 3:
                    MakeReservation();
                    break;
                case 4:
                    back = true;
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin!");
                    break;
            }
        }
    }

    private static void CreateRoom()
    {
        Console.Write("Room adı: ");
        string name = Console.ReadLine();
        Console.Write("Qiymet: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Person kapasitet: ");
        int capacity = int.Parse(Console.ReadLine());

        Room room = new Room(name, price, capacity);
        dbContext.AddRoom(room);
        Console.WriteLine($"{name} otağı yaradıldı.");
    }

    private static void ShowAllRooms()
    {
        var rooms = dbContext.FindAllRooms(r => true);
        if (rooms.Count == 0)
        {
            Console.WriteLine("Heç bir otaq tapılmadı.");
            return;
        }

        foreach (var room in rooms)
        {
            Console.WriteLine(room);
        }
    }

    private static void MakeReservation()
    {
        Console.Write("Room ID daxil edin: ");
        int roomId = int.Parse(Console.ReadLine());
        Console.Write("Müşteri sayi: ");
        int personCount = int.Parse(Console.ReadLine());

        try
        {
            dbContext.MakeReservation(roomId, personCount);
            Console.WriteLine("Rezervasiya uğurla edildi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Xəta: {ex.Message}");
        }
    }
}
