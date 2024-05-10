using System.Collections;
using System.Collections.Generic;
using SDurlanik.Decorator;
using UnityEngine;

namespace SDurlanik.Decorator
{
    public interface ICar
    {
        float CalculatePrice();

        List<Package> GetPackages();
    }
}