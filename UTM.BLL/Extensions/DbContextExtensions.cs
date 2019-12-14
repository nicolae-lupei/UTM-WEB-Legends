using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UTM.BLL.Extensions
{
    public static class DbContextExtensions
    {
        /// <summary>
        /// Save changes async
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<ResultModel> SaveAsync(this DbContext context)
        {
            var rs = new ResultModel();
            try
            {
                await context.SaveChangesAsync();
                rs.IsSuccess = true;
            }
            catch (Exception e)
            {
                rs.Errors.Add(new ErrorModel(nameof(Exception), e.Message));
                rs.Errors.Add(new ErrorModel(nameof(Exception), e.InnerException?.Message));
            }

            return rs;
        }
    }
}
