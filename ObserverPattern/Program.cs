using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern
{
    /// <summary>
    /// 
    /// The Observer Pattern defines a one-to-many dependency between objects so that when one 
    /// object changes state, all of its dependents are notified and updated automatically.
    /// 
    /// DESIGN PRINCIPLES USED:
    /// 
    /// 1) Strive for loosely coupled designs between objects that interact
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            // implement e.g. statisticsDisplay, forecastDisplay and pass the weatherData to them

            weatherData.setMeasurments(30, 65, 30.4f);
        }
    }
}
