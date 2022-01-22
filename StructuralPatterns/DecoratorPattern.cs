namespace DecoratorPattern 
{
    class DecoratorPattern 
    {
        static void Main(string[] args) 
        {
            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);
            IPizza onionDecorator = new OnionDecorator(tomatoDecorator);

            Console.WriteLine(onionDecorator.getPizzaType());
            Console.ReadLine();
        }
    }

    // base interface
    interface IPizza 
    {
        string getPizzaType();
    }

    // concrete class implementation of interface
    class Pizza : IPizza
    {
        public string getPizzaType()
        {
            return "This is a normal Pizza";
        }
    }

    // base decorator
    class PizzaDecorator : IPizza
    {
        public IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string getPizzaType()
        {
            return _pizza.getPizzaType();
        }
    }

    // concrete decorators
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string getPizzaType()
        {
            string type = base.getPizzaType();
            type += "\n with extra cheese";
            return type;
        }
    }

    class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string getPizzaType()
        {
            string type = base.getPizzaType();
            type += "\n with extra tomato";
            return type;
        }
    }

    class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string getPizzaType()
        {
            string type = base.getPizzaType();
            type += "\n with extra onion";
            return type;
        }
    }
}
