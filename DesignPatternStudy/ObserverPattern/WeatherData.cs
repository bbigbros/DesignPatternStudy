using System.Collections.Generic;
using DesignPattern.ObserverPattern.ICollection;
using System;

namespace DesignPattern.ObserverPattern.CSubject
{

    class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var a in observers)
            {
                a.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {            
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int idx = observers.IndexOf(o);
            if (idx >= 0)
            {
                observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
