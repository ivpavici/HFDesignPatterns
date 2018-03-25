using System.Collections.Generic;
using System.Linq;
using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            var item = _observers.SingleOrDefault(x => x.Equals(o));

            if (item != null)
                _observers.Remove(o);
        }

        // to test data, mimic's getting data
        public void setMeasurments(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }
    }
}
