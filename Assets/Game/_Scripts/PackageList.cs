namespace SDurlanik.Decorator
{
    public class Sunroof : Package
    {
        public Sunroof(ICar car, float price) : base("Sunroof", car, price)
        {
        }
    }

    public class LeatherSeats : Package
    {
        public LeatherSeats(ICar car, float price) : base("Leather Seats", car, price)
        {
        }
    }

    public class AlloyWheels : Package
    {
        public AlloyWheels(ICar car, float price) : base("Alloy Wheels", car, price)
        {
        }
    }

    public class Spoiler : Package
    {
        public Spoiler(ICar car, float price) : base("Spoiler", car, price)
        {
        }
    }
}