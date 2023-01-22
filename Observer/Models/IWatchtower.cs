namespace Observer.Models
{
    public interface IWatchtower
    {
        // Receive update from subject
        void Update(IAirplane airplane);
    }
}
