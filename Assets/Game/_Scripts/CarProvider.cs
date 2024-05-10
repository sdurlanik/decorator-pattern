using System;
using System.Collections.Generic;
using UnityEngine;

namespace SDurlanik.Decorator
{
    [CreateAssetMenu(fileName = "CarProvider", menuName = "SDurlanik/Decorator/CarProvider")]
    public class CarProvider : ScriptableObject
    {
        private ICar _car;
        private string _brand;

        public CarInfo bmwInfo;
        public CarInfo audiInfo;

        public void CreateBmw()
        {
            _brand = bmwInfo.brand;
            _car = new BasicCar(_brand, bmwInfo.price);

            AddPackages(bmwInfo);
            ShowCarInfo(_brand);
        }

        public void CreateAudi()
        {
            _brand = audiInfo.brand;
            _car = new BasicCar(_brand, audiInfo.price);

            AddPackages(audiInfo);
            ShowCarInfo(_brand);
        }

        private readonly Dictionary<PackageType, Func<ICar, float, ICar>> _packageFactories = new()
        {
            { PackageType.Sunroof, (car, price) => new Sunroof(car, price) },
            { PackageType.LeatherSeats, (car, price) => new LeatherSeats(car, price) },
            { PackageType.AlloyWheels, (car, price) => new AlloyWheels(car, price) },
            { PackageType.Spoiler, (car, price) => new Spoiler(car, price) },
        };

        private void AddPackages(CarInfo carInfo)
        {
            foreach (var package in carInfo.packageValues)
            {
                if (_packageFactories.TryGetValue(package.packageType, out var factory))
                {
                    _car = factory(_car, package.price);
                }
            }
        }

        public void ShowCarInfo(string brand)
        {
            var price = _car.CalculatePrice();
            var packages = _car.GetPackages();
            var packageNames = "";
            foreach (var package in packages)
            {
                packageNames += package + ", ";
            }

            packageNames = packageNames.Substring(0, packageNames.Length - 2);
            Debug.Log("Car: " + brand + ", Price: " + price + ", Packages: " + packageNames);
        }
    }
}