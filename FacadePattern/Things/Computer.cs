using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Things
{
    class Computer
    {
        Volume volume;

        public Computer()
        {
            volume = new Volume();
        }

        public void On()
        {
            Console.WriteLine("On Computer");
        }

        public void Off()
        {
            Console.WriteLine("Off Computer");
        }

        public void WatchMovie(string movieName)
        {
            Console.WriteLine($"Watch Movie: {movieName}");
        }

        public void PlayGame(string gameName)
        {
            Console.WriteLine($"Play Computer game: {gameName}");
        }

        public void EndGame()
        {
            Console.WriteLine("Turn off the computer game");
        }

        public void OnVolume(uint level)
        {
            volume.On();
            volume.SetVolume(level);
        }

        public void OffVolume()
        {
            volume.Off();
        }
    }
}
