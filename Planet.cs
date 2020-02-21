using System;
using System.Collections.Generic;
using System.Text;

namespace Red_Federation_Space_Game
{
    public class Planet
    {
        //Planet attributes
        public string name;
        public int planetX;
        public int planetY;

        //Planet constructor
        public Planet(string name, int x, int y)
        {
            this.name = name;
            this.planetX = x;
            this.planetY = y;
        }
    }//End Planet Class
}
