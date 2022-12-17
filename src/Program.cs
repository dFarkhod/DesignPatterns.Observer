using VirtualDars.DesignPatterns.Observer;

Youtuber csDojo = new("CS Dojo");

Subscriber ibrohim = new("Ibrohim");
csDojo.Register(ibrohim);

Subscriber sodiq = new("Sodiq");
csDojo.Register(sodiq);

Subscriber abdullo = new("Abdullo");
csDojo.Register(abdullo);

csDojo.ProduceNewVideo("Big O Notation");

/*Youtuber nickChapsas = new("Nick Chapsas");
nickChapsas.Register(ibrohim);
nickChapsas.ProduceNewVideo("Frozen Collections");*/

Console.ReadLine();