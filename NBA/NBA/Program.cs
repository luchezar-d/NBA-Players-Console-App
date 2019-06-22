using NBA.Data.Model;
using NBA.Service.Services;
using System;

namespace NBA
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerService service = new PlayerService();
            service.LoadJson();
            
            Console.ReadLine();
        }
    }    
}
