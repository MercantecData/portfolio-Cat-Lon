using System;
using System.Collections.Generic;
using System.Text;

namespace FørsteObjekter
{
    class Chair
    {
        public string Color;
        public bool Wheels;
        public string Seat;
        public string BackRest;
        public int Legs;
        public bool Seated;
        public bool spinning;
        public void Spin()
        {
            spinning = true;
        }
        public void Sit() 
        {
            Seated = true;
        }
    }
}
