
namespace Week10_ConsoleApp.Unit3
{
    class T42_Game
    {
        private string player;
        private int aliens;
        private int treasure;
        private int hours;

        public void InputValues()
        {
            UserLib.WriteTitle("Game Score");

            player = UserLib.GetString("Your name > ");
            aliens = UserLib.GetInt("How many aliens have you killed > ");
            treasure = UserLib.GetInt("How much treasure have you found > ");
            hours = UserLib.GetInt("How many hours did you play > ");
        }

        public void CalculateScore()
        {

        }

        public void DisplayRawScore()
        {

        }

        public void DisplayFinalScore()
        {

        }
    }
}
