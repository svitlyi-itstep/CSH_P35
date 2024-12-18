namespace CSH_P35.Game.Spells
{
    abstract class Spell
    {
        string? name;

        string? Name { get { return this.name; } }
        public abstract void cast(Character target);
    }

    class Fireball : Spell
    {
        string? name = "Вогняна куля";
        int damage = 13;

        public override void cast(Character target) {
            target.takeDamage(13);
        }
    }
}
