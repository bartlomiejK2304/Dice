namespace Dice
{
    public class DataValidator
    {
        public bool IsNull(int trials)
        {
            return trials == 0;
        }

        public bool IsGreaterThanZero(int trials)
        {
            return trials > 0;
        }

    }







}
