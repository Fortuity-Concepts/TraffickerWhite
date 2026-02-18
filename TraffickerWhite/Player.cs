using System.Security.Cryptography.X509Certificates;

namespace TextAdventureGame
{
    public class Player
    {
        public int Health;
        public int Gold;
        public int Experience;
        public string[] Inventory;
        public Location CurrentLocation;

        public Player(int startingHealth, int startingGold, Location startingLocation)
        {
            Health = startingHealth;
            Gold = startingGold;
            CurrentLocation = startingLocation;

            Inventory = new string[10];

        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void GiveGold(int amount)
        {
            Gold += amount;
        }
    }
}