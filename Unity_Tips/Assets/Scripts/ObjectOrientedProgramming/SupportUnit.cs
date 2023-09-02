namespace Tips.ObjectOrientedProgramming
{
    public class SupportUnit : Unit
    {
        private int _healPoints;

        public SupportUnit(string unitName, int health, int healPoints) : base(unitName, health)
        {
            _healPoints = healPoints;
        }

        public void Heal(Unit unitToHeal)
        {
            unitToHeal.Health += _healPoints;
        }
    }
}