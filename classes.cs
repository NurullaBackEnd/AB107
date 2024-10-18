//using System;

//namespace LearnThis
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Car car = new Car("Toyota", "Corolla", 12000.5, 4);
//            car.ShowFullInfo();

//            Motorcycle motorcycle = new Motorcycle("Honda", "CBR", 8000.2, 2);
//            motorcycle.ShowFullInfo();
//        }
//    }

//    class Vehicle
//    {
//        public string Brand;
//        public string Model;
//        public double Mile;

//        public Vehicle(string brand, string model, double mile)
//        {
//            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
//            {
//                throw new ArgumentException("Brand and Model cannot be null or empty.");
//            }

//            Brand = brand;
//            Model = model;
//            Mile = mile;
//        }
//    }

//    class Car : Vehicle
//    {
//        public int DoorsNum;

//        public Car(string brand, string model, double mile, int doorsNum)
//            : base(brand, model, mile)
//        {
//            DoorsNum = doorsNum;
//        }

//        public void ShowFullInfo()
//        {
//            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors: {DoorsNum}");
//        }
//    }

//    class Motorcycle : Vehicle
//    {
//        public int WheelNum;

//        public Motorcycle(string brand, string model, double mile, int wheelNum)
//            : base(brand, model, mile)
//        {
//            WheelNum = wheelNum;
//        }

//        public void ShowFullInfo()
//        {
//            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Wheels: {WheelNum}");
//        }
//    }
//}

////Task1

//using System;

//namespace LearnThisSheet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Notebook notebook = new Notebook("Dell XPS", "High-end laptop", 10, true, 1500.00, 16, 512);

//            notebook.Sale();

//            notebook.ShowFullData();
//        }
//    }

//    class Product
//    {
//        public string Name;
//        public string Description;
//        public int Count;
//        public bool IsStock;
//        public double Price;

//        public Product(string name, string description, int count, bool isStock, double price)
//        {
//            if (string.IsNullOrWhiteSpace(name) || count <= 0 || price <= 0)
//            {
//                throw new ArgumentException("Name, Count and Price must be provided and valid.");
//            }

//            Name = name;
//            Description = description;
//            Count = count;
//            IsStock = isStock;
//            Price = price;
//        }

//        public void Sale()
//        {
//            if (Count > 0)
//            {
//                Count--;
//                if (Count == 0)
//                {
//                    IsStock = false;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Məhsul yoxdur!");
//            }
//        }
//    }

//    class Notebook : Product
//    {
//        public byte RAM;
//        public int Storage;

//        public Notebook(string name, string description, int count, bool isStock, double price, byte ram, int storage)
//            : base(name, description, count, isStock, price)
//        {
//            if (ram <= 0 || storage <= 0)
//            {
//                throw new ArgumentException("RAM and Storage must be provided and valid.");
//            }

//            RAM = ram;
//            Storage = storage;
//        }

//        public string GetFullInfo()
//        {
//            return $"Name: {Name}, Description: {Description}, Count: {Count}, In Stock: {IsStock}, Price: {Price}, RAM: {RAM}GB, Storage: {Storage}GB";
//        }

//        public void ShowFullData()
//        {
//            if (IsStock)
//            {
//                Console.WriteLine(GetFullInfo());
//            }
//            else
//            {
//                Console.WriteLine("Məhsul yoxdur!");
//            }
//        }
//    }
//}

////task2