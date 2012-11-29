using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.WolfgangMarx.BoatsAway.Model
{
    class Map
    {
        public List<MapTile> MapTiles { get; internal set; }
        public List<Habor> Habours { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int NumberOfHabours { get; set; }

        public Map()
        {
            this.Width = 5;
            this.Height = 5;
            this.NumberOfHabours = 1;
            this.InitialiseBaseMap();
        }

        private void InitialiseBaseMap()
        {
            this.MapTiles = new List<MapTile>();
            //setup the map.
            for (int x = 0; x < this.Width; x++)
            {
                for (int y = 0; y < this.Height; y++)
                {
                    this.MapTiles.Add(new MapTile() { Xquadrat = x, Yquadrat = y });
                }
            }
            /**
             * Create Habours. THis is hardcoded for now... may randomise this later...
             **/
            this.GetTileByPosition(1, 0).Habor = new Habor() { Id = 1, Name = "Hafen-Entwicklungsgesellschaft Rostock" };
            this.GetTileByPosition(1, 1).Habor = new Habor() { Id = 1, Name = "Port of Gdańsk" };
            this.GetTileByPosition(1, 2).Habor = new Habor() { Id = 1, Name = "Port of Tallinn" };
            this.GetTileByPosition(1, 3).Habor = new Habor() { Id = 1, Name = "Sea port of St Petersburg" };
            this.GetTileByPosition(1, 4).Habor = new Habor() { Id = 1, Name = "Port of Helsinki" };

            this.GetTileByPosition(2, 0).Habor = new Habor() { Id = 1, Name = "Ports of Stockholm" };
            this.GetTileByPosition(2, 1).Habor = new Habor() { Id = 1, Name = "Port of Trelleborg" };
            this.GetTileByPosition(2, 2).Habor = new Habor() { Id = 1, Name = "Lübecker Hafen-Gesellschaft" };
            this.GetTileByPosition(2, 3).Habor = new Habor() { Id = 1, Name = "Sea Commercial Port of Kaliningrad" };
            this.GetTileByPosition(2, 4).Habor = new Habor() { Id = 1, Name = "Copenhagen Malmö Port" };
        }

        public MapTile GetTileByPosition(int x, int y)
        {
            return (from m in this.MapTiles where m.Xquadrat == x && m.Yquadrat == y select m).SingleOrDefault();
        }
    
    }
}
