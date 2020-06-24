using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerWindow
{
    public class File
    {
        public string Catalog { get; set; }
        public string Name { get; set; }
        public string Exstension { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Deleted { get; set; }
        public int SectorCount { get; set; }
        public bool ReadOnly { get; set; }
        public bool Hidden { get; set; }
        public bool IsBySystem { get; set; }

    }
}
