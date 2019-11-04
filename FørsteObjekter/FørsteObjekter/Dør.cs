using System;
using System.Collections.Generic;
using System.Text;

namespace FørsteObjekter
{
    class Door
    {
        public string Color;
        public string Surface;
        public bool smashed;
        public bool closed;
        public bool locked;

        public void OpenDoor()
        {
            closed = false;
        }
        public void CloseDoor()
        {
            closed = true;
        }
        public void SmashDoor()
        {
            smashed = true;
        }
        public void LockDoor()
        {
            locked = true;
        }
        public void UnlockDoor()
        {
            locked = false;
        }
    }
}
