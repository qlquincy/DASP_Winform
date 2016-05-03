using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Common
{
    public class Pager
    {
        public int PageIndex
        {
            get;
            set;
        }

        public int PageSize
        {
            get;
            set;
        }

        public int TotalCount
        {
            get;
            set;
        }
    }
}
