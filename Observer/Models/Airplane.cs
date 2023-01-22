namespace Observer.Models
{
    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class Airplane : IAirplane
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int Height { get; set; } = 1000;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private readonly List<IWatchtower> _watchtowers = new();

        // The subscription management methods.
        public void Attach(IWatchtower watchtower)
        {
            Console.WriteLine("Air Plane: Attached an watchtower.");
            _watchtowers.Add(watchtower);
        }

        public void Detach(IWatchtower watchtower)
        {
            _watchtowers.Remove(watchtower);
            Console.WriteLine("Air Plane: Detached an watchtower.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Air Plane: Notifying watchtowers...");

            foreach (var watchtower in _watchtowers)
            {
                watchtower.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void ReduceHeight()
        {
            Console.WriteLine("\nAir Plane: I'm lowering the height.");
            Height = new Random().Next(100, 1000);

            Thread.Sleep(15);

            Console.WriteLine("Air Plane: My height has just changed to: " + Height);
            Notify();
        }
    }
}
