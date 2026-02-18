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

        public Player(int startingHealth, int startingGold, int startingExperience, Location startingLocation)
        {
            Health = startingHealth;
            Gold = startingGold;
            Experience = startingExperience;
            CurrentLocation = startingLocation;

            Inventory = new string[10];

        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void GiveHealth(int amount)
        {
            Health += amount;
        }

        public void GiveGold(int amount)
        {
            Gold += amount;
        }

        public void TakeGold(int amount)
        {
            Gold -= amount;
        }

        public void GiveExperience(int amount)
        {
            Experience += amount;
        }

        public void TakeExperience(int amount)
        {
            Experience -+ amount;
        }
    }
}