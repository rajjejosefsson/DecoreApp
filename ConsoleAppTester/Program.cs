using Decore.Data.Repositories;
using Decore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    public class Program
    {


        static void Main(string[] args)
        {

           EventRepository _eventRepository = new EventRepository();
           
           var events = _eventRepository.GetEvents();
           string json = JsonConvert.SerializeObject(events);
           Console.WriteLine(json);
           Console.ReadLine();



        }
    }
}
