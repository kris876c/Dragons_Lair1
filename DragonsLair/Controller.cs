using System;
using System.Collections.Generic;
using System.Linq;
using TournamentLib;

namespace DragonsLair
{
    public class Controller
    {
        private TournamentRepo tournamentRepository = new TournamentRepo();

        public void ShowScore(string tournamentName)
        {
            /*
             * TODO: Calculate for each team how many times they have won
             * Sort based on number of matches won (descending)
             */
            Console.WriteLine("Implement this method!");
        }

        public TournamentRepo GetTournamentRepository()
        {
            return tournamentRepository;
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {
            Tournament t = tournamentRepository.GetTournament(tournamentName);
            int numberOfRounds = t.GetNumberOfRounds();
            Round lastRound;
            bool isRoundFinished;
            List<Team> teams = new List<Team>();            

            if (numberOfRounds == 0)
            {
                lastRound = null;
                isRoundFinished = true; // Lidt i tvivl om hvordan dette skal kodes
            }
            else
            {
                lastRound = t.GetRound(numberOfRounds - 1);
                isRoundFinished = lastRound.IsMatchesFinished();
            }
            if (isRoundFinished)
            {
                if (lastRound == null)
                {
                    teams = t.GetTeams();
                }
                else
                {
                    teams = lastRound.GetWinningTeams();
                    if (lastRound.FreeRider != null)
                    {
                        //teams.Add(lastround.FreeRider); // FreeRider ikke implementeret
                    }
                }
                if (teams.Count >= 2)
                {
                    Round newRound = new Round();
                    //teams.shuffle
                    //odd number of teams in scrambled
                    for (int i = 0; i < teams.Count; i++)
                    {
                        Match match = new Match();
                        match.FirstOpponent = teams[i];
                        i++;
                        match.SecondOpponent = teams[i];
                        newRound.AddMatch(match);                        
                    }
                    t.AddRound(newRound);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void SaveMatch(string tournementName,int roundNo,string winningTeamName)
        {
        }


        public void AddGame(string AddName)
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
