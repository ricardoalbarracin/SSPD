using Core.Data;
using Core.Entities;
using Infrastructure.Data.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlcantarilladoRedesController : ControllerBase
    {
        private readonly ILogger<AlcantarilladoRedesController> _logger;
        private readonly IViewAcuRedesRepository _viewAcuRedesRepository;
        private readonly IViewRedesAlcantarilladoRepository _viewRedesAlcantarilladoRepository;
        private readonly IViewTratamientosAguasResidualesRepository _viewTratamientosAguasResidualesRepository;

        public AlcantarilladoRedesController(ILogger<AlcantarilladoRedesController> logger, IViewAcuRedesRepository viewAcuRedesRepository, IViewRedesAlcantarilladoRepository viewRedesAlcantarilladoRepository, IViewTratamientosAguasResidualesRepository viewTratamientosAguasResidualesRepository)
        {
            _logger = logger;
            _viewAcuRedesRepository = viewAcuRedesRepository;
            _viewRedesAlcantarilladoRepository = viewRedesAlcantarilladoRepository;
            _viewTratamientosAguasResidualesRepository = viewTratamientosAguasResidualesRepository;
        }

        [HttpGet(Name = "AlcantarilladoRedesController")]
        public ResultViewRedesAlcantarillado Get(int idEmpresa, string apsDepartamento, string apsMunicipio, int anio, int mes, int pagina, int datosPorPagina)
        {
            var result = _viewRedesAlcantarilladoRepository.GetByCriteria(m => m.Idempresa == idEmpresa && m.Apsdepartamento == apsDepartamento && m.Apsmunicipio == apsMunicipio && m.Anio == anio && m.Mes == mes).Result;
            var skip = (pagina - 1) * datosPorPagina;
            return new ResultViewRedesAlcantarillado { TotalRegistros = result.Count(), Data = result.Skip(skip).Take(datosPorPagina) };
        }
    }
}