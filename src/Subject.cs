namespace VirtualDars.DesignPatterns.Observer
{
    public interface ISubject
    {
        void Register(IObserver observer);    // attach
        void Unregister(IObserver observer);  // detach
        void Notify(string message);
    }

    public class Youtuber : ISubject
    {
        public Youtuber(string name)
        {
            Name = name;
        }
        private List<IObserver> _subscribers = new();

        public string Name { get; set; }


        private HashSet<string> _videos = new();
        public void ProduceNewVideo(string videoName)
        {
            _videos.Add(videoName);
            Notify(videoName);
        }

        public void Register(IObserver observer)
        {
            Console.WriteLine($"{Name} ga {observer.Name} obuna bo'ldi.");
            _subscribers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _subscribers.Remove(observer);
        }
        public void Notify(string message)
        {
            _subscribers.ForEach(observer =>
            {
                observer.Update(this, message);
            });
        }
    }

}
