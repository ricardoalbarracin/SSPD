using Core.Data;
using Core.Entities;
using Infrastructure.Data.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TratamientosAguasResidualesController : ControllerBase
    {
        private readonly ILogger<TratamientosAguasResidualesController> _logger;
        private readonly IViewAcuRedesRepository _viewAcuRedesRepository;
        private readonly IViewRedesAlcantarilladoRepository _viewRedesAlcantarilladoRepository;
        private readonly IViewTratamientosAguasResidualesRepository _viewTratamientosAguasResidualesRepository;

        public TratamientosAguasResidualesController(ILogger<TratamientosAguasResidualesController> logger, IViewAcuRedesRepository viewAcuRedesRepository, IViewRedesAlcantarilladoRepository viewRedesAlcantarilladoRepository, IViewTratamientosAguasResidualesRepository viewTratamientosAguasResidualesRepository)
        {
            _logger = logger;
            _viewAcuRedesRepository = viewAcuRedesRepository;
            _viewRedesAlcantarilladoRepository = viewRedesAlcantarilladoRepository;
            _viewTratamientosAguasResidualesRepository = viewTratamientosAguasResidualesRepository;
        }

        [HttpGet(Name = "TratamientosAguasResiduales")]
        public IEnumerable<ViewTratamientosAguasResiduales> Get(int idEmpresa, int apsDepartamento, int apsMunicipio, int anio, int mes)
        {
            return _viewTratamientosAguasResidualesRepository.GetByCriteria(m => m.Idempresa == idEmpresa && m.Apsdepartamento == apsDepartamento && m.Apsmunicipio == apsMunicipio && m.Anio == anio && m.Mes == mes).Result;
            
        }
    }
}