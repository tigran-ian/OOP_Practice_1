using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_1
{
    internal class Car
    {
        string Brand;
        string Model;
        int Year;
        bool _engineRunning = false;
        bool _isDriving = false;
        bool _lightsOn = false;

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        

        public void StartEngine()
        {
            if(_engineRunning)
                Console.WriteLine("Engine is already running");
            else
            {
                _engineRunning = true;
                Console.WriteLine("The engine is started");
            }
                
        }
        public void StopEngine()
        {
            if (!_engineRunning)
                Console.WriteLine("Engine is already stopped");
            else
            {
                _engineRunning = false;
                Console.WriteLine("The engine is stopped");
            }
        }
        public void Drive()
        {
            if (!_engineRunning)
            {
                Console.WriteLine("Engine is not started");
            }
            else if (_isDriving)
            {
                Console.WriteLine("The car is already driving");
            }
            else
            {
                _isDriving = true;
                Console.WriteLine("The car is driving now");
            }
        }
        public void Accelerate()
        {
            if(!_engineRunning)
                Console.WriteLine("You cannot accelerate because the engine is not started");
            
            else
                Console.WriteLine("The car is accelerating");
        }

        public void TurnLightsOn()
        {
            if(_lightsOn)
                Console.WriteLine("Lights are already on");
            else
            {
                _lightsOn = true;
                Console.WriteLine("Lights are now on");
            }
        }

        public void TurnLightsOff()
        {
            if (!_lightsOn)
                Console.WriteLine("Lights are already off");
            else
            {
                _lightsOn = false;
                Console.WriteLine("Lights are now off");
            }
        }
        public override string ToString()
        {
            return $"{Brand} {Model} {Year}";
        }
    }    
}
