namespace Dice
{
    public class InputValidator
    {
        public bool IsInvalid(string input, out int guess)
        {
            return !int.TryParse(input, out guess) || string.IsNullOrEmpty(input);
        }
    }







}
