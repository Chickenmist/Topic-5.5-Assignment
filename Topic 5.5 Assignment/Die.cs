﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5_Assignment
{
    public class Die
    {
        private int _roll;
        private int _sides;
        private Random _random;

        public Die()
        {
            _random = new Random();
            _roll = _random.Next(1, _sides + 1);
            _sides = 6;
        }

        public Die(int sides)
        {
            _sides = sides;
            _random = new Random();
            _roll = _random.Next(1, _sides + 1);
        }

        public int Roll
        {
            get { return _roll; }
        }

        public int RollDie()
        {
            _roll = _random.Next(1, _sides + 1);
            return _roll;
        }

        public void DrawRoll()
        {
            if(_roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 4) 
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| " +_roll + "  |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }
    }
}
