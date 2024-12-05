namespace TournamentLibrary.Models
{
    public class MatchupModel
    {
        //set of teams that are in this match (two teams)
        public List<MathcupEntryModel> Entries { get; set; } = new List<MathcupEntryModel>();

        //winner of the matchup
        public TeamModel Winner { get; set; }

        //which round this matchup is part of
        public int MatchupRound { get; set; }

    }
}