using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsMaterialSelection
{
    internal class MaterialObject
    {
        public string? MaterialName { get; set; }

        public int? MaterialTier { get; set; }

        public List<string>? DropLocations { get; set; }

        public Dictionary<int, string>? MaterialToUpgradeTo { get; set; }
    }
}
