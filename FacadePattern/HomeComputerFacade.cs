using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Things;

namespace FacadePattern
{
    class HomeComputerFacade
    {
        Computer computer;
        Popcorn popcorn;

        public HomeComputerFacade(Computer computer, Popcorn popcorn)
        {
            this.computer = computer;
            this.popcorn = popcorn;
        }

        public void OnMovie()
        {
            popcorn.Cook();
            computer.On();
            computer.OnVolume(5);
            computer.WatchMovie("Name Movie");
        }

        public void OffMovie()
        {
            computer.OffVolume();
            computer.Off();
        }
    }
}
