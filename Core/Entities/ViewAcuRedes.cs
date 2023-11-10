using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class ViewAcuRedes
    {
        public int? Anio { get; set; }
        public string Apsdepartamento { get; set; }
        public string Apsmunicipio { get; set; }
        public string Areasecctransv { get; set; }
        public string Certificatuberia { get; set; }
        public string Claseducto { get; set; }
        public Decimal? Diametronominal { get; set; }
        public string Fabtuberia { get; set; }
        public DateTime Fchinstalacion { get; set; }
        public int Idempresa { get; set; }
        public Decimal Longitud { get; set; }
        public string Material { get; set; }
        public int? Mes { get; set; }
        public string Nit { get; set; }
        public string Nomempresa { get; set; }
        public string Numcertificado { get; set; }
        public string Numlote { get; set; }
        public int? Nush { get; set; }
        public string Organocertifproducto { get; set; }
        public string Proceso { get; set; }
        public string Secciontransv { get; set; }
        public string Tipoinstall { get; set; }
    }
}
