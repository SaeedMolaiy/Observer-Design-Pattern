namespace Observer.Models
{
    public class ConcreteWatchtowerA : IWatchtower
    {
        public void Update(IAirplane airplane)
        {
            if (((airplane as Airplane)!).Height < 500)
            {
                Console.WriteLine("ConcreteWatchtowerA: Reacted to the event.");
            }
        }
    }
}
