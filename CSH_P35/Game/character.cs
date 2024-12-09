﻿namespace CSH_P35.Game
{
    enum Race
    {
        Human,
        Ork,
        Elf,
        Dwarf
    }

    class Character
    {
        string? name;
        int health;
        int damage;
        int defence;
        Race race;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = Math.Max(value, 0); }
        }

        public Character() : this("Jonny", 100, 5, 0, Race.Human) { }
        public Character(string? name, int health, int damage, int defence, Race race = Race.Human)
        {
            this.name = name;
            Health = health;
            this.damage = damage;
            this.defence = defence;
            this.race = race;
        }
        public void print()
        {
            Console.WriteLine($"-< {name} >-");
            Console.WriteLine($" Здоров\'я: {health}");
            Console.WriteLine($" Шкода: {damage}");
            Console.WriteLine($" Захист: {defence}");
            Console.WriteLine($" Раса: {race}");
        }

        public int takeDamage(int damage)
        {
            health = Math.Max(health - damage, 0);
            return health;
        }

        public void attack(Character target)
        {
            target.takeDamage(damage);
        }

        public bool isAlive()
        {
            return health > 0;
        }
    }
}