using System;

namespace ConsoleApp35
{
    delegate void HotHouseDeleg();

    internal class HotHouse
    {
        private int temperature;

        public int Min { get; set; }
        public int Max { get; set; }

        public int Temperature
        {
            get => temperature;
            set
            {
                temperature = value;

                if (temperature > Max)
                {
                    Hot();
                }
                else if (temperature < Min)
                {
                    Cold();
                }
                else
                {
                    Well();
                }
            }
        }

        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public event HotHouseDeleg Fine;

        protected virtual void Hot()
        {
            TooHot?.Invoke();
            Console.WriteLine("Too hot");
        }

        protected virtual void Cold()
        {
            TooCold?.Invoke();
            Console.WriteLine("Too cold");
        }

        protected virtual void Well()
        {
            Fine?.Invoke();
            Console.WriteLine("Well");
        }
    }

    internal class Heater
    {
        public void Warm(HotHouse house)
        {
            house.Temperature += 5;
            Console.WriteLine("Warming up");
        }
    }
    internal class Cooler
    {
        public void Cold(HotHouse house)
        {
            house.Temperature -= 5;
            Console.WriteLine("Cooling down");
        }
    }

    
}
