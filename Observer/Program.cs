using Observer.Models;

// The client code.
var airplane = new Airplane();
var watchtower = new ConcreteWatchtowerA();
airplane.Attach(watchtower);

var observerB = new ConcreteWatchtowerB();
airplane.Attach(observerB);

airplane.ReduceHeight();
airplane.ReduceHeight();

airplane.Detach(observerB);

airplane.ReduceHeight();

Console.ReadKey();