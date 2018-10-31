using System.Collections.Generic;

namespace TournamentLib
{
    public class Round
    {
        private List<Match> matches = new List<Match>();

        private string freeRider;
        public string FreeRider {
            get { return freeRider; }
            set { freeRider = value; }
        }

        public void AddMatch(Match m)
        {
            matches.Add(m);
        }

        public Match GetMatch(string teamName1, string teamName2)
        {
            // TODO: Implement this method
            return null;
        }

        public Match GetMatch(string team)
        {
            int i = 0;
            bool matchFound = true;
            
            while (matchFound)
            {
                if (matches[i].Winner == )
                {

                    matchFound = false;
                }
                i = i + 1;
                    
            }
            return matches[i];
        }

        public bool IsMatchesFinished()
        {
            bool matchesFinished = true;
            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].Winner == null)
                    matchesFinished = false;
            }
            return matchesFinished;
        }

        public List<Team> GetWinningTeams()
        {
            List<Team> list = new List<Team>();
            for (int i = 0; i < matches.Count; i++)
            {
                list.Add(matches[i].Winner);
            }
            return list;
        }

        public List<Team> GetLosingTeams()
        {
            List<Team> list = new List<Team>();
            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].FirstOpponent==matches[i].Winner)
                {
                    list.Add(matches[i].SecondOpponent);
                }
                else if (matches[i].SecondOpponent == matches[i].Winner)
                {
                    list.Add(matches[i].FirstOpponent);
                }
            }
            return list;
        }
    }
}
