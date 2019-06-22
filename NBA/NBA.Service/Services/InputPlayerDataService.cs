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

        public void FilterPlayersByRating(Player player,int rating)
        {
            if (player.Rating == rating || player.Rating > rating)
            {
                sortPlayer.Add(player);

                var ratingDesc = from x in sortPlayer
                                 where rating >= player.Rating
                                 orderby x descending
                                 select x;

                foreach (var item in ratingDesc)
                {
                    Console.WriteLine("There is a player with equal or greater rating than : " + rating);
                    Console.WriteLine("Name : " + player.Name);
                    Console.WriteLine("Rating : " + player.Rating);
                }

            }
            if (player.Rating > rating)
            {
                Console.WriteLine("There isn't a player with equal or greater rating than : " + rating);
            }
        }

        public void FilterPlayersByYears(Player player,int years)
        {
            if (player.PlayingSince == years || player.PlayingSince < years)
            {
                Console.WriteLine("There is a player with less or equal years to : " + years);
                Console.WriteLine("Name : " + player.Name);
                Console.WriteLine("Playing Since : " + player.PlayingSince);
                Console.WriteLine("Position : " + player.Position);
                Console.WriteLine("Rating : " + player.Rating);
            }
            else
            {
                Console.WriteLine("There isn't a player with less or equal years to  : " + years);
            }
        }
    }
}
