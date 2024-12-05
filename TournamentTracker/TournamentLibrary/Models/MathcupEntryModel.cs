namespace TournamentLibrary.Models
{
    public class MathcupEntryModel
    {

        //represents one team in the matchup (bracket od 2 tima)
        public TeamModel TeamCompeting { get; set; }

        // score of that team
        public double Score { get; set; }

        //represents the matchup that this team came from as a winner
        public MatchupModel ParentMatchup { get; set; }
    }
}