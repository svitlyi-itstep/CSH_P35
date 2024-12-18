using CSH_P35.Game.Spells;

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
        protected string? name;
        protected int health;
        protected int damage;
        protected int defence;
        protected Race race;
        protected Spell[] spellsList = {new Fireball()};

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

        public void CastRandomSpell(Character target)
        {
            Random rnd = new Random(Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds()));
            int spell_index = rnd.Next(0, this.spellsList.Length);
            this.spellsList[spell_index].cast(target);
        }

        public void print()
        {
            Console.WriteLine($"-< {name} >-");
            Console.WriteLine($" Здоров\'я: {health}");
            Console.WriteLine($" Шкода: {damage}");
            Console.WriteLine($" Захист: {defence}");
            Console.WriteLine($" Раса: {race}");
        }

        public virtual int takeDamage(int damage)
        {
            health = Math.Max(health - damage, 0);
            return damage;
        }

        public virtual int attack(Character target)
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

        public override string ToString()
        {
            return $"Character(name={this.name}, health={this.health}, damage={this.damage}, " +
                $"defence={this.defence}, race={this.race})";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Character))
                return false;
            return this.name == ((Character)obj).name &&
                this.health == ((Character)obj).health &&
                this.damage == ((Character)obj).damage &&
                this.defence == ((Character)obj).defence &&
                this.race == ((Character)obj).race;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }

    class Berserk: Character
    {
        // Множник шкоди при низькому здоров`ї
        double rageMultiplier = 1.5;
        // Чи є останній шанс
        bool lastChance = true;

        public Berserk(string? name, int health, int damage, int defence, Race race = Race.Human) 
            : base(name, health, damage, defence, race) { }
        public Berserk() : this("Jonny", 100, 5, 0, Race.Human) { }

        public override int takeDamage(int damage)
        {
            health = Math.Max(health - damage, 0);
            // Механіка останнього шансу
            if(this.health <= 0 && lastChance)
            {
                this.health = 1; lastChance = false;
            }
            return damage;
        }

        public override int attack(Character target)
        {
            int final_damage = (int)(this.damage * this.RaceAttackBonus(target.Race));
            final_damage = this.health < 50 ? (int)(final_damage * rageMultiplier) : final_damage;
            return target.takeDamage(final_damage);
        }

        public override string ToString()
        {
            return $"Berserk(name={this.name}, health={this.health}, damage={this.damage}, " +
                $"defence={this.defence}, race={this.race}, rageMultiplier={this.rageMultiplier}, " +
                $"lastChance={this.lastChance})";
        }
    }
}