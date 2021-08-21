using CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio
{
    public interface INEmploy
    {
        List<EmployModel> ListEmploy();
        EmployModel EmployById(int id);
    }
}
