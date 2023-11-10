using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ViewTratamientosAguasResiduales
    {
        public int? Anio { get; set; }
        public int Apsdepartamento { get; set; }
        public int Apsmunicipio { get; set; }
        public string Caudalmedioentrada { get; set; }
        public string Caudalmediosalida { get; set; }
        public string Dboentrada { get; set; }
        public string Dbosalida { get; set; }
        public int Idempresa { get; set; }
        public int? Mes { get; set; }
        public string Nombresistema { get; set; }
        public string Nomempresa { get; set; }
        public int Nuptar { get; set; }
        public string Solidototalentrada { get; set; }
        public string Solidototalsalida { get; set; }
    }
}
