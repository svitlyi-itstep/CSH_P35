namespace CSH_P35.Game
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
        public Race Race { 
            get { return race; } 
            set { race = value; }
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
        public Character(string name, Race race)
        {
            this.name = name;
            this.Race = race;
            if(race == Race.Human)
            {
                this.health = 100;
                this.damage = 5;
                this.defence = 2;
            }
            else if (race == Race.Ork)
            {
                this.health = 120;
                this.damage = 6;
                this.defence = 0;
            }
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

        public int attack(Character target)
        {
            int final_damage = (int)(this.damage * this.RaceAttackBonus(target.race));
            
            return target.takeDamage(final_damage);
        }

        public bool isAlive()
        {
            return health > 0;
        }

        public double RaceAttackBonus(Race targetRace)
        {
            if (targetRace == this.race) 
            {
                return 1;
            }
            else if (targetRace == Race.Ork)
            {
                return 0.9;
            }
            else
            {
                return 1.1;
            }
        }
    }

    class Berserk: Character
    {

    }
}