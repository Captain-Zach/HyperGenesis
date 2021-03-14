using System;
using System.Collections;
using System.Collections.Generic;

namespace HyperGenesis
{
    public class Room
    {
        public int[,] Map
        {
            get;
            set;
        }

        public int height
        {
            get;
            set;
        }

        public int width
        {
            get;
            set;
        }

        public Room()
        {
            Map = new int[,] {
                {0,0,0,0,0,0,0,0,0,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,0,0,0,0,0,0,0,0,0}
            };

            height = 10;
            width = 10;
        }

        public void randomize()
        {
            // Console.WriteLine(this.Map.GetLength);
            var rng = new Random();
            Console.WriteLine("Hello world uwu");
            // Console.WriteLine(this.Map.GetLength(0));

            for(int y = 1; y < height - 1; y++)
            {
                for(int x = 1; x < width -1; x++)
                {
                    if(rng.Next(1,3)==1) // 50% chance of wall placement
                    {
                        Map[y,x] = 0;
                    }
                    Console.WriteLine(this.Map[y,x]);
                }
            }
        }

        public RoomExport export()
        {
            RoomExport target = new RoomExport();
            target.Map = this.Map;
            return target;
        }
    }
    public class RoomExport
    {
        public int[,] Map
        {
            get;
            set;
        }
    }
}