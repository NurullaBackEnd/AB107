using System;

public class Weapon
{
    public int MagazineCapacity { get; private set; }
    public int CurrentBulletCount { get; private set; }
    public bool IsAutomatic { get; private set; }

    public Weapon(int magazineCapacity, int initialBulletCount, bool isAutomatic)
    {
        MagazineCapacity = magazineCapacity;
        CurrentBulletCount = initialBulletCount <= magazineCapacity ? initialBulletCount : magazineCapacity;
        IsAutomatic = isAutomatic;
    }
     public void Shoot()
    {
        if (MagazineCapacity > 0) {
            CurrentBulletCount--;
            Console.WriteLine($"{ CurrentBulletCount}  1 gulle atildi");
        }
    }   
    public int GetRemainBulletCount()
    { 
        int WeNeedHowMuchBullet = MagazineCapacity - CurrentBulletCount;
        return WeNeedHowMuchBullet; 
    } 
    public void Reload()
    {
        Console.WriteLine(MagazineCapacity);
    }
    public void ChangeFireMode()
    {
        if (MagazineCapacity > 0)
        {
            MagazineCapacity -= 4;
            Console.WriteLine($"{MagazineCapacity} 4 gulle atildi. " );
        }
    }
}
