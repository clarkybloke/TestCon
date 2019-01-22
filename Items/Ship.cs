using System.Collections.Generic;

namespace Items
{
    public class Ship
    {
        public Engine TheEngine { get; set; }

        public List<IShipItem> HardPoints;

        public Ship( Engine engine)
        {
            TheEngine = engine;
            HardPoints = new List<IShipItem>();
        }
    }

}