using System;
using System.Collections.Generic;

namespace DragonsLair
{
    public class Menu 
    {
        private Controller control = new Controller(); //hej dsaad
        public List<string> addedgame = new List<string>();
        public bool GameAdded = false;
        public object AddName
        {
            get
            {
                return AddName;
            }

            set
            {
               
            }
        }

        public void Show()
        {
            bool running = true;
            do
            {
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        ShowScore();
                        break;
                    case "2":
                        ScheduleNewRound();
                        break;
                    case "3":
                        SaveMatch();
                        break;
                    case "4":
                        ShowGame();
                        break;
                    case "5":
                        AddGame();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Dragons Lair");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Præsenter turneringsstilling");
            Console.WriteLine("2. Planlæg runde i turnering");
            Console.WriteLine("3. Registrér afviklet kamp");
            Console.WriteLine("4. Vis Spillet");
            Console.WriteLine("5. Tilføj et spil");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("0. Exit");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        
        private void ShowScore()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.ShowScore(tournamentName);
        }

        private void ScheduleNewRound()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.ScheduleNewRound(tournamentName);
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

        public void ShowGame()
        {
            

            if (GameAdded == true)
            {
                Console.WriteLine($"Spilet er: {addedgame[0]} ");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine($"Der er ikke tilføjet et spil til turneringen.");
                Console.WriteLine($"Tilføj venligst et spil.");
            }


        }


        //{
        //    bool Value = true;
        //    Console.WriteLine();

        //    if (Value)
        //    {
        //        Console.WriteLine($"Spillet er: ");
        //        Console.ReadLine();
        //    }

        //    if (!Value)
        //    {
        //        Console.WriteLine("Der er ikke tilføjet et spil");
        //        Console.ReadLine();
        //    }
        //}


        public void AddGame()
        {
            
                

                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine("Tilføj spil: ");
                    addedgame.Add(Console.ReadLine());
                GameAdded = true;
                }
            
        }
    }
}