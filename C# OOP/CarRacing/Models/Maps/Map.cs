using System;
using System.Collections.Generic;
using System.Text;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!racerOne.IsAvailable() && racerTwo.IsAvailable())
            {
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerTwo.Username, racerOne.Username);
            }
            else if (!racerTwo.IsAvailable() && racerOne.IsAvailable())
            {
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerOne.Username, racerTwo.Username);
            }
            else if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return OutputMessages.RaceCannotBeCompleted;
            }
            else
            {
                racerOne.Race();
                racerTwo.Race();

                double racerOneMultiplier = racerOne.RacingBehavior == "strict" ? 1.2 : 1.1;
                double racerTwoMultiplier = racerTwo.RacingBehavior == "strict" ? 1.2 : 1.1;

                var racerOneChanceOfWinning = racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOneMultiplier;
                var racerTwoChanceOfWinning = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racerTwoMultiplier;

                string winnerUsername = racerOneChanceOfWinning > racerTwoChanceOfWinning ? racerOne.Username : racerTwo.Username;

                return string.Format(OutputMessages.RacerWinsRace, racerOne.Username, racerTwo.Username, winnerUsername);
            }
        }
    }
}
