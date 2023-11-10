using Core.Data;
using Core.Entities;
using Infrastructure.Data.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcueductoRedesController : ControllerBase
    {

        private readonly ILogger<AcueductoRedesController> _logger;
        private readonly IViewAcuRedesRepository _viewAcuRedesRepository;
        private readonly IViewRedesAlcantarilladoRepository _viewRedesAlcantarilladoRepository;
        private readonly IViewTratamientosAguasResidualesRepository _viewTratamientosAguasResidualesRepository;

        public AcueductoRedesController(ILogger<AcueductoRedesController> logger, IViewAcuRedesRepository viewAcuRedesRepository, IViewRedesAlcantarilladoRepository viewRedesAlcantarilladoRepository, IViewTratamientosAguasResidualesRepository viewTratamientosAguasResidualesRepository)
        {
            _logger = logger;
            _viewAcuRedesRepository = viewAcuRedesRepository;
            _viewRedesAlcantarilladoRepository = viewRedesAlcantarilladoRepository;
            _viewTratamientosAguasResidualesRepository = viewTratamientosAguasResidualesRepository;
        }

        [HttpGet(Name = "AcueductoRedes")]
        public ResultViewAcuRedes Get(int idEmpresa, string apsDepartamento, string apsMunicipio, int anio, int mes,int pagina, int datosPorPagina)
        {
            var result = _viewAcuRedesRepository.GetByCriteria(m => m.Idempresa == idEmpresa && m.Apsdepartamento == apsDepartamento && m.Apsmunicipio == apsMunicipio && m.Anio == anio && m.Mes == mes).Result;
            var skip = (pagina - 1) * datosPorPagina;
            return new ResultViewAcuRedes {TotalRegistros = result.Count(),Data = result.Skip(skip).Take(datosPorPagina) };
        }
    }
}