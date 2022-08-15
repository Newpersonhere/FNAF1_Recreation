using System;
using System.Collections.Generic;
using System.Text;

namespace FNAF1_Recreation.Animatronics
{
    class FreddyBehavior : IAnimatronicBehavior
    {
        public AnimatronicPath path;

        public FreddyBehavior()
        {
            path = new AnimatronicPath();

            path.AddRoom(Room.rooms[1]);
            path.AddRoom(Room.rooms[]);
            path.AddRoom(Room.rooms[]);
            path.AddRoom(Room.rooms[]);
            path.AddRoom(Room.rooms[]);

        }

        public void OnTick()
        {
            Console.WriteLine("Freddy Tick");
        }

        public bool OnHour(int _) => true;

        public Room OnMove(Room start) { return path.NextRoom(); }
    }
}
