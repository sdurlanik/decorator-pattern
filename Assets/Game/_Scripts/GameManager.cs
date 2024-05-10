using System;
using UnityEngine;

namespace SDurlanik.Decorator
{
    public class GameManager : MonoBehaviour
    {
        public CarProvider carProvider;
        

        private void Start()
        {
            carProvider.CreateBmw();
            carProvider.CreateAudi();
        }
    }
}