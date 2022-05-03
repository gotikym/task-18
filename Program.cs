using System;
internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        byte minmalHpBoss = 0;
        int maxmumHpBoss = 1010;
        int hpBoss = random.Next(minmalHpBoss, maxmumHpBoss);
        byte damageForOneHit = 2;
        int powerOfDamage = 0;
        
        while (hpBoss > Math.Pow(damageForOneHit, powerOfDamage))
        {
            powerOfDamage++;
        }
        Console.WriteLine($"При уроне в {damageForOneHit} единицы от рукопашного боя - для сноса хлеборезки босса с {hpBoss} хп, " +
            $" достаточно {damageForOneHit}^{powerOfDamage} ударов кулаком");
    }
}
