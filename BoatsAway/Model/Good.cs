using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.WolfgangMarx.BoatsAway.Model
{
    class Good
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }

        public int Avalability { get; set; }
    }
}
