using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.WolfgangMarx.BoatsAway.Model
{
    class Boat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxStanima { get; set; }
        public int CurrentStanima { get; set; }

        public int MaxNumberOfGoods { get; set; }
        public List<StoreRoomItem> GoodsOnBoard { get; internal set; }

        public int MaxCannons { get; set; }
        public int CurrentCannons { get; set; }
        
        public int Masts { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        
    }
}
