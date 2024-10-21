using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Intro_till_OOP
{
    internal class Triangel
    {   // The 2 vaiables needed for figuring out the area of a triangle
        float _height;
        float _bas;
        public Triangel(float height, float bas) 
        {
            _height = height;
            _bas = bas; 
        }
        public float GetAreaTriangel()  // Returns the eqvation for the area of a triangle 
        {
            return (_height * _bas) / 2;
        }
    }
}
