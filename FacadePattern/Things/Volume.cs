using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Things
{
    class Volume
    {
        public Volume()
        {

        }

        public void On()
        {
            Console.WriteLine("On Volume");
        }

        public void Off()
        {
            Console.WriteLine("Off Volume");
        }

        public void SetVolume(uint level)
        {
            Console.WriteLine($"Volume level: {level}");
        }
    }
}
