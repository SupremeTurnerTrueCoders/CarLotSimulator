﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {

        }
        
        public Car(int Year,
                   string Make
            ,      string Model, 
                   string EngineNoise ,
                   string HonkNoise,
                   bool IsDrivable)

        {
            Year = Year;
            Make = Make;
            Model = Model;
            EngineNoise = EngineNoise;
            HonkNoise = HonkNoise;
            IsDrivable = IsDrivable;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
      

    }
}

