using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Intro_till_OOP
{
    internal class Circle
    {   // The only 2 variables for area and circumfrence of a circle
        float _pi = 3.141f;
        int _radius;
        public Circle(int radius)   // Constructor that accepts the radius and assigns it to the private variable _radius

        {
            _radius = radius;
        }
        public float GetArea() // Returns the eqvuation for the area of a circle
        {
            return _radius * _radius * _pi;           
        }
        public float GetCircumfrence()  // Returns the eqvation for the circumfrence of a circle
        {
            return 2 * _pi * _radius;
        }
    }
}
