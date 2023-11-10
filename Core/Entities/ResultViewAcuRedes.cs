using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class ResultViewAcuRedes
    {
        public int TotalRegistros{ get; set; }
        public IEnumerable<ViewAcuRedes> Data{ get; set; }
        
    }
}
