namespace Dice
{
    public class RandomNumberGenerator
    {
        private static Random rnd = new Random();

        public int NumberGenerator()
        {
            
            return rnd.Next(1, 7);
        }

    }







}
