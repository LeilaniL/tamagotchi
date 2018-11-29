using System.Collections.Generic;
namespace DigitalPet.Models
{
    public class Tamagotchi
    {
        private string _name;
        private int _fed;
        private int _happy;
        private int _rested;
        private int _id;
        private static List<Tamagotchi> _instances = new List<Tamagotchi> { };

        public Tamagotchi(string name)
        {
            _name = name;
            _fed = 20;
            _happy = 20;
            _rested = 20;
            _instances.Add(this);
            _id = _instances.Count;

        }

        public string GetName()
        {
            return _name;
        }
        public int GetFood()
        {
            return _fed;
        }
        public void Feed(int food)
        {
            _fed = food;
        }
        public int GetHappiness()
        {
            return _happy;
        }
        public void GiveAttention(int attention)
        {
            _happy = attention;
        }
        public int GetRest()
        {
            return _rested;
        }
        public void Rest(int sleep)
        {
            _rested = sleep;
        }

        public static List<Tamagotchi> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public int GetId()
        {
            return _id;
        }
        public static Tamagotchi Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}