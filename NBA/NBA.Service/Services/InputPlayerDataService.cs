using NBA.Data.Model;
using NBA.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Service.Services
{
    /*The service takes the input which is a player and a 
     * rating and checks if a player meets some requirements
     */
     
    public class InputPlayerDataService : IInputPlayerDataService
    {
        List<Player> sortPlayer = new List<Player>();
        readonly int CurrentYear = 2019;

        /*The method gets some input(player and rating),
         * filters the players by rating and sorts the using a LINQ query
         */

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

        /*The method gets some input(player and years),
         * calculates the year a player has played in the NBA
         * and filters via some requirements
         */

        public void FilterPlayersByYears(Player player,int years)
        {
            int NbaPlayerYears = CurrentYear - player.PlayingSince;
            
            if (NbaPlayerYears == years || NbaPlayerYears < years)
            {
                Console.WriteLine("A player has less or equal years to : " + years);
                Console.WriteLine("Current year is : " + CurrentYear);
                Console.WriteLine("Player has been playing for " + NbaPlayerYears + " years");
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
