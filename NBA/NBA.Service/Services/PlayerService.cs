using NBA.Data.Model;
using NBA.Service.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Service.Services
{
    public class PlayerService : IPlayerService
    {
        public void LoadJson()
        {
            string filepath = "SchemaList.json";
            string readResult = string.Empty;
            string writeResult = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var JsonData = JObject.Parse(json).ToString();

                Player player = JsonConvert.DeserializeObject<Player>(JsonData);

                Console.WriteLine("Do you want to to see the JSON data ? click y-for yes, n-for no");
                string yesno = Console.ReadLine();

                if (yesno == "y")
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Player details deserialized from JSON : ");
                    Console.WriteLine("Name : " + player.Name);
                    Console.WriteLine("Playing Since : " + player.PlayingSince);
                    Console.WriteLine("Rating : " + player.Rating);
                    Console.WriteLine("Position : " + player.Position);
                   
                }
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Continue ? y-for yes , n-for no");
                string yesno1 = Console.ReadLine();

                if (yesno1 == "y")
                {
                    InputPlayerDataService service = new InputPlayerDataService();

                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Enter years : ");
                    int years = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter rating : ");
                    int rating = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("---------------------------------------------------------------");
                    service.FilterPlayersByRating(player, rating);
                    Console.WriteLine("---------------------------------------------------------------");
                    service.FilterPlayersByYears(player, years);


                    Console.WriteLine("==========================================================");
                }

            }
        }
    }
}
