
using System;
using System.Collections.Generic;
using Pattern.ObserverPattern.ICollection;


namespace Pattern.ObserverPattern
{

    class WeatherData : ISubject
    {
        private List<IObserver> observers;

        public WeatherData()
        {
           
        }

        public void NotifyObservers()
        {
            
        }

        public void RegisterObserver(IObserver o)
        {
            
        }

        public void RemoveObserver(IObserver o)
        {
            
        }
    }
}
