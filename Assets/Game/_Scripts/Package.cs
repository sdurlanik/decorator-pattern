using System.Collections.Generic;

namespace SDurlanik.Decorator
{
    public abstract class Package : ICar
    {
        private string _name;
        protected ICar car;
        protected float price;

        private List<Package> _packageList = new();

        public Package(string name, ICar car, float price)
        {
            _name = name;
            this.car = car;
            this.price = price;

            _packageList.Add(this);
        }

        public float CalculatePrice()
        {
            return car.CalculatePrice() + price;
        }

        public List<Package> GetPackages()
        {
            var currentPackageList = car.GetPackages();
            currentPackageList.Add(this);
            return currentPackageList;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}