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
    public class ViewTratamientosAguasResidualesRepository : SqlserverGenericRepository<LamiaDbContext, ViewTratamientosAguasResiduales>, IViewTratamientosAguasResidualesRepository
    {
        public ViewTratamientosAguasResidualesRepository(LamiaDbContext context) : base(context) { }
        public override async Task<ViewTratamientosAguasResiduales> GetById(ViewTratamientosAguasResiduales entity)
        {
            var result = await _context.View2.FirstOrDefaultAsync(x => x.Idempresa == entity.Idempresa);
            return result;
        }
        
    }
}
