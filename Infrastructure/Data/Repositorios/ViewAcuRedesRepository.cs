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
    public class ViewAcuRedesRepository : SqlserverGenericRepository<LamiaDbContext, ViewAcuRedes>, IViewAcuRedesRepository
    {
        public ViewAcuRedesRepository(LamiaDbContext context) : base(context) { }
        public override async Task<ViewAcuRedes> GetById(ViewAcuRedes entity)
        {
            var result = await _context.View1.FirstOrDefaultAsync(x => x.Idempresa == entity.Idempresa);
            return result;
        }
        
    }
}
