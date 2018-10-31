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
            Round lastround;
            bool isRoundFinished;
            List<Team> teams = new List<Team>();            

            if (numberOfRounds == 0)
            {
                lastround = null;
                isRoundFinished = true; // Lidt i tvivl om hvordan dette skal kodes
            }
            else
            {
                lastround = t.GetRound(numberOfRounds - 1);
                isRoundFinished = lastround.IsMatchesFinished();
            }
            if (isRoundFinished)
            {
                if (lastround == null)
                {
                    teams = t.GetTeams();
                }
                else
                {
                    teams = lastround.GetWinningTeams();
                    if (lastround.FreeRider != null)
                    {
                        //teams.Add(lastround.FreeRider); // FreeRider ikke implementeret
                    }
                }
                if (teams.Count >= 2)
                {
                    Round newRound = new Round();
                    //teams.Shuffle
                    t.AddRound(newRound);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

            //Round round = new Round();
            //if (round.IsMatchesFinished())
            //{
            //    t.AddRound(round); // test
            //}

            //if (t.GetTeams().Capacity >= 8) //Måske måle på om alle matches er færdigspillet istedet for(da dette er specifikt)
            //{
            //    Round round = new Round(); // Tænker at der skal oprettes en ny runde
            //    t.AddRound(round); // runden skal tilføjes til en liste via metoden AddRound så man til sidst får det rigtige
            //}
        }

        private void SaveMatch()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Write("Angiv runde: ");
            int round = int.Parse(Console.ReadLine());
            Console.Write("Angiv vinderhold: ");
            string winner = Console.ReadLine();
            Console.Clear();
            control.SaveMatch(tournamentName, round, winner);
        }

    }
}
