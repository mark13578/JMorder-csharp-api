using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Business.Dto
{
    public class OrderDto
    {
        public string Casename { get; set; }
        public string Casetype { get; set; }
        public string Print { get; set; }
        public int Quantity { get; set; }
    }
}
