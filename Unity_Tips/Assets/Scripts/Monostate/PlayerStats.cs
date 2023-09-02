namespace Patterns.Monostate
{
    public class PlayerStats
    {
        private static int m_Lifes = 3;

        public int lifes 
        {
            get 
            {
                return m_Lifes;
            }

            set
            {
                m_Lifes = value;
            }
        }


        public PlayerStats()
        {

        }
    }
}