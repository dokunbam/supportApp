using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCMB_Support_App.Models
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 10;
    }
}
