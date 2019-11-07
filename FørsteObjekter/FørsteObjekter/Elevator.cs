using System;
using System.Collections.Generic;
using System.Text;

namespace FørsteObjekter
{
    class Elevator
    {
        public string Material;
        public bool Closed;
        public bool Empty;
        public bool Moving;
        public bool button;
        public int position;

        public Elevator(string material, bool closed, bool empty, bool moving, bool button, int position)
        {
            Material = material;
            Closed = closed;
            Empty = empty;
            Moving = moving;
            this.button = button;
            this.position = position;
        }

        public void PressButton()
        {
            button = true;
            if(Closed == true)
            {
                Closed = false;
            }
            else
            {
                Console.WriteLine("doors are already open");
            }
            button = false;
        }
        public void GetIn()
        {
            if(Closed != true)
            {
                Empty = false;
            }
            else
            {
                Empty = true;
                Console.WriteLine("The doors are closed you dummy");
            }
        }
        public void PressInsideButton()
        {
            if(Empty =! true)
            {
                Moving = true;
            }
            else
            {
                Console.WriteLine("You have to get inside first...");
            }
        }

    }
}
