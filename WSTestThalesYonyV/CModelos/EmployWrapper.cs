using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CModelos
{
    public class EmployWrapper
    {
        public string status { get; set; }
        public List<EmployModel> data { get; set; }
        public string message { get; set; }
    }
}
