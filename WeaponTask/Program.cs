class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Darağı yaradın:");
        Console.Write("Güllə tutumu: ");
        int magazineCapacity = int.Parse(Console.ReadLine());
        Console.Write("İlk güllə sayı: ");
        int initialBulletCount = int.Parse(Console.ReadLine());
        Console.Write("Atış modu (0 - Təkli, 1 - Avtomatik): ");
        bool isAutomatic = Console.ReadLine() == "1";

        Weapon weapon = new Weapon(magazineCapacity, initialBulletCount, isAutomatic);

        while (true)
        {
            Console.WriteLine("\nSeçim edin: 0 - İnformasiya, 1 - Shoot, 2 - Fire, 3 - GetRemainBulletCount, 4 - Reload, 5 - ChangeFireMode, 6 - Dayandır");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine($"Darağın güllə tutumu: {weapon.MagazineCapacity}, Hazırda güllə sayı: {weapon.CurrentBulletCount}, Atış modu: {(weapon.IsAutomatic ? "Avtomatik" : "Təkli")}");
                    break;
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    weapon.GetRemainBulletCount();
                    break;
                case 3:
                    Console.WriteLine($"Tam dolması üçün lazım olan güllə sayı:  {weapon.GetRemainBulletCount()}");
                    break;
                case 4:
                    weapon.Reload();
                    break;
                case 5:
                    weapon.ChangeFireMode();
                    break;
                case 6:
                    return;
                default:    
                    Console.WriteLine("Yanlış seçim. Yenidən cəhd edin.");
                    break;
            }
        }
    }
}