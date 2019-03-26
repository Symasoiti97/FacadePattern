using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Things;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeComputerFacade homeComputer = new HomeComputerFacade(new Computer(), new Popcorn());

            homeComputer.OnMovie();
            homeComputer.OffMovie();

            Console.ReadKey();
        }
    }
}
