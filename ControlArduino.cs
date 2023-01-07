using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;

namespace UnityStandardAssets.Vehicles.Car
{
    public class ControlArduino : MonoBehaviour
    {
        private CarController car;
        private Rigidbody rb;
        private SerialPort port = new SerialPort("COM3", 9600);
        private int speed = 0;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            car = GetComponent<CarController>();
            port.Open();
        }

        // Update is called once per frame
        void Update()
        {
            print(car.speed);
            if (car.speed > 0)
            {
                speed = Convert.ToInt32(car.speed).ToString();
                port.Write(speed);
                print(speed);
            }
        }

        void OnApplicationQuit()
        {
            port.Close();
        }
    }
}