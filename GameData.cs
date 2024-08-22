namespace battleShip
{
    public class GameData
    {
        // Properties to store player and game data
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

        public List<string> Player1Figures { get; set; }
        public List<string> Player2Figures { get; set; }

        public GameData()
        {
            Player1Figures = new List<string>();
            Player2Figures = new List<string>();
        }
    }
}
