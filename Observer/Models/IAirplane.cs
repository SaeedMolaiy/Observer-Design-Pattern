namespace Observer.Models
{
    public interface IAirplane
    {
        // Attach an observer to the subject.
        void Attach(IWatchtower watchtower);

        // Detach an observer from the subject.
        void Detach(IWatchtower watchtower);

        // Notify all observers about an event.
        void Notify();
    }
}
