using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCMB_Support_App.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertPaginationParameterInResponse<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int recodePerPage)
        {
            double count = await queryable.CountAsync();
            double pagesQuantity = Math.Ceiling(count / recodePerPage);
            httpContext.Response.Headers.Add("pagesQuantity", pagesQuantity.ToString());
        }


    }
}
