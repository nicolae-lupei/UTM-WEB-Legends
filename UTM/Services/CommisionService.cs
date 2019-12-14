using System.Collections.Generic;
using System.Threading.Tasks;
using UTM.BLL;
using UTM.BLL.Interfaces;
using UTM.DLL.Data;
using UTM.DLL.Models.CommisionModels;

namespace UTM.Presentation.Services
{
    public class CommisionService : ICommisionService
    {
        private readonly ApplicationDbContext _context;

        public CommisionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResultModel> AddComisionAsync()
        {
            return null;
        }

        public async Task<ResultModel<IEnumerable<Commision>>> GetAllComisionsAsync()
        {
            return null;
        }
    }
}
