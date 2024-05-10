using System;
using System.Collections.Generic;
using UnityEngine;

namespace SDurlanik.Decorator
{
    [CreateAssetMenu(fileName = "CarInfo", menuName = "SDurlanik/Decorator/CarInfo")]
    public class CarInfo : ScriptableObject
    {
        public string brand;
        public float price;

        public List<PackageValues> packageValues;
    }

    [Serializable]
    public struct PackageValues
    {
        public PackageType packageType;
        public float price;
    }

    public enum PackageType
    {
        Sunroof,
        LeatherSeats,
        AlloyWheels,
        Spoiler
    }
}