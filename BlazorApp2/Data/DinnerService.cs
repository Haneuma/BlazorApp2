using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    // インターフェイスの定義
    public interface IDinnerModel
    {
        Task<List<Dinner>> GetDinnerAsync(CancellationToken ct = default);
    }

    public class DinnerService:IDinnerModel
    {
        private DinnerDbContext DbContext;
        public DinnerService(DinnerDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task<List<Dinner>> GetDinnerAsync(CancellationToken ct = default)
        {
            return await DbContext.Dinners.FromSqlRaw($"SELECT id, date, menu FROM dbo.Dinner").ToListAsync();
        }
    }
}
