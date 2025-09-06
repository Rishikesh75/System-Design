using System;
namespace Facedepattern
{
    public class TV
    {
        public void On() => Console.WriteLine("TV is ON");
        public void Off() => Console.WriteLine("TV is OFF");
    }
    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound System is ON");
        public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
        public void Off() => Console.WriteLine("Sound System is OFF");
    }

    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player is ON");
        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
        public void Off() => Console.WriteLine("DVD Player is OFF");
    }

    public class HomeTheaterFacade
    {
        private TV tv;
        private SoundSystem sound;
        private DVDPlayer dvd;

        public HomeTheaterFacade(TV tv, SoundSystem sound, DVDPlayer dvd)
        {
            this.tv = tv;
            this.sound = sound;
            this.dvd = dvd;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("\nGet ready to watch a movie...");
            tv.On();
            sound.On();
            sound.SetVolume(10);
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("\nShutting movie theater down...");
            dvd.Off();
            sound.Off();
            tv.Off();
        }
    }





}