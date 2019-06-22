using NBA.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Service.Services.Interfaces
{
    public interface IInputPlayerDataService
    {
        void FilterPlayersByRating(Player player,int rating);
        void FilterPlayersByYears(Player player,int years);
        //void AddCSVPath(string path);
    }
}
