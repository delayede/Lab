using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_1_FaradayTheCat_
{

    //Напишіть класи тут
    public enum Gender { Male, Female };

    public class Cat
    {
        public string Name { get; }

        public Лаб_1_FaradayTheCat_.Gender Gender { get; }

        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

        private double _energy;
        public double Energy
        {
            get { return _energy; }
            private set
            {
                if (value > MaxEnergy) _energy = MaxEnergy;
                else
                {
                    if (value < MinEnergy)
                    {
                        throw new Exception("Not enough energy to jump");
                    }
                    else _energy = value;
                }
            }
        }

        public Cat(string name, Лаб_1_FaradayTheCat_.Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }

        public void Sleep()
        {
            Energy += SleepEnergyGain;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var Tomcat = new Cat("To", Gender.Male);


            Console.ReadLine();
        }
    }
}
