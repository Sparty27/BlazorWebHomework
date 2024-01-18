using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebHomework.Models
{
    public class PagerProperties
    {
        public int Skip {  get; set; }
        public int Count { get; set; }
        public int PageSize { get; set; }
    }
}
