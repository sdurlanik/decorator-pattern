using System.Collections;
using System.Collections.Generic;
using SDurlanik.Decorator;
using UnityEngine;

namespace SDurlanik.Decorator
{
    public class BasicCar : ICar
    {
        private string _brand;
        private float _price;

        public BasicCar(string brand, float price)
        {
            _brand = brand;
            _price = price;
        }

        public float CalculatePrice()
        {
            return _price;
        }

        public List<Package> GetPackages()
        {
            return new List<Package>();
        }
    }
}