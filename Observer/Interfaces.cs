namespace Observer
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        // Этот метод вызывается для оповещения наблюдателей об изменении состояния субъекта
        public void NotifyObservers();
    }
    
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        public void Display();
    }

}