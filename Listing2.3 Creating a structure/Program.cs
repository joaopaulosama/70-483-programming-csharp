﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2._3_Creating_a_structure
{
    class Program
    {
        struct Alien {
            public int X;
            public int Y;
            public int Lives;
            public Alien(int x,int y) {
                X = x;
                Y = y;
                Lives = 3;
            }

            public override string ToString()
            {
                return string.Format("X: {0} Y:{1} Lives: {2}",X,Y,Lives);
            }

        }
        static void Main(string[] args)
        {
            Alien a;
            a.X = 50;
            a.Y = 50;
            a.Lives = 3;
            Console.WriteLine("a {0}",a.ToString());
            Alien x = new Alien(100,100);
            Console.WriteLine("x {0}",x.ToString());
            Alien[] swarm = new Alien[100];
            Console.WriteLine("swarm [0] {0}",swarm[0].ToString());
            Console.ReadKey();
        }
    }
}