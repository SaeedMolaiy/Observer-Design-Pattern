namespace Observer.Models
{
    public class ConcreteWatchtowerB : IWatchtower
    {
        public void Update(IAirplane airplane)
        {
            if (((airplane as Airplane)!).Height < 300)
            {
                Console.WriteLine("ConcreteWatchtowerB: Reacted to the event.");
            }
        }
    }
}
