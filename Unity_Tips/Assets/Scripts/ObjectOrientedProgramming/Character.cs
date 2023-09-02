namespace Tips.ObjectOrientedProgramming
{
    public abstract class Character
    {
        protected string _characterName;

        protected int _health;

        public Character(string characterName, int health)
        {
            _characterName = characterName;
            _health = health;
        }

        public abstract void PerformAction();
    }
}