using System.Collections;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private readonly ArrayList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
            {
                _observers.Remove(i);
            }
        }

        // Оповещение наблюдателей об изменении состояния через метод update(),
        // реализуемый всеми наблюдателями
        public void NotifyObservers()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                IObserver observer = (IObserver)_observers[i];
                observer?.Update(_temperature, _humidity, _pressure);
            }
        }

        // Оповещение наблюдателей о появлении новых данных
        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        // Тестовый метод обновления параметров
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
