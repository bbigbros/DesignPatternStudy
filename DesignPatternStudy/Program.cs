using Pattern;
using System;
using DesignPattern.ObserverPattern.CSubject;
using DesignPatternStudy.ObserverPattern.CCurrentConditionDisplay;

namespace DesignPatternStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //RedDuck rd = new RedDuck();
            //rd.Display();
            //rd.Fly();
            //rd.Quack();
            //Console.WriteLine();

            //YelloDuck yd = new YelloDuck();
            //yd.Display();
            //yd.Fly();
            //yd.Quack();
            //Console.WriteLine();

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay cuurentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(78, 68, 34.4f);
            weatherData.SetMeasurements(90, 95, 45.4f);
        }
    }
}
