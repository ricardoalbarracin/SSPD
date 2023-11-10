using Core.Data;
using Core.Entities;
using GN.Sanidad.Lamia.EntityFrameworkCore.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositorios
{
    public class ViewRedesAlcantarilladoRepository : SqlserverGenericRepository<LamiaDbContext, ViewRedesAlcantarillado>, IViewRedesAlcantarilladoRepository
    {
        public ViewRedesAlcantarilladoRepository(LamiaDbContext context) : base(context) { }
        public override async Task<ViewRedesAlcantarillado> GetById(ViewRedesAlcantarillado entity)
        {
            var result = await _context.View3.FirstOrDefaultAsync(x => x.Idempresa == entity.Idempresa);
            return result;
        }
        
    }
}
