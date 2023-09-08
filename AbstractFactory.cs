
namespace Design_Patterns
{
    interface IPizza
    {
        void Make();
    }

    interface IBurger
    {
        void Make();
    }

    class JadePizza : IPizza
    {
        public void Make()
        {
            Console.WriteLine("Making Jade Cafe Pizza");
        }
    }

    class DeraPizza : IPizza
    {
        public void Make()
        {
            Console.WriteLine("Making Dera Restuarant Pizza");
        }
    }

    class JadeBurger : IBurger
    {
        public void Make()
        {
            Console.WriteLine("Making Jade Cafe special burger");
        }
    }

    class DeraBurger : IBurger
    {
        public void Make()
        {
            Console.WriteLine("Making Dera Restuarant special burger");
        }
    }


    // Make Abstract Factory
    abstract class FoodFactory
    {
        public abstract IPizza GetPizza();
        public abstract IBurger GetBurger();
    }


    // Make Implementation Factories
    class JadeFactory : FoodFactory
    {
        public override IPizza GetPizza()
        {
            return new JadePizza();
        }
        public override IBurger GetBurger()
        {
            return new JadeBurger();
        }
    }

    class DeraFactory : FoodFactory
    {
        public override IPizza GetPizza()
        {
            return new DeraPizza();
        }
        public override IBurger GetBurger()
        {
            return new DeraBurger();
        }
    }

}
