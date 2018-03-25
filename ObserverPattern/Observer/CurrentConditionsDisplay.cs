using ObserverPattern.Subject;
using System;

namespace ObserverPattern.Observer
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            // for future unregister
            _weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "Celsius and " + _humidity + "% humidity.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;

            // not the best place to call display -> MVC pattern
            Display();
        }
    }
}
