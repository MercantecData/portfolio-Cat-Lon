using System;

namespace FørsteObjekter
{
    class Program
    {
        static void Main(string[] args)
        {
            Door feats = new Door();
            feats.closed = false;
            feats.Color = "gray";
            feats.Surface = "matte";
            feats.locked = false;
            feats.smashed = false;

            Chair cFeats = new Chair();
            cFeats.Legs = 4;
            cFeats.Seat = "Cushioned";
            cFeats.Wheels = true;
            cFeats.BackRest = "Made of plastic";
            cFeats.Color = "black";

            Elevator elevator = new Elevator("metal", true, false, false, false, 0);

        }
    }
}
