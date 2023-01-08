using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class ControlArduino : MonoBehaviour
    {
        private CarController car;
        private SerialPort port = new SerialPort("COM3", 9600);

        void Start()
        {
            car = GetComponent<CarController>();
            port.Open();
        }

        void Update()
        {
            if (car.speed > 0)
                port.Write(car.speed.ToString("F0"));
        }

        void OnApplicationQuit()
        {
            port.Close();
        }
    }
}
