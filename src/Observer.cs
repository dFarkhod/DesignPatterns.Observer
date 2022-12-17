namespace VirtualDars.DesignPatterns.Observer
{
    public interface IObserver
    {
        string Name { get; init; }
        void Update(ISubject subject, string message);
    }

    public class Subscriber : IObserver
    {
        public Subscriber(string name)
        {
            Name = name;
        }
        public string Name { get; init; }
        public void Update(ISubject subject, string message)
        {
            if (subject is Youtuber youtuber)
            {
                Console.WriteLine($"{Name}ga yangi habar keldi: {youtuber.Name} yangi video joyladi, nomi - {message}");
            }
        }
    }
}
