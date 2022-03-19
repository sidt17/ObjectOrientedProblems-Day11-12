using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class Rice
    {
        public List<TypesOfRice> typesOfRice { get; set; }
        public List<TypesOfRice> typesOfGrains { get; set; }
        public List<TypesOfRice> typesOfwheats { get; set; }

    }
    public class TypesOfRice
    {
        public string Name { get; set; }
        public string  weight { get; set; }
        public string Price { get; set; }

    }
    public class TypesOfGrains
    {
        public string Name { get; set; }
        public string weight { get; set; }
        public string Price { get; set; }
    }
    public class TypesOfwheats
    {
        public string Name { get; set; }
        public string weight { get; set; }
        public string Price { get; set; }

    }
}
