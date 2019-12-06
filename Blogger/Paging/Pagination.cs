using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Paging
{
    public static class Pagination
    {
        public static PagedData<T> PagedResult<T>(this List<T> data, int currentPage = 1, int pageSize = 20) where T : class
        {
            List<T> toReturn = data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            int totalPages = (int)Math.Ceiling((double)data.Count() / pageSize);
            return new PagedData<T> { CurrentPage = currentPage, TotalPages = totalPages, Data = toReturn };
        }
    }
}
