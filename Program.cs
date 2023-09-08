using Design_Patterns;

/* 
// SINGLETON PATTERN DEMO
public class Program
{
    public static void Main(string[] args)
    {
        Singleton s1 = Singleton.GetInstance(); // Will instantiate the instance and return it.
        Singleton s2 = Singleton.GetInstance(); // Will return the same instance because it has been instantiated already.
    }
}
*/



/*
// FACTORY PATTERN DEMO
public class Program
{
    public static void Main(string[] args)
    {
        CarFactory factory = new CarFactory();
        ICar audi = factory.GetCar("TwoSeater");
        ICar civic = factory.GetCar("FourSeater");
    }
}
*/



/*
// ABSTRACT FACTORY PATTERN DEMO
public class Program
{
    public static void Main(string[] args)
    {
        FoodFactory jadeCafe = new JadeFactory();
        IBurger myBurgerFromJade = jadeCafe.GetBurger();
        myBurgerFromJade.Make();

        FoodFactory deraRestaurant = new DeraFactory();
        IPizza specialDeraPizza = deraRestaurant.GetPizza();
        specialDeraPizza.Make();
    }
}
*/



/*
// OBSERVER PATTERN DEMO
class Program
{
    public static void Main(string[] args)
    {
        // Make a publisher/subject
        WeatherStation station = new WeatherStation();

        // Make subscribers/observers
        NewsAgency agency1 = new NewsAgency("Geo News");
        NewsAgency agency2 = new NewsAgency("City42");
        NewsAgency agency3 = new NewsAgency("ARY News");
        NewsAgency agency4 = new NewsAgency("Duniya News");

        // Now Attaching the observers/subscriber with the subject/publisher so that the subject knows the list of observers to update to.
        station.Attach(agency1);
        station.Attach(agency2);
        station.Attach(agency3);
        station.Attach(agency4);

        // Change station values to see if subscribers/observers get notified and report the update of not
        station.Temperature = 35.6f;
        station.Temperature = 28f;
        station.Temperature = 40.1f;
        station.Temperature = 30f;
    }
}
*/



// MEDIATOR PATTERN DEMO
public class Program
{
    public static void Main(string[] args)
    {
        ConcreteMediator channel = new ConcreteMediator();

        // Create colleague/communicating classes:
        ConcreteColleagueA UserA = new ConcreteColleagueA(channel);
        ConcreteColleagueB UserB = new ConcreteColleagueB(channel);

        // Setup mediator to recognise these classes:
        channel.colleague1 = UserA;
        channel.colleague2 = UserB;

        // Example communication between users on main channel page:
        UserA.Send("Hello! My name is Tony. What is your name?");
        UserB.Send("Hey Tony! My name is Ezekiel");
    }
}