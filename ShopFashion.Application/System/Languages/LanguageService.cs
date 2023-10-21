using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopFashion.Data.EF;
using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _config;
        private readonly EShopDbContext _context;

        public LanguageService(EShopDbContext context, IConfiguration config)
        {
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}
