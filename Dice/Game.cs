namespace Dice
{
    public class Game
    {
        int trials = 3;
        int _randomNumber = new RandomNumberGenerator().NumberGenerator();
        DataValidator validator = new DataValidator();
        TextMessages txt = new TextMessages();
        GameRules rules = new GameRules();
        InputValidator input = new InputValidator();
       
        public void Run()
        {
            txt.Introduction();
            do
            {
                string? userChoice = Console.ReadLine();


                if(userChoice ==null)
                {
                    txt.IncorrectInput();
                    continue;
                }


                if (input.IsInvalid(userChoice, out int guess))
                {
                    txt.IncorrectInput();
                    continue;
                }
                if (rules.IsCorrectGuess(guess, _randomNumber))
                {
                    txt.Win();
                    break;
                }
                trials--;
                if (validator.IsNull(trials))
                {
                    txt.WrongNumber();
                    txt.Lose();
                    break;
                }
                txt.WrongNumber();
                txt.EnterNumber();
            } while (validator.IsGreaterThanZero(trials));
        }


    }







}
