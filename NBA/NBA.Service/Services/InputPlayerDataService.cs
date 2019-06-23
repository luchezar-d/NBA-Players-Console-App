using NBA.Data.Model;
using NBA.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Service.Services
{
    public class InputPlayerDataService : IInputPlayerDataService
    {
        List<Player> sortPlayer = new List<Player>();
        readonly int CurrentYear = 2019;

        public void FilterPlayersByRating(Player player,int rating)
        {
            sortPlayer.Add(player);

            var ratingDesc = from x in sortPlayer
                             where rating <= player.Rating
                             orderby x descending
                             select x;
            
            if (player.Rating == rating || player.Rating > rating)
            {
                
                foreach (var item in ratingDesc)
                {
                    Console.WriteLine("There is a player with equal or greater rating than : " + rating);
                    Console.WriteLine("Name : " + player.Name);
                    Console.WriteLine("Rating : " + player.Rating);
                }
            }
            else
            {
                Console.WriteLine("There isn't a player with equal or greater rating than : " + rating);
            }
        }

        public void FilterPlayersByYears(Player player,int years)
        {
            int NbaPlayerYears = CurrentYear - player.PlayingSince;
            
            if (NbaPlayerYears == years || NbaPlayerYears < years)
            {
                Console.WriteLine("A player has less or equal years to : " + years);
                Console.WriteLine("Current year is : " + CurrentYear);
                Console.WriteLine("Player has been playing for " + years + " years");
                Console.WriteLine("Name : " + player.Name);
                Console.WriteLine("Playing since : " + player.PlayingSince);
            }
            else
            {
                Console.WriteLine("A player doesn't have less or equal years to : " + years);
            }
        }
    }
}
